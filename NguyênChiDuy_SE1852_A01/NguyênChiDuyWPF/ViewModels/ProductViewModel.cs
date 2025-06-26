using BusinessObjects.Models;
using NguyênChiDuyWPF.Commands;
using Services.Helpers;
using Services.Interfaces;
using System.Collections.ObjectModel;
using System.Linq; // Cần cho ForEach và LINQ methods
using System.Windows;
using System.Windows.Input;

namespace NguyênChiDuyWPF.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        private readonly IProductService _productService = SingletonHelper.ProductService;

        public ObservableCollection<Product> Products { get; set; } = new();
        public Product? SelectedProduct { get; set; }
        public string SearchKeyword { get; set; } = "";

        public ICommand SearchCommand { get; }
        public ICommand AddCommand { get; }
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public ProductViewModel()
        {
            
            SearchCommand = new RelayCommand(Search);
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit);
            DeleteCommand = new RelayCommand(Delete);

           
            LoadProducts();
        }

        private void LoadProducts()
        {
            Products.Clear();
            
            _productService.GetProducts().ForEach(p => Products.Add(p));
        }

        private void Search()
        {
           
            var result = _productService.Search(SearchKeyword);
            Products.Clear();
            result.ForEach(p => Products.Add(p));
        }

        private void Add()
        {
           
            var dialog = new Views.ProductDialog();
            dialog.DataContext = new ProductDialogViewModel();

            
            if (dialog.ShowDialog() == true) 
            {
                var vm = dialog.DataContext as ProductDialogViewModel;
                if (vm != null)
                {
                    _productService.Add(vm.Product); 
                    LoadProducts(); 
                }
            }
        }

        private void Edit()
        {
           
            if (SelectedProduct == null)
            {
                MessageBox.Show("Please select a product to edit.", "No Product Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

           
            var dialog = new Views.ProductDialog
            {
                DataContext = new ProductDialogViewModel(SelectedProduct)
            };

            
            if (dialog.ShowDialog() == true) 
            {
                var vm = dialog.DataContext as ProductDialogViewModel;
                if (vm != null)
                {
                    _productService.Update(vm.Product);
                    LoadProducts();
                }
            }
        }

        private void Delete()
        {
           
            if (SelectedProduct == null)
            {
                MessageBox.Show("Please select a product to delete.", "No Product Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

           
            if (MessageBox.Show($"Are you sure you want to delete product '{SelectedProduct.ProductName}'?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _productService.Delete(SelectedProduct.ProductID);
                LoadProducts(); 
            }
        }
    }
}