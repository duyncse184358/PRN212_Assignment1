using BusinessObjects.Models;
using System.Collections.Generic;
using System; // For DateTime

namespace Repositories.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order? GetById(int id);
        void Add(Order order);
        List<Order> GetByCustomer(int customerId);
        List<Order> GetByDateRange(DateTime from, DateTime to);
    }
}