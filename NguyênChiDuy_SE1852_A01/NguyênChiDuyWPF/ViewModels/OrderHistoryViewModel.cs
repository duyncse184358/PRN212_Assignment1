using NguyênChiDuyWPF.Models; // Đảm bảo đúng OrderHistoryItem được sử dụng
using Services.Helpers;
using Services.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.Linq;
// using System.Windows; // Chỉ cần khi dùng MessageBox.Show()

namespace NguyênChiDuyWPF.ViewModels
{
    public class OrderHistoryViewModel : BaseViewModel
    {
        private readonly IOrderService _orderService = SingletonHelper.OrderService;
        private readonly IOrderDetailService _detailService = SingletonHelper.OrderDetailService;

        public ObservableCollection<OrderHistoryItem> Orders { get; set; } = new();

        public OrderHistoryViewModel()
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            Orders.Clear();

            // Kiểm tra ID khách hàng có hợp lệ hay không trước khi gọi service
            if (AppContext.CurrentCustomerID <= 0)
            {
                Console.WriteLine("Warning: CurrentCustomerID is not set. Cannot load orders for customer.");
                // MessageBox.Show("Vui lòng đăng nhập với tài khoản khách hàng để xem lịch sử đơn hàng.", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var orderList = _orderService.GetByCustomer(AppContext.CurrentCustomerID);

            if (orderList == null || !orderList.Any())
            {
                Console.WriteLine($"No orders found for Customer ID: {AppContext.CurrentCustomerID}");
                return;
            }

            foreach (var order in orderList.OrderByDescending(o => o.OrderDate))
            {
                var details = _detailService.GetByOrderId(order.OrderID);

                decimal total = 0;
                if (details != null)
                {
                    total = details.Sum(d => d.UnitPrice * d.Quantity * (1 - (decimal)d.Discount));
                }

                Orders.Add(new OrderHistoryItem
                {
                    OrderID = order.OrderID,
                    OrderDate = order.OrderDate,
                    TotalAmount = total
                });
            }
        }
    }
}