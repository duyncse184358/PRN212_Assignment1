using System;

namespace BusinessObjects.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }

        public override string ToString() => $"Order #{OrderID} - {OrderDate:d}";
    }
}