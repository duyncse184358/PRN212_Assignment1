using BusinessObjects.Models;
using NguyênChiDuyWPF.Commands;
using NguyênChiDuyWPF.Models; // For OrderDetailDisplayModel
using Services.Helpers;
using Services.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace NguyênChiDuyWPF.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        private readonly IOrderService _orderService = SingletonHelper.OrderService;
        private readonly IOrderDetailService _detailService = SingletonHelper.OrderDetailService;
        private readonly ICustomerService _customerService = SingletonHelper.CustomerService;
        private readonly IProductService _productService = SingletonHelper.ProductService;

        public ObservableCollection<Customer> Customers { get; set; } = new();
        public ObservableCollection<Product> Products { get; set; } = new();
        // Sử dụng OrderDetailDisplayModel thay cho OrderDetailViewModel nếu nó chỉ là để hiển thị
        public ObservableCollection<OrderDetailDisplayModel> OrderDetails { get; set; } = new();

        public Customer? SelectedCustomer { get; set; }
        public Product? SelectedProduct { get; set; }

        public int Quantity { get; set; } = 1;
        public float Discount { get; set; } = 0; // Giữ là float nếu BusinessObject OrderDetail.Discount là float

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public decimal TotalAmount => OrderDetails.Sum(d => d.Total);

        public ICommand AddProductCommand { get; }
        public ICommand SaveOrderCommand { get; }

        public OrderViewModel()
        {
            AddProductCommand = new RelayCommand(AddProduct);
            SaveOrderCommand = new RelayCommand(SaveOrder);
            LoadData();
        }

        private void LoadData()
        {
            Customers = new ObservableCollection<Customer>(_customerService.GetCustomers());
            Products = new ObservableCollection<Product>(_productService.GetProducts());
            // Kiểm tra để tránh null nếu danh sách rỗng
            SelectedCustomer = Customers.FirstOrDefault();
            SelectedProduct = Products.FirstOrDefault();
        }

        private void AddProduct()
        {
            if (SelectedProduct == null || Quantity <= 0)
            {
                MessageBox.Show("Please select a product and enter a valid quantity (> 0).", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Discount < 0 || Discount > 1) // Kiểm tra Discount hợp lệ
            {
                MessageBox.Show("Discount must be between 0 and 1.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Kiểm tra số lượng tồn kho (bổ sung nếu cần)
            if (SelectedProduct.UnitsInStock < Quantity)
            {
                MessageBox.Show($"Not enough {SelectedProduct.ProductName} in stock. Available: {SelectedProduct.UnitsInStock}", "Out of Stock", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var detail = new OrderDetailDisplayModel // Sử dụng OrderDetailDisplayModel
            {
                ProductID = SelectedProduct.ProductID,
                ProductName = SelectedProduct.ProductName,
                Quantity = Quantity,
                UnitPrice = SelectedProduct.UnitPrice,
                Discount = (decimal)Discount // Cast float sang decimal để lưu
            };

            // Kiểm tra nếu sản phẩm đã có trong OrderDetails để tăng số lượng
            var existingDetail = OrderDetails.FirstOrDefault(d => d.ProductID == detail.ProductID);
            if (existingDetail != null)
            {
                existingDetail.Quantity += detail.Quantity;
                // Cần thông báo PropertyChanged thủ công cho DataGrid nếu Quantity thay đổi trực tiếp trên item
                // Ví dụ: làm mới item trong ObservableCollection hoặc dùng INotifyPropertyChanged trong OrderDetailDisplayModel
            }
            else
            {
                OrderDetails.Add(detail);
            }

            OnPropertyChanged(nameof(TotalAmount)); // Cập nhật tổng tiền

            // Reset các trường nhập liệu sau khi thêm
            SelectedProduct = null;
            Quantity = 1;
            Discount = 0;
            OnPropertyChanged(nameof(SelectedProduct)); // Thông báo cho UI nếu bạn reset SelectedProduct
            OnPropertyChanged(nameof(Quantity));
            OnPropertyChanged(nameof(Discount));
        }

        private void SaveOrder()
        {
            if (SelectedCustomer == null)
            {
                MessageBox.Show("Please select a customer.", "Missing Customer", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (OrderDetails.Count == 0)
            {
                MessageBox.Show("Please add products to the order.", "Empty Order", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var order = new Order
            {
                CustomerID = SelectedCustomer.CustomerID,
                EmployeeID = AppContext.CurrentRole == "Admin" ? 1 : 0, // Giả định ID nhân viên là 1 nếu là Admin. Cần cải thiện việc này.
                OrderDate = DateTime.Now
            };

            _orderService.Add(order); // DAO sẽ tự tăng OrderID

            foreach (var item in OrderDetails)
            {
                var detail = new OrderDetail
                {
                    OrderID = order.OrderID,
                    ProductID = item.ProductID,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Discount = (float)item.Discount // Đảm bảo Discount trong OrderDetail là decimal hoặc cast hợp lý
                };
                _detailService.Add(detail);

                // Cập nhật số lượng tồn kho (nếu có yêu cầu)
                var productInStock = _productService.GetById(item.ProductID);
                if (productInStock != null)
                {
                    productInStock.UnitsInStock -= item.Quantity;
                    _productService.Update(productInStock);
                }
            }

            MessageBox.Show($"Order #{order.OrderID} saved successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            // Clear order form after saving
            SelectedCustomer = Customers.FirstOrDefault();
            OrderDetails.Clear();
            OnPropertyChanged(nameof(SelectedCustomer));
            OnPropertyChanged(nameof(TotalAmount));
        }
    }
}