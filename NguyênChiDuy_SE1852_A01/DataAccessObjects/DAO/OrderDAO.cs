using BusinessObjects.Models;
using System.Collections.Generic;
using System.Linq;
using System; // For DateTime

namespace DataAccessObjects.DAO
{
    public class OrderDAO
    {
        private static List<Order> orderList = new();

        
        static OrderDAO()
        {
            orderList.Add(new Order { OrderID = 1, CustomerID = 1, EmployeeID = 1, OrderDate = DateTime.Now.AddDays(-10) });
            orderList.Add(new Order { OrderID = 2, CustomerID = 2, EmployeeID = 2, OrderDate = DateTime.Now.AddDays(-5) });
            orderList.Add(new Order { OrderID = 3, CustomerID = 1, EmployeeID = 1, OrderDate = DateTime.Now.AddDays(-2) });
        }

        public static List<Order> GetAll() => orderList;

        public static Order? GetById(int id) =>
            orderList.FirstOrDefault(o => o.OrderID == id);

        public static void Add(Order order)
        {
            order.OrderID = orderList.Any() ? orderList.Max(o => o.OrderID) + 1 : 1;
            orderList.Add(order);
        }

        public static List<Order> GetByCustomer(int customerId) =>
            orderList.Where(o => o.CustomerID == customerId).ToList();

        public static List<Order> GetByDateRange(DateTime from, DateTime to) =>
            orderList.Where(o => o.OrderDate.Date >= from.Date && o.OrderDate.Date <= to.Date)
                     .OrderByDescending(o => o.OrderDate).ToList();
    }
}