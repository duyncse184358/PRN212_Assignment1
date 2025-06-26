using BusinessObjects.Models;

namespace NguyênChiDuyWPF.ViewModels
{
    public class ProductDialogViewModel : BaseViewModel
    {
        public Product Product { get; set; }

        public ProductDialogViewModel()
        {
            Product = new Product();
        }

        public ProductDialogViewModel(Product original)
        {
            // Tạo một bản sao để tránh chỉnh sửa trực tiếp đối tượng gốc
            Product = new Product
            {
                ProductID = original.ProductID,
                ProductName = original.ProductName,
                CategoryID = original.CategoryID,
                UnitPrice = original.UnitPrice,
                UnitsInStock = original.UnitsInStock
            };
        }
    }
}