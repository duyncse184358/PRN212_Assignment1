using BusinessObjects.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;
using System; // For DateTime

namespace Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;

        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }

        public List<Order> GetOrders() => _repo.GetOrders();
        public Order? GetById(int id) => _repo.GetById(id);
        public void Add(Order order) => _repo.Add(order);
        public List<Order> GetByCustomer(int customerId) => _repo.GetByCustomer(customerId);
        public List<Order> GetByDateRange(DateTime from, DateTime to) => _repo.GetByDateRange(from, to);
    }
}