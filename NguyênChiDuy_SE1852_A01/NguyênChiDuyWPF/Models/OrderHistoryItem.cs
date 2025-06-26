using System;

namespace NguyênChiDuyWPF.Models
{
   
    public class OrderHistoryItem
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}