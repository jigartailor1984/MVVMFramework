using Common.Events;
using Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Interactivity;

namespace Common.Triggers
{
    public class DialogTrigger : TriggerAction<FrameworkElement>
    {
        #region Constants

        private const string DIALOG_CONTENT_TEMPLATE_PROPERTY_NAME = @"DialogContentTemplate";
        private const string IS_MODAL_PROPERTY_NAME = @"IsModal";
        private const string DIALOG_WINDOW_STYLE_PROPERTY_NAME = @"DialogWindowStyle";
        private const string DIALOG_WINDOW_NAME_PROPERTY_NAME = @"DialogWindowOwner";

        #endregion

        #region Dependency Properties

        public static readonly DependencyProperty DialogContentTemplateProperty =
            DependencyProperty.Register(DIALOG_CONTENT_TEMPLATE_PROPERTY_NAME, typeof(DataTemplate), typeof(DialogTrigger),
                                        new PropertyMetadata(default(DataTemplate)));

        public static readonly DependencyProperty IsModalProperty =
            DependencyProperty.Register(IS_MODAL_PROPERTY_NAME, typeof(bool), typeof(DialogTrigger), new PropertyMetadata(default(bool)));

        public static readonly DependencyProperty DialogWindowStyleProperty =
            DependencyProperty.Register(DIALOG_WINDOW_STYLE_PROPERTY_NAME, typeof(Style), typeof(DialogTrigger), new PropertyMetadata(default(Style)));

        public static readonly DependencyProperty DialogWindowOwnerProperty =
            DependencyProperty.Register(DIALOG_WINDOW_NAME_PROPERTY_NAME, typeof(Window), typeof(DialogTrigger), new PropertyMetadata(null));

        public static readonly DependencyProperty IsBindedWithOwnerProperty =
            DependencyProperty.Register("IsBindedWithOwner", typeof(bool), typeof(DialogTrigger), new PropertyMetadata(true));



        #endregion

        #region Fields

        private Action completeCallback;
        private Window dialog;
        private IDialogViewModel dialogViewModel;

        #endregion

        #region Properties


        /// <summary>
        /// Property Determines whether to bind popup with owner or not
        /// </summary>
        public bool IsBindedWithOwner
        {
            get { return (bool)GetValue(IsBindedWithOwnerProperty); }
            set { SetValue(IsBindedWithOwnerProperty, value); }
        }

        /// <summary>
        /// Owner of the dialog window.
        /// </summary>
        public Window DialogWindowOwner
        {
            get { return (Window)GetValue(DialogWindowOwnerProperty); }
            set { SetValue(DialogWindowOwnerProperty, value); }
        }

        /// <summary>
        /// Style for the dialog window
        /// </summary>
        public Style DialogWindowStyle
        {
            get { return (Style)GetValue(DialogWindowStyleProperty); }
            set { SetValue(DialogWindowStyleProperty, value); }
        }

        /// <summary>
        ///     Gets or sets the content template for a default child window.
        /// </summary>
        public DataTemplate DialogContentTemplate
        {
            get { return (DataTemplate)GetValue(DialogContentTemplateProperty); }
            set { SetValue(DialogContentTemplateProperty, value); }
        }

        /// <summary>
        /// Boolean property indicating whether the dialog should be modally invoked.
        /// </summary>
        public bool IsModal
        {
            get { return (bool)GetValue(IsModalProperty); }
            set { SetValue(IsModalProperty, value); }
        }

        public IDialogViewModel ViewModel
        {
            get { return dialogViewModel; }
        }

        #endregion

        #region Methods

        protected override void Invoke(object parameter)
        {
            var args = parameter as InteractionRequestedEventArgs;

            if (args == null)
            {
                return;
            }

            dialogViewModel = args.Context;
            completeCallback = args.Callback;

            CreateDefaultDialog(args);
            if (IsModal)
            {
                dialog.ShowDialog();
            }
            else
            {
                dialog.Show();

                dialog.Activate();

            }
        }

        private void CreateDefaultDialog(InteractionRequestedEventArgs args)
        {
            dialog = new Window
            {

                Style = DialogWindowStyle,
                Content = dialogViewModel,
                Title=dialogViewModel.Header??string.Empty,
                ContentTemplate = DialogContentTemplate,
                ShowInTaskbar = false,
                Width = args.DlgWidth,
                Height = args.DlgHeight
            };
            if (IsBindedWithOwner)
            {
                dialog.Owner = DialogWindowOwner;
                dialog.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            }
            else
            {
                dialog.Owner = null;
                dialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                dialog.Topmost = true;
            }

            dialog.ShowActivated = true;
            dialog.Closing += dialogViewModel.OnDialogWindowClosing;
            dialog.Closed += OnDialogClosed;
            dialog.Deactivated += dialog_Deactivated;

            dialogViewModel.RequestDialogClose += OnRequestDialogClosedRaised;
        }

        void dialog_Deactivated(object sender, EventArgs e)
        {
            dialog.Topmost = true;
            dialog.Activate();
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();

            if (dialog != null)
            {
                dialog.Closing -= dialogViewModel.OnDialogWindowClosing;
                dialog.Closed -= OnDialogClosed;
                dialog.Deactivated -= dialog_Deactivated;
            }

            if (dialogViewModel != null)
            {
                dialogViewModel.RequestDialogClose -= OnRequestDialogClosedRaised;
            }

            completeCallback = null;
            dialog = null;
            dialogViewModel = null;
        }

        private void OnDialogClosed(object sender, EventArgs e)
        {
            if (completeCallback != null)
            {
                completeCallback();
            }
        }

        private void OnRequestDialogClosedRaised(object sender, EventArgs e)
        {
            dialog.Closing -= dialogViewModel.OnDialogWindowClosing;
            dialog.Close();
        }

        #endregion Methods
    }
}
