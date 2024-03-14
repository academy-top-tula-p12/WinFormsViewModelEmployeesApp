using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsViewModelEmployeesApp
{
    class AppCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        Action<object?> commandAction;
        Predicate<object?>? predicate;

        public AppCommand(Action<object?> commandAction, Predicate<object?>? predicate = null)
        {
            this.commandAction = commandAction;
            this.predicate = predicate;
        }

        public bool CanExecute(object? parameter)
        {
            if (predicate != null)
                return predicate.Invoke(parameter);
            else
                return true;
        }

        public void Execute(object? parameter) => commandAction.Invoke(parameter);
    }
}
