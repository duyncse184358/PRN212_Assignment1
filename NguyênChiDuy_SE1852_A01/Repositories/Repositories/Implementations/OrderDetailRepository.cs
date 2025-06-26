using BusinessObjects.Models;
using DataAccessObjects.DAO;
using Repositories.Interfaces;
using System.Collections.Generic;

namespace Repositories.Implementations
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetail> GetByOrderId(int orderId) => OrderDetailDAO.GetByOrderId(orderId);
        public void Add(OrderDetail detail) => OrderDetailDAO.Add(detail);
        public void DeleteByOrderId(int orderId) => OrderDetailDAO.DeleteByOrderId(orderId);
    }
}