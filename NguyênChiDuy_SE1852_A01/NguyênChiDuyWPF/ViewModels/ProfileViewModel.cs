using BusinessObjects.Models;
using NguyênChiDuyWPF.Commands;
using Services.Helpers;
using Services.Interfaces;
using System.Windows;
using System.Windows.Input;

namespace NguyênChiDuyWPF.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }

        private readonly ICustomerService _customerService = SingletonHelper.CustomerService;

        public ICommand SaveCommand { get; }

        public ProfileViewModel()
        {
            
            Customer = _customerService.GetById(AppContext.CurrentCustomerID) ?? new Customer();
            SaveCommand = new RelayCommand(Save);
        }

        private void Save()
        {
            _customerService.Update(Customer);
            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}