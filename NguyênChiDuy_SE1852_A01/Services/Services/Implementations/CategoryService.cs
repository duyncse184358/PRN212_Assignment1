using BusinessObjects.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;

        public CategoryService(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public List<Category> GetCategories() => _repo.GetCategories();
        public Category? GetById(int id) => _repo.GetById(id);
        public void Add(Category category) => _repo.Add(category);
        public void Update(Category category) => _repo.Update(category);
        public void Delete(int id) => _repo.Delete(id);
    }
}