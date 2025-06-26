using BusinessObjects.Models;
using System.Collections.Generic;
using System.Linq;
using System; // For StringComparison

namespace DataAccessObjects.DAO
{
    public class EmployeeDAO
    {
        private static List<Employee> employeeList = new();

        // Static constructor để tạo dữ liệu mẫu
        static EmployeeDAO()
        {
            employeeList.Add(new Employee { EmployeeID = 1, Name = "Admin User", UserName = "admin", Password = "admin123", JobTitle = "Admin" });
            employeeList.Add(new Employee { EmployeeID = 2, Name = "Staff A", UserName = "staffA", Password = "staff123", JobTitle = "Staff" });
            employeeList.Add(new Employee { EmployeeID = 3, Name = "Manager B", UserName = "managerB", Password = "manager123", JobTitle = "Manager" });
        }

        public static List<Employee> GetAll() => employeeList;

        public static Employee? GetById(int id) =>
            employeeList.FirstOrDefault(e => e.EmployeeID == id);

        public static Employee? GetByUsername(string username) =>
            employeeList.FirstOrDefault(e => e.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));

        public static void Add(Employee employee)
        {
            employee.EmployeeID = employeeList.Any() ? employeeList.Max(e => e.EmployeeID) + 1 : 1;
            employeeList.Add(employee);
        }

        public static void Update(Employee employee)
        {
            var existing = GetById(employee.EmployeeID);
            if (existing != null)
            {
                existing.Name = employee.Name;
                existing.UserName = employee.UserName;
                existing.Password = employee.Password;
                existing.JobTitle = employee.JobTitle;
            }
        }

        public static void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null) employeeList.Remove(employee);
        }

        public static bool ValidateLogin(string username, string password) =>
            employeeList.Any(e => e.UserName == username && e.Password == password);
    }
}