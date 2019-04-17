using Common.Events;
using Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Common.Interactions
{
    /// <summary>
    /// Interaction Request object that allows ViewModels to expose a logical interaction without coupling to a view.
    /// </summary>
    /// <typeparam name="T">Type of ViewModel that is part of the interaction request, must meet IDialogViewModel interface.</typeparam>
    public class InteractionRequest<T> where T : IDialogViewModel
    {
        /// <summary>
        ///     Fired when interaction is needed.
        /// </summary>
        public event EventHandler<InteractionRequestedEventArgs> Raised;

        private Action<T> _action;

        private T _context;

        /// <summary>
        ///     Fires the Raised event without a callback.
        /// </summary>
        /// <param name="context">The context for the interaction request.</param>
        /// <param name="dlgWidth">Dialog Width</param>
        /// <param name="dlgHeight">Dialog Height</param>
        [SuppressMessage(@"Microsoft.Design", @"CA1030:UseEventsWhereAppropriate")]
        public void Raise(T context, double dlgWidth, double dlgHeight)
        {
            Raise(context, c => { }, dlgWidth, dlgHeight);
        }

        /// <summary>
        ///     Fires the Raised event with a callback on completion.
        /// </summary>
        /// <param name="context">The context for the interaction request.</param>
        /// <param name="callback">The callback to execute when the interaction is completed.</param>
        /// <param name="dlgWidth">Dialog Width</param>
        /// <param name="dlgHeight">Dialog Height</param>
        [SuppressMessage(@"Microsoft.Design", @"CA1030:UseEventsWhereAppropriate")]
        public void Raise(T context, Action<T> callback, double dlgWidth, double dlgHeight)
        {
            var handler = Raised;

            if (handler != null)
            {
                _context = context;
                _action = callback;
                handler(this, new InteractionRequestedEventArgs(context, CallBackAction, dlgWidth, dlgHeight));
            }
        }

        private void CallBackAction()
        {
            _action(_context);
        }
    }
}
