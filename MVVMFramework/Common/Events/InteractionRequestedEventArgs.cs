using Common.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Events
{
    public class InteractionRequestedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see cref="InteractionRequestedEventArgs" />
        /// </summary>
        /// <param name="context">context of the request</param>
        /// <param name="callback">callback for when the request is complete</param>/// 
        /// <param name="dlgWidth">Dialog Width</param>
        /// <param name="dlgHeight">Dialog Height</param>
        public InteractionRequestedEventArgs(IDialogViewModel context, Action callback, double dlgWidth, double dlgHeight,params object[] param)
        {
            Context = context;
            Callback = callback;
            DlgWidth = dlgWidth;
            DlgHeight = dlgHeight;
        }

        /// <summary>
        ///     Gets the context for a requested interaction.
        /// </summary>
        public IDialogViewModel Context { get; private set; }

        /// <summary>
        ///     Gets the callback to execute when an interaction is completed.
        /// </summary>
        public Action Callback { get; private set; }

        /// <summary>
        /// Dialog Width
        /// </summary>
        public double DlgWidth { get; set; }

        /// <summary>
        /// Dialog Height
        /// </summary>
        public double DlgHeight { get; set; }
    }
}
