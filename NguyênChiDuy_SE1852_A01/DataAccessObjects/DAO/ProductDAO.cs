using BusinessObjects.Models;
using System.Collections.Generic;
using System.Linq;
using System; // For StringComparison

namespace DataAccessObjects.DAO
{
    public class ProductDAO
    {
        private static List<Product> productList = new();

        // Static constructor để tạo dữ liệu mẫu
        static ProductDAO()
        {
            productList.Add(new Product { ProductID = 1, ProductName = "Laptop XPS 15", CategoryID = 1, UnitPrice = 1500.00M, UnitsInStock = 50 });
            productList.Add(new Product { ProductID = 2, ProductName = "Smartphone Galaxy S23", CategoryID = 1, UnitPrice = 999.99M, UnitsInStock = 120 });
            productList.Add(new Product { ProductID = 3, ProductName = "The Lord of the Rings", CategoryID = 2, UnitPrice = 20.50M, UnitsInStock = 300 });
            productList.Add(new Product { ProductID = 4, ProductName = "T-shirt Cotton", CategoryID = 3, UnitPrice = 15.00M, UnitsInStock = 500 });
        }

        public static List<Product> GetAll() => productList;

        public static Product? GetById(int id) =>
            productList.FirstOrDefault(p => p.ProductID == id);

        public static void Add(Product product)
        {
            product.ProductID = productList.Any() ? productList.Max(p => p.ProductID) + 1 : 1;
            productList.Add(product);
        }

        public static void Update(Product product)
        {
            var existing = GetById(product.ProductID);
            if (existing != null)
            {
                existing.ProductName = product.ProductName;
                existing.CategoryID = product.CategoryID;
                existing.UnitPrice = product.UnitPrice;
                existing.UnitsInStock = product.UnitsInStock;
            }
        }

        public static void Delete(int id)
        {
            var product = GetById(id);
            if (product != null) productList.Remove(product);
        }

        public static List<Product> Search(string keyword) =>
            productList.Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}