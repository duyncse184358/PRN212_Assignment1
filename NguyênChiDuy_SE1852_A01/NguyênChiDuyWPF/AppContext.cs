namespace NguyênChiDuyWPF
{
    /// <summary>
    /// Lưu trạng thái đăng nhập hiện tại (user name, role, customer ID).
    /// Sử dụng toàn cục (static) trong WPF app.
    /// </summary>
    public static class AppContext
    {
        /// <summary>
        /// Tên người dùng hiện tại (admin username hoặc số điện thoại khách hàng)
        /// </summary>
        public static string CurrentUserName { get; set; } = "";

        /// <summary>
        /// Vai trò người dùng hiện tại: "Admin" hoặc "Customer"
        /// </summary>
        public static string CurrentRole { get; set; } = "";

        /// <summary>
        /// Mã khách hàng (chỉ dùng nếu là Customer)
        /// </summary>
        public static int CurrentCustomerID { get; set; } = 0;

        /// <summary>
        /// Kiểm tra người dùng hiện tại là Admin
        /// </summary>
        public static bool IsAdmin => CurrentRole.Equals("Admin", System.StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Kiểm tra người dùng hiện tại là Customer
        /// </summary>
        public static bool IsCustomer => CurrentRole.Equals("Customer", System.StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Xoá toàn bộ thông tin người dùng (khi đăng xuất)
        /// </summary>
        public static void Reset()
        {
            CurrentUserName = string.Empty;
            CurrentRole = string.Empty;
            CurrentCustomerID = 0;
        }
    }
}