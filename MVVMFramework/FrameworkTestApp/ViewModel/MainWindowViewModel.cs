using Common.Commands;
using Common.Interactions;
using Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace FrameworkTestApp.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public InteractionRequest<DialogViewModelBase> ModelessDlgInteractionRequest { get; private set; }
        private bool isBindedWithOwner = true;
        public bool IsBindedWithOwner
        {
            get { return isBindedWithOwner; }
            set
            {
                isBindedWithOwner = value;
                OnPropertyChanged("IsBindedWithOwner");
            }
        }

        public ICommand ShowErrorCommand
        {
            get
            {
                return new DelegateCommand(ShowError);
            }
        }

        public MainWindowViewModel()
        {
            ModelessDlgInteractionRequest = new InteractionRequest<DialogViewModelBase>();
        }
        private void ShowError(object obj)
        {
            LaunchModelessDialog(new ErrorMessageVM(new ErrorVMArgs(ErrorMessageMode.Close, "Error occured while closing", "Error")), CallBack, dlgWidth: 400, dlgHeight: 200);
        }

        private void CallBack(DialogViewModelBase obj)
        {
            ErrorMessageVM vm = (ErrorMessageVM)obj;

        }

        /// <summary>
        /// Launches the modeless Alert Dialog on screen.
        /// </summary>
        /// <param name="vm">viewmodel for the Alert Dialog</param>
        /// <param name="callBack">callback is called when the dialog is closed</param>
        /// <param name="dlgWidth">Dialog Width</param>
        /// <param name="dlgHeight">Dialog Height</param>
        public void LaunchModelessDialog(DialogViewModelBase vm, Action<DialogViewModelBase> callBack = null, double dlgWidth = 500, double dlgHeight = 200, bool isBindedWithOwner = true)
        {
            if (ModelessDlgInteractionRequest != null && vm != null)
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    ModelessDlgInteractionRequest.Raise(vm, callBack, dlgWidth, dlgHeight);
                    this.IsBindedWithOwner = isBindedWithOwner;
                }));
            }
        }
    }
}
