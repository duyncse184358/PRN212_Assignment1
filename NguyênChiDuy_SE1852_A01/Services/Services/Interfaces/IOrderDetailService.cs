using BusinessObjects.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IOrderDetailService
    {
        List<OrderDetail> GetByOrderId(int orderId);
        void Add(OrderDetail detail);
        void DeleteByOrderId(int orderId);
    }
}