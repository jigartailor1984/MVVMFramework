// ***********************************************************************
// Assembly         : MVVMFramework
// Author           : Jigar Tailor
// Created          : 02-20-2015
//
// Last Modified By : Jigar Tailor
// Last Modified On : 02-20-2015
// ***********************************************************************
// <copyright file="RelayCommand.cs" company="Jigar">
//     Copyright © Jigar 2015
// </copyright>
// <summary>File Contains Common function and implementation of ICommand</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

/// <summary>
/// The Generic namespace.
/// </summary>
namespace MVVMFramework.Generic
{
    /// <summary>
    /// Class RelayCommand implements ICommand interface to user to command using Viewmodel.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    
    public class RelayCommand<T>
    {
        /// <summary>
        /// The _action
        /// </summary>
        private Action<T> _action;

        /// <summary>
        /// The _can execute
        /// </summary>
        private Predicate<T> _canExecute;
        public RelayCommand()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand{T}"/> class.
        /// </summary>
        /// <param name="action">The action.</param>
        public RelayCommand(Action<T> action)
        {
            _action = action;
            _canExecute = new Predicate<T>((parameter) => { return true; });
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand{T}"/> class.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="canExecute">The can execute.</param>
        public RelayCommand(Action<T> action, Predicate<T> canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>true if this command can be executed; otherwise, false.</returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute((T)parameter);
        }

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command.  If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            _action((T)parameter);
        }

        
    }
}
