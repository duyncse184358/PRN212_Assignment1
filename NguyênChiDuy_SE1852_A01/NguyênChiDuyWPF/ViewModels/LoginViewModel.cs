using System.Windows;
using System.Windows.Input;
using NguyênChiDuyWPF.Commands;
using NguyênChiDuyWPF.Views;
using Services.Helpers;
using Services.Interfaces;
using System.Linq; // Cần thiết cho FirstOrDefault

namespace NguyênChiDuyWPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IEmployeeService _employeeService = SingletonHelper.EmployeeService;
        private readonly ICustomerService _customerService = SingletonHelper.CustomerService;

        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string Phone { get; set; } = "";

        public ICommand LoginCommand { get; }
        public ICommand LoginCustomerCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(LoginAsAdmin);
            LoginCustomerCommand = new RelayCommand(LoginAsCustomer);
        }

        private void LoginAsAdmin()
        {
            if (_employeeService.ValidateLogin(Username, Password))
            {
                // Lấy thông tin chi tiết của admin để lưu vào AppContext nếu cần
                var adminUser = _employeeService.GetByUsername(Username);
                AppContext.CurrentUserName = adminUser?.Name ?? Username;
                AppContext.CurrentRole = "Admin";

                new MainWindow().Show();
                CloseLoginWindow();
            }
            else
            {
                MessageBox.Show("Invalid admin credentials.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoginAsCustomer()
        {
            if (!string.IsNullOrWhiteSpace(Phone))
            {
                var customer = _customerService.GetCustomers().FirstOrDefault(c => c.Phone == Phone);

                if (customer != null)
                {
                    AppContext.CurrentUserName = customer.ContactName;
                    AppContext.CurrentRole = "Customer";
                    AppContext.CurrentCustomerID = customer.CustomerID;

                    new MainWindow().Show();
                    CloseLoginWindow();
                }
                else
                {
                    MessageBox.Show("Phone number not found or invalid.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter your phone number.", "Login Required", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void CloseLoginWindow()
        {
            // Đóng cửa sổ LoginWindow hiện tại
            Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault()?.Close();
        }
    }
}