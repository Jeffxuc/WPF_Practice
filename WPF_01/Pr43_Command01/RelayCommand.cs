using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pr43_Command01
{
    class RelayCommand : ICommand
    {
        Action<Object> _execteMethod;
        Func<object, bool> _canExecuteMethod;

        public RelayCommand(Action<Object> executeMethod, Func<Object,bool> canExecuteMethod)
        {
            _canExecuteMethod = canExecuteMethod;
            _execteMethod = executeMethod;

        }



        #region Implement of ICommand interface.
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            // Check if _canExecuteMethod is initialized or not?
            if (_canExecuteMethod == null)
                return false;
            else
                return true;
        }

        public void Execute(object parameter)
        {
            _execteMethod(parameter);
        }

        #endregion


    }
}
