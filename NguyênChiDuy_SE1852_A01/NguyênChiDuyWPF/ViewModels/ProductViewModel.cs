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
            // Khởi tạo các Command
            SearchCommand = new RelayCommand(Search);
            AddCommand = new RelayCommand(Add);
            EditCommand = new RelayCommand(Edit);
            DeleteCommand = new RelayCommand(Delete);

            // Tải dữ liệu ban đầu khi ViewModel được tạo
            LoadProducts();
        }

        private void LoadProducts()
        {
            Products.Clear();
            // Lấy tất cả sản phẩm từ service và thêm vào ObservableCollection
            _productService.GetProducts().ForEach(p => Products.Add(p));
        }

        private void Search()
        {
            // Tìm kiếm sản phẩm dựa trên từ khóa và cập nhật danh sách hiển thị
            var result = _productService.Search(SearchKeyword);
            Products.Clear();
            result.ForEach(p => Products.Add(p));
        }

        private void Add()
        {
            // Tạo một ProductDialog mới và gán DataContext là ProductDialogViewModel
            var dialog = new Views.ProductDialog();
            dialog.DataContext = new ProductDialogViewModel();

            // Hiển thị dialog modal
            if (dialog.ShowDialog() == true) // Nếu người dùng nhấn "Save" trong dialog
            {
                var vm = dialog.DataContext as ProductDialogViewModel;
                if (vm != null)
                {
                    _productService.Add(vm.Product); // Thêm sản phẩm mới vào hệ thống
                    LoadProducts(); // Tải lại danh sách để cập nhật UI
                }
            }
        }

        private void Edit()
        {
            // Kiểm tra xem đã có sản phẩm nào được chọn chưa
            if (SelectedProduct == null)
            {
                MessageBox.Show("Please select a product to edit.", "No Product Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Tạo ProductDialog với DataContext là ProductDialogViewModel của sản phẩm được chọn
            var dialog = new Views.ProductDialog
            {
                DataContext = new ProductDialogViewModel(SelectedProduct)
            };

            // Hiển thị dialog modal
            if (dialog.ShowDialog() == true) // Nếu người dùng nhấn "Save" trong dialog
            {
                var vm = dialog.DataContext as ProductDialogViewModel;
                if (vm != null)
                {
                    _productService.Update(vm.Product); // Cập nhật thông tin sản phẩm
                    LoadProducts(); // Tải lại danh sách để cập nhật UI
                }
            }
        }

        private void Delete()
        {
            // Kiểm tra xem đã có sản phẩm nào được chọn chưa
            if (SelectedProduct == null)
            {
                MessageBox.Show("Please select a product to delete.", "No Product Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Hỏi xác nhận trước khi xóa
            if (MessageBox.Show($"Are you sure you want to delete product '{SelectedProduct.ProductName}'?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                _productService.Delete(SelectedProduct.ProductID); // Xóa sản phẩm
                LoadProducts(); // Tải lại danh sách để cập nhật UI
            }
        }
    }
}