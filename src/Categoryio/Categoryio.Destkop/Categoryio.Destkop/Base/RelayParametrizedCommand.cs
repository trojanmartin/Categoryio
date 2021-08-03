using System;
using System.Windows.Input;

namespace Categoryio.Destkop.Base
{
    public class RelayParametrizedCommand<T> : ICommand
    {
        private Action<T> _action;

        public RelayParametrizedCommand(Action<T> action)
        {
            _action = action;
        }

        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action((T)parameter);
        }
    }
}
