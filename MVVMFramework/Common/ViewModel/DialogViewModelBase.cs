using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Common.ViewModel
{
    public class DialogViewModelBase : IDialogViewModel, INotifyPropertyChanged
    {
        private string dialogTitle;
        public string Header
        {
            get
            {
                return dialogTitle;
            }
            set
            {
                dialogTitle = value;
                OnPropertyChanged(nameof(Header));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public event EventHandler RequestDialogClose;

        public void OnDialogWindowClosing(object sender, CancelEventArgs e)
        {

        }

        protected void RaiseRequestDialogClose()
        {
            var handler = RequestDialogClose;

            if (handler != null)
                handler(this, EventArgs.Empty);
        }

        public void CloseDialog()
        {
            RaiseRequestDialogClose();
        }

        public void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, args);
        }
    }
}
