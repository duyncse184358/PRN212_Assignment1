using BusinessObjects.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects.DAO
{
    public class CategoryDAO
    {
        private static List<Category> categoryList = new();

        // Static constructor để tạo dữ liệu mẫu
        static CategoryDAO()
        {
            categoryList.Add(new Category { CategoryID = 1, CategoryName = "Electronics", Description = "Devices and gadgets" });
            categoryList.Add(new Category { CategoryID = 2, CategoryName = "Books", Description = "Printed and digital books" });
            categoryList.Add(new Category { CategoryID = 3, CategoryName = "Clothes", Description = "Apparel and accessories" });
        }

        public static List<Category> GetAll() => categoryList;

        public static Category? GetById(int id) =>
            categoryList.FirstOrDefault(c => c.CategoryID == id);

        public static void Add(Category category)
        {
            category.CategoryID = categoryList.Any() ? categoryList.Max(c => c.CategoryID) + 1 : 1;
            categoryList.Add(category);
        }

        public static void Update(Category category)
        {
            var existing = GetById(category.CategoryID);
            if (existing != null)
            {
                existing.CategoryName = category.CategoryName;
                existing.Description = category.Description;
            }
        }

        public static void Delete(int id)
        {
            var category = GetById(id);
            if (category != null) categoryList.Remove(category);
        }
    }
}