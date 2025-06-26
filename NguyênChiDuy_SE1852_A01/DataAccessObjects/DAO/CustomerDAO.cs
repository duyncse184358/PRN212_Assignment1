using BusinessObjects.Models;
using System.Collections.Generic;
using System.Linq;
using System; 

namespace DataAccessObjects.DAO
{
    public class CustomerDAO
    {
        private static List<Customer> customerList = new();

      
        static CustomerDAO()
        {
            customerList.Add(new Customer
            {
                CustomerID = 1,
                CompanyName = "FPT Corporation",
                ContactName = "Nguyen Van An",
                ContactTitle = "CEO",
                Address = "123 Cau Giay, Ha Noi",
                Phone = "0987654321"
            });
            customerList.Add(new Customer
            {
                CustomerID = 2,
                CompanyName = "Viettel Group",
                ContactName = "Tran Thi Binh",
                ContactTitle = "Manager",
                Address = "456 Hoang Mai, Ha Noi",
                Phone = "0912345678"
            });
            customerList.Add(new Customer
            {
                CustomerID = 3,
                CompanyName = "Mobifone",
                ContactName = "Le Van Cuong",
                ContactTitle = "Staff",
                Address = "789 Le Duan, HCM",
                Phone = "0901234567"
            });
        }

        public static List<Customer> GetAll() => customerList;

        public static Customer? GetById(int id) =>
            customerList.FirstOrDefault(c => c.CustomerID == id);

        public static void Add(Customer customer)
        {
            customer.CustomerID = customerList.Any() ? customerList.Max(c => c.CustomerID) + 1 : 1;
            customerList.Add(customer);
        }

        public static void Update(Customer customer)
        {
            var existing = GetById(customer.CustomerID);
            if (existing != null)
            {
                existing.CompanyName = customer.CompanyName;
                existing.ContactName = customer.ContactName;
                existing.ContactTitle = customer.ContactTitle;
                existing.Address = customer.Address;
                existing.Phone = customer.Phone;
            }
        }

        public static void Delete(int id)
        {
            var customer = GetById(id);
            if (customer != null) customerList.Remove(customer);
        }

        public static List<Customer> Search(string keyword) =>
            customerList.Where(c => c.CompanyName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                    c.ContactName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                    c.Phone.Contains(keyword)).ToList();
    }
}