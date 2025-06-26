using BusinessObjects.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product? GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        List<Product> Search(string keyword);
    }
}