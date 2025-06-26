using BusinessObjects.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        Customer? GetById(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        List<Customer> Search(string keyword);
    }
}