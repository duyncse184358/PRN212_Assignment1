namespace NguyênChiDuyWPF.Models
{
   
    public class OrderDetailDisplayModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; } 
        public decimal Total => UnitPrice * Quantity * (1 - Discount);
    }
}