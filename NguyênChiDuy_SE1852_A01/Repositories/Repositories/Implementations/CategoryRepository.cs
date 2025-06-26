using BusinessObjects.Models;
using DataAccessObjects.DAO;
using Repositories.Interfaces;
using System.Collections.Generic;

namespace Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories() => CategoryDAO.GetAll();
        public Category? GetById(int id) => CategoryDAO.GetById(id);
        public void Add(Category category) => CategoryDAO.Add(category);
        public void Update(Category category) => CategoryDAO.Update(category);
        public void Delete(int id) => CategoryDAO.Delete(id);
    }
}