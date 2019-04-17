using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using EventTrigger = System.Windows.Interactivity.EventTrigger;


namespace Common.Triggers
{
    public class InteractionRequestTrigger : EventTrigger
    {
        #region Constants

        private const string TRIGGER_EVENT_NAME = @"Raised";

        #endregion

        #region Fields

        private DependencyObject _parent;

        #endregion

        #region Methods

        protected override void OnAttached()
        {
            base.OnAttached();

            _parent = AssociatedObject;

            var frameworkElement = AssociatedObject as FrameworkElement;

            if (frameworkElement != null)
                frameworkElement.Unloaded += OnParentWindowClose;
        }

        private void OnParentWindowLoaded(object parentWindow, RoutedEventArgs e)
        {
            var element = _parent as FrameworkElement;

            if (element != null)
                element.Loaded -= OnParentWindowLoaded;

            Attach(_parent);
        }

        private void OnParentWindowClose(object parentWindow, RoutedEventArgs e)
        {
            var frameworkElement = AssociatedObject as FrameworkElement;

            if (frameworkElement != null)
            {
                frameworkElement.Unloaded -= OnParentWindowClose;
                frameworkElement.Loaded += OnParentWindowLoaded;
            }

            Detach();
        }

        protected override string GetEventName()
        {
            return TRIGGER_EVENT_NAME;
        }

        #endregion
    }
}
