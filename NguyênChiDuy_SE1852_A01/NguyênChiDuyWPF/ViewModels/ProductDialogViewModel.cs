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