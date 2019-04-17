using Common.Commands;
using Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace FrameworkTestApp.ViewModel
{
    public class ErrorMessageVM : DialogViewModelBase
    {
        public string ErrorMessageText { get; set; }
        //public string Header { get; set; }

        public MessageBoxResult DialogResult { get; set; }

        private DelegateCommand okCommand;
        public ICommand OkCommand
        {
            get
            {
                if (okCommand == null)
                {
                    okCommand = new DelegateCommand(p => OnOkCommand(p));
                }
                return okCommand;
            }
        }

        private void OnOkCommand(object parameter)
        {
            DialogResult = MessageBoxResult.Cancel;
            EndDialog();
        }

        public ErrorMessageVM(ErrorVMArgs args)
        {
            ShowUI(args);
        }

        private void ShowUI(ErrorVMArgs args)
        {
            ErrorMessageText = args.ErrorMessage;
            if (string.IsNullOrEmpty(args.Header))
            {
                Header = "Error";//TranslationManager.Instance.Translate("ErrorMessageHeader").ToString();
            }
            else
            {
                Header = args.Header;
            }
        }

        private void OnCloseDialogEventExecute(object source, ErrorVMArgs args)
        {
            EndDialog();
        }
        /// <summary>
        /// This method will close the dialog window
        /// </summary>
        private void EndDialog()
        {

            var dispatcher = Application.Current.Dispatcher;
            if (dispatcher.CheckAccess())
            {
                CloseDialog();
            }
            else
            {
                dispatcher.Invoke(new Action(() =>
                {
                    CloseDialog();
                }));
            }

        }

    }

    public enum ErrorMessageMode
    {
        Close
    }
    public class ErrorVMArgs
    {
        public ErrorMessageMode UIMode { get; set; }
        public string ErrorMessage { get; set; }
        public string Header { get; set; }
        public ErrorVMArgs(ErrorMessageMode uiMode, string message, string header)
        {
            UIMode = uiMode;
            Header = header;
            ErrorMessage = message;
        }
    }
}
