// File: Services/Interfaces/IProductService.cs
using BusinessObjects;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id); // <-- ??m b?o dòng này có
        IEnumerable<Product> GetProductsByCategoryId(int categoryId);
        IEnumerable<Product> SearchProductsByName(string productName);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}