using BusinessObjects.Models;
using DataAccessObjects.DAO;
using Repositories.Interfaces;
using System.Collections.Generic;

namespace Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts() => ProductDAO.GetAll();
        public Product? GetById(int id) => ProductDAO.GetById(id);
        public void Add(Product product) => ProductDAO.Add(product);
        public void Update(Product product) => ProductDAO.Update(product);
        public void Delete(int id) => ProductDAO.Delete(id);
        public List<Product> Search(string keyword) => ProductDAO.Search(keyword);
    }
}