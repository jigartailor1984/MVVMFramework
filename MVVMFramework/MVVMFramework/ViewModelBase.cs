// ***********************************************************************
// Assembly         : MVVMFramework
// Author           : Jigar Tailor
// Created          : 02-20-2015
//
// Last Modified By : Jigar Tailor
// Last Modified On : 02-20-2015
// ***********************************************************************
// <copyright file="ViewModelBase.cs" company="Jigar">
//     Copyright © Jigar 2015
// </copyright>
// <summary>File Contains Common function and implementation of INotifyPropertyChanged</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMFramework
{
    /// <summary>
    /// Implementation of INotifyPropertyChanged to create View Model
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Property setter to set property in view model.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage">Reference of storage field to update value.</param>
        /// <param name="value">Value that will be updated on storage.</param>
        /// <param name="propertyName">Name of the property which calls the method.</param>
        /// <returns></returns>
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value))
                return false;
            storage = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Raise the property changed event.
        /// </summary>
        /// <param name="propertyName">Name of the property for which property changed event is raised.</param>
        private void OnPropertyChanged(string propertyName)
        {
            var eventHandler = this.PropertyChanged; 
            if (eventHandler != null) 
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Implementation of property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Abstract property to get name of view model that every view model will override.
        /// </summary>
        public abstract string ViewModelName
        {
            get;
        }
    }
}
