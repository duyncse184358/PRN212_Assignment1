using BusinessObjects.Models;
using NguyênChiDuyWPF.Commands;
using Services.Helpers;
using Services.Interfaces;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System; // For DateTime

namespace NguyênChiDuyWPF.ViewModels
{
    public class ReportViewModel : BaseViewModel
    {
        private readonly IOrderService _orderService = SingletonHelper.OrderService;

        public ObservableCollection<Order> Orders { get; set; } = new();
        public DateTime FromDate { get; set; } = DateTime.Today.AddDays(-7);
        public DateTime ToDate { get; set; } = DateTime.Today;

        public int OrderCount => Orders.Count;

        public ICommand GenerateReportCommand { get; }

        public ReportViewModel()
        {
            GenerateReportCommand = new RelayCommand(GenerateReport);
           
            GenerateReport();
        }

        private void GenerateReport()
        {
            var result = _orderService.GetByDateRange(FromDate, ToDate);
            Orders.Clear();
            if (result != null)
            {
                foreach (var order in result)
                    Orders.Add(order);
            }
            OnPropertyChanged(nameof(OrderCount));
        }
    }
}