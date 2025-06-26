using System;
using System.Windows.Input;

namespace NguyênChiDuyWPF.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _execute; // Sử dụng Action<object?> để linh hoạt hơn
        private readonly Func<object?, bool>? _canExecute; // Sử dụng Func<object?, bool>

        public RelayCommand(Action execute, Func<bool>? canExecute = null)
            : this(p => execute(), p => canExecute?.Invoke() ?? true) { }

        public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter) => _canExecute?.Invoke(parameter) ?? true;

        public void Execute(object? parameter) => _execute(parameter);

        // Phương thức này có thể được gọi từ ViewModel để buộc cập nhật trạng thái CanExecute
        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}