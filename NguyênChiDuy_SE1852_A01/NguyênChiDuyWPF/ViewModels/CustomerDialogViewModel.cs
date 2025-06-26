using BusinessObjects.Models;

namespace NguyênChiDuyWPF.ViewModels
{
    public class CustomerDialogViewModel : BaseViewModel
    {
        public Customer Customer { get; set; }

        public CustomerDialogViewModel()
        {
            Customer = new Customer();
        }

        public CustomerDialogViewModel(Customer original)
        {
           
            Customer = new Customer
            {
                CustomerID = original.CustomerID,
                CompanyName = original.CompanyName,
                ContactName = original.ContactName,
                ContactTitle = original.ContactTitle,
                Address = original.Address,
                Phone = original.Phone
            };
        }
    }
}