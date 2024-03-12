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

        public AppCommand(Action<object?> commandAction)
        {
            this.commandAction = commandAction;
        }

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter) => commandAction.Invoke(parameter);
    }
}
