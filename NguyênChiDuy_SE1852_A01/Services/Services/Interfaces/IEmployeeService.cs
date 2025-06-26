using BusinessObjects.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee? GetById(int id);
        Employee? GetByUsername(string username);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        bool ValidateLogin(string username, string password);
    }
}