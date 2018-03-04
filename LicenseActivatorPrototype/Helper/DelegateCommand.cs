using System;
using System.Windows.Input;

namespace LicenseActivatorPrototype.Helper
{
    public abstract class BaseDelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }

    public class DelegateCommand : BaseDelegateCommand
    {
        private Action _executeAction;
        public DelegateCommand(Action executeAction)
        {
            _executeAction = executeAction;
        }

        public override void Execute(object parameter)
        {
            _executeAction?.Invoke();
        }
    }
    public class DelegateCommand<T> : BaseDelegateCommand
    {
        private Action<T> _executeActionT;

        public DelegateCommand(Action<T> executeAction)
        {
            _executeActionT = executeAction;
        }

        public override void Execute(object parameter)
        {
            _executeActionT?.Invoke((T)Convert.ChangeType(parameter, typeof(T)));
        }
    }
}