using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Common.ViewModel
{
    public interface IDialogViewModel
    {
        event EventHandler RequestDialogClose;

        string Header { get; set; }

        void OnDialogWindowClosing(object sender, CancelEventArgs e);

        void CloseDialog();
    }
}
