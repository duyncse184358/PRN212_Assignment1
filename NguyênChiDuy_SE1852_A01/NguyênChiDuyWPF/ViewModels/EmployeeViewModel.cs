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
    public class EmployeeViewModel : BaseViewModel
    {
        private readonly IEmployeeService _employeeService = SingletonHelper.EmployeeService;

        public ObservableCollection<Employee> Employees { get; set; } = new();
        public Employee? SelectedEmployee { get; set; }

        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public EmployeeViewModel()
        {
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit);
            DeleteCommand = new RelayCommand(Delete);
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            Employees.Clear();
            foreach (var e in _employeeService.GetEmployees())
                Employees.Add(e);
        }

        private void Add()
        {
            var vm = new EmployeeDialogViewModel();
            var dialog = new EmployeeDialog { DataContext = vm };
            if (dialog.ShowDialog() == true)
            {
                _employeeService.Add(vm.Employee);
                LoadEmployees();
            }
        }

        private void Edit()
        {
            if (SelectedEmployee == null)
            {
                MessageBox.Show("Please select an employee to edit.", "No Employee Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var vm = new EmployeeDialogViewModel(SelectedEmployee);
            var dialog = new EmployeeDialog { DataContext = vm };
            if (dialog.ShowDialog() == true)
            {
                _employeeService.Update(vm.Employee);
                LoadEmployees();
            }
        }

        private void Delete()
        {
            if (SelectedEmployee == null)
            {
                MessageBox.Show("Please select an employee to delete.", "No Employee Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (MessageBox.Show($"Are you sure you want to delete employee '{SelectedEmployee.Name}'?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _employeeService.Delete(SelectedEmployee.EmployeeID);
                LoadEmployees();
            }
        }
    }
}