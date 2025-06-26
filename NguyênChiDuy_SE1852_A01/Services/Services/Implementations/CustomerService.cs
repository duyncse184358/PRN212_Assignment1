using BusinessObjects.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public List<Customer> GetCustomers() => _repo.GetCustomers();
        public Customer? GetById(int id) => _repo.GetById(id);
        public void Add(Customer customer) => _repo.Add(customer);
        public void Update(Customer customer) => _repo.Update(customer);
        public void Delete(int id) => _repo.Delete(id);
        public List<Customer> Search(string keyword) => _repo.Search(keyword);
    }
}