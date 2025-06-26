using BusinessObjects.Models;

namespace NguyênChiDuyWPF.ViewModels
{
    public class CategoryDialogViewModel : BaseViewModel
    {
        public Category Category { get; set; }

        public CategoryDialogViewModel()
        {
            Category = new Category();
        }

        public CategoryDialogViewModel(Category original)
        {
          
            Category = new Category
            {
                CategoryID = original.CategoryID,
                CategoryName = original.CategoryName,
                Description = original.Description
            };
        }
    }
}