namespace BusinessObjects.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty; // Admin, Staff, etc.

        public override string ToString() => $"{Name} ({JobTitle})";
    }
}