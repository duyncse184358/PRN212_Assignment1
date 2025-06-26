using BusinessObjects.Models;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
        Category? GetById(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}