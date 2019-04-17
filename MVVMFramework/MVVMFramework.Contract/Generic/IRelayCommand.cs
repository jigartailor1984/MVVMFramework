using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMFramework.Contract.Generic
{
    public interface IRelayCommand<T>:ICommand
    {

        string CommandName { get; }
        void Command(Action<T> action);

        void Command(Action<T> action, Predicate<T> canExecute);
    }
}
