using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pr64_MVVM_ExampleSong_Cmd
{
    class RelayCommand : ICommand
    {
        #region define two members.
        private readonly Func<bool> _canExecute;
        private readonly Action _execute;
        #endregion


        #region The RelayCommand Constructor.
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
                return;
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action execute) : this(execute, null)
        {

        }
        #endregion



        #region Implement the ICommand interface.
        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (_canExecute != null)
                    CommandManager.RequerySuggested -= value;
            }
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
        #endregion
    }
}
