using System;
using System.Collections.Generic;
using System.Text;

namespace ProcentAppXamarin.MVVM
{
    public interface ICommand
    {
        void Execute(object arg);
        bool CanExecute(object arg);
        event EventHandler CanExecuteChanged;
    }
}
