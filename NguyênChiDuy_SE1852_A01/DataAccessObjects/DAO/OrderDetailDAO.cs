using BusinessObjects.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects.DAO
{
    public class OrderDetailDAO
    {
        private static List<OrderDetail> detailList = new();

        
        static OrderDetailDAO()
        {
            detailList.Add(new OrderDetail { OrderID = 1, ProductID = 1, UnitPrice = 1500, Quantity = 1, Discount = 0.0f });
            detailList.Add(new OrderDetail { OrderID = 1, ProductID = 2, UnitPrice = 500, Quantity = 2, Discount = 0.1f });
            detailList.Add(new OrderDetail { OrderID = 2, ProductID = 3, UnitPrice = 20, Quantity = 5, Discount = 0.0f });
            detailList.Add(new OrderDetail { OrderID = 3, ProductID = 1, UnitPrice = 1500, Quantity = 1, Discount = 0.05f });
        }

        public static List<OrderDetail> GetByOrderId(int orderId) =>
            detailList.Where(d => d.OrderID == orderId).ToList();

        public static void Add(OrderDetail detail) => detailList.Add(detail);

        public static void DeleteByOrderId(int orderId)
        {
            detailList.RemoveAll(d => d.OrderID == orderId);
        }
    }
}