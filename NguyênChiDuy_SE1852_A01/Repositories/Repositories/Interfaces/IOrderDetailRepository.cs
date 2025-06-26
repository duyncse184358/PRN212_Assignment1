
using BusinessObjects.Models;

namespace Repositories.Interfaces;

public interface IOrderDetailRepository
{
    List<OrderDetail> GetByOrderId(int orderId);
    void Add(OrderDetail detail);
    void DeleteByOrderId(int orderId);
}
