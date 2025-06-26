namespace BusinessObjects.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string ContactTitle { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public override string ToString() => $"{CompanyName} ({Phone})";
    }
}