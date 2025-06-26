using System;

namespace NguyênChiDuyWPF.Models
{
    // Lớp này dùng để hiển thị các mục lịch sử đơn hàng trong DataGrid
    // Nó là một View-only model, không phải BusinessObject
    public class OrderHistoryItem
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}