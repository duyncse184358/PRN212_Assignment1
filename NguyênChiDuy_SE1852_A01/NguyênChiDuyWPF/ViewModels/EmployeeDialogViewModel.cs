using BusinessObjects.Models;

namespace NguyênChiDuyWPF.ViewModels
{
    public class EmployeeDialogViewModel : BaseViewModel
    {
        public Employee Employee { get; set; }

        public EmployeeDialogViewModel()
        {
            Employee = new Employee();
        }

        public EmployeeDialogViewModel(Employee original)
        {
            // Tạo một bản sao để tránh chỉnh sửa trực tiếp đối tượng gốc
            Employee = new Employee
            {
                EmployeeID = original.EmployeeID,
                Name = original.Name,
                UserName = original.UserName,
                Password = original.Password,
                JobTitle = original.JobTitle
            };
        }
    }
}