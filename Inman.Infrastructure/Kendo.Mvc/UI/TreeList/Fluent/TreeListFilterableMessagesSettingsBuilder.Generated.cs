using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListFilterableMessagesSettings
    /// </summary>
    public partial class TreeListFilterableMessagesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The text of the option which represents the "and" logical operation.
        /// </summary>
        /// <param name="value">The value for And</param>
        public TreeListFilterableMessagesSettingsBuilder<T> And(string value)
        {
            Container.And = value;
            return this;
        }

        /// <summary>
        /// The text of the button which clears the filter.
        /// </summary>
        /// <param name="value">The value for Clear</param>
        public TreeListFilterableMessagesSettingsBuilder<T> Clear(string value)
        {
            Container.Clear = value;
            return this;
        }

        /// <summary>
        /// The text of the button which applies the filter.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public TreeListFilterableMessagesSettingsBuilder<T> Filter(string value)
        {
            Container.Filter = value;
            return this;
        }

        /// <summary>
        /// The text of the information message on the top of the filter menu.
        /// </summary>
        /// <param name="value">The value for Info</param>
        public TreeListFilterableMessagesSettingsBuilder<T> Info(string value)
        {
            Container.Info = value;
            return this;
        }

        /// <summary>
        /// The text of the radio button for false values. Displayed when filtering Boolean fields.
        /// </summary>
        /// <param name="value">The value for IsFalse</param>
        public TreeListFilterableMessagesSettingsBuilder<T> IsFalse(string value)
        {
            Container.IsFalse = value;
            return this;
        }

        /// <summary>
        /// The text of the radio button for true values. Displayed when filtering Boolean fields.
        /// </summary>
        /// <param name="value">The value for IsTrue</param>
        public TreeListFilterableMessagesSettingsBuilder<T> IsTrue(string value)
        {
            Container.IsTrue = value;
            return this;
        }

        /// <summary>
        /// The text of the option which represents the "or" logical operation.
        /// </summary>
        /// <param name="value">The value for Or</param>
        public TreeListFilterableMessagesSettingsBuilder<T> Or(string value)
        {
            Container.Or = value;
            return this;
        }

        /// <summary>
        /// The text of the DropDownList displayed in the filter menu for columns whose values option is set.
        /// </summary>
        /// <param name="value">The value for SelectValue</param>
        public TreeListFilterableMessagesSettingsBuilder<T> SelectValue(string value)
        {
            Container.SelectValue = value;
            return this;
        }

        /// <summary>
        /// The text of the cancel button in the filter menu header (available in mobile mode only).
        /// </summary>
        /// <param name="value">The value for Cancel</param>
        public TreeListFilterableMessagesSettingsBuilder<T> Cancel(string value)
        {
            Container.Cancel = value;
            return this;
        }

        /// <summary>
        /// The text of the operator item in filter menu (available in mobile mode only).
        /// </summary>
        /// <param name="value">The value for Operator</param>
        public TreeListFilterableMessagesSettingsBuilder<T> Operator(string value)
        {
            Container.Operator = value;
            return this;
        }

    }
}
