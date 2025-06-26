using BusinessObjects.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category? GetById(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}