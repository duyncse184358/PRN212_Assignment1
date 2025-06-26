namespace NguyênChiDuyWPF.Models
{
    // Lớp này dùng để hiển thị chi tiết đơn hàng trong DataGrid của OrderWindow
    // Nó là một View-only model, không phải BusinessObject
    public class OrderDetailDisplayModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; } // Giữ là decimal để nhất quán
        public decimal Total => UnitPrice * Quantity * (1 - Discount);
    }
}