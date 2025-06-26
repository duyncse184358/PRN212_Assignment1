using BusinessObjects.Models;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        Customer? GetById(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        List<Customer> Search(string keyword);
    }
}