using Repositories.Implementations;
using Repositories.Interfaces;
using Services.Implementations;
using Services.Interfaces;

namespace Services.Helpers
{
    public static class SingletonHelper
    {
        public static readonly ICategoryService CategoryService =
            new CategoryService(new CategoryRepository());

        public static readonly ICustomerService CustomerService =
            new CustomerService(new CustomerRepository());

        public static readonly IEmployeeService EmployeeService =
            new EmployeeService(new EmployeeRepository());

        public static readonly IOrderService OrderService =
            new OrderService(new OrderRepository());

        public static readonly IOrderDetailService OrderDetailService =
            new OrderDetailService(new OrderDetailRepository());

        public static readonly IProductService ProductService =
            new ProductService(new ProductRepository());
    }
}