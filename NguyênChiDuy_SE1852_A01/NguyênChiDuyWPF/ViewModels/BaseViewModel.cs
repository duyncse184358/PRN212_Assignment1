using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NguyênChiDuyWPF.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Gọi hàm này mỗi khi bạn muốn thông báo UI là thuộc tính đã thay đổi
        /// </summary>
        /// <param name="propertyName">Tên thuộc tính (mặc định tự động)</param>
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Dùng cho các property có backing field (hạn chế lặp code)
        /// </summary>
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}