using BusinessObjects.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services.Implementations
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _repo;

        public OrderDetailService(IOrderDetailRepository repo)
        {
            _repo = repo;
        }

        public List<OrderDetail> GetByOrderId(int orderId) => _repo.GetByOrderId(orderId);
        public void Add(OrderDetail detail) => _repo.Add(detail);
        public void DeleteByOrderId(int orderId) => _repo.DeleteByOrderId(orderId);
    }
}