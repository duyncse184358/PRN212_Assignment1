using BusinessObjects.Models;
using DataAccessObjects.DAO;
using Repositories.Interfaces;
using System.Collections.Generic;

namespace Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees() => EmployeeDAO.GetAll();
        public Employee? GetById(int id) => EmployeeDAO.GetById(id);
        public Employee? GetByUsername(string username) => EmployeeDAO.GetByUsername(username);
        public void Add(Employee employee) => EmployeeDAO.Add(employee);
        public void Update(Employee employee) => EmployeeDAO.Update(employee);
        public void Delete(int id) => EmployeeDAO.Delete(id);
        public bool ValidateLogin(string username, string password) => EmployeeDAO.ValidateLogin(username, password);
    }
}