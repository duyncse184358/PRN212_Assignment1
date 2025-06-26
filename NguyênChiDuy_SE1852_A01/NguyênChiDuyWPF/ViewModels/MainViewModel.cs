using NguyênChiDuyWPF.Commands;
using NguyênChiDuyWPF.Views;
using System.Linq; // Thêm cho OfType
using System.Windows;
using System.Windows.Input;

namespace NguyênChiDuyWPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string WelcomeMessage { get; set; }
        public bool IsAdmin => AppContext.IsAdmin; // Dùng thuộc tính IsAdmin của AppContext
        public bool IsCustomer => AppContext.IsCustomer; // Dùng thuộc tính IsCustomer của AppContext

        public ICommand LogoutCommand { get; }
        public ICommand OpenCustomerCommand { get; }
        public ICommand OpenProductCommand { get; }
        public ICommand OpenOrderCommand { get; }
        public ICommand OpenCategoryCommand { get; }
        public ICommand OpenEmployeeCommand { get; }
        public ICommand OpenReportCommand { get; }
        public ICommand OpenProfileCommand { get; }
        public ICommand OpenOrderHistoryCommand { get; }

        public MainViewModel()
        {
            WelcomeMessage = $"Welcome, {AppContext.CurrentUserName} ({AppContext.CurrentRole})";

            LogoutCommand = new RelayCommand(Logout);
            OpenCustomerCommand = new RelayCommand(() => new CustomerWindow().Show());
            OpenProductCommand = new RelayCommand(() => new ProductWindow().Show());
            OpenOrderCommand = new RelayCommand(() => new OrderWindow().Show());
            OpenCategoryCommand = new RelayCommand(() => new CategoryWindow().Show());
            OpenEmployeeCommand = new RelayCommand(() => new EmployeeWindow().Show());
            OpenReportCommand = new RelayCommand(() => new ReportWindow().Show());
            OpenProfileCommand = new RelayCommand(() => new ProfileWindow().Show());
            OpenOrderHistoryCommand = new RelayCommand(() => new OrderHistoryWindow().Show());
        }

        private void Logout()
        {
            
            foreach (Window window in Application.Current.Windows.OfType<Window>().ToList()) 
            {
                if (!(window is LoginWindow)) 
                {
                    window.Close();
                }
            }

            AppContext.Reset(); 
            new LoginWindow().Show(); 
        }
    }
}