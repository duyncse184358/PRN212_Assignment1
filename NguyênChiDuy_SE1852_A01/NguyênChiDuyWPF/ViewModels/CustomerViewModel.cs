using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using BusinessObjects.Models;
using NguyênChiDuyWPF.Commands;
using NguyênChiDuyWPF.Views;
using Services.Helpers;
using Services.Interfaces;

namespace NguyênChiDuyWPF.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        private readonly ICustomerService _customerService = SingletonHelper.CustomerService;

        public ObservableCollection<Customer> Customers { get; set; } = new();
        public Customer? SelectedCustomer { get; set; }

        public string SearchKeyword { get; set; } = "";

        public ICommand SearchCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public CustomerViewModel()
        {
            SearchCommand = new RelayCommand(Search);
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit);
            DeleteCommand = new RelayCommand(Delete);
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            Customers.Clear();
            foreach (var c in _customerService.GetCustomers())
                Customers.Add(c);
        }

        private void Search()
        {
            Customers.Clear();
            var result = _customerService.Search(SearchKeyword);
            foreach (var c in result)
                Customers.Add(c);
        }

        private void Add()
        {
            var vm = new CustomerDialogViewModel();
            var dialog = new CustomerDialog { DataContext = vm };
            if (dialog.ShowDialog() == true)
            {
                _customerService.Add(vm.Customer);
                LoadCustomers();
            }
        }

        private void Edit()
        {
            if (SelectedCustomer == null)
            {
                MessageBox.Show("Please select a customer to edit.", "No Customer Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var vm = new CustomerDialogViewModel(SelectedCustomer);
            var dialog = new CustomerDialog { DataContext = vm };
            if (dialog.ShowDialog() == true)
            {
                _customerService.Update(vm.Customer);
                LoadCustomers();
            }
        }

        private void Delete()
        {
            if (SelectedCustomer == null)
            {
                MessageBox.Show("Please select a customer to delete.", "No Customer Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete customer '{SelectedCustomer.CompanyName}'?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _customerService.Delete(SelectedCustomer.CustomerID);
                LoadCustomers();
            }
        }
    }
}