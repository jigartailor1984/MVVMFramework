using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFramework.Contract
{
    public interface IViewModel:INotifyPropertyChanged
    {
        string ViewModelName { get; }
    }
}
