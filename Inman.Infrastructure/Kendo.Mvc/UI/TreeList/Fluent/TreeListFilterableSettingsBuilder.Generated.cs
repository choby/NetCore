using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListFilterableSettings
    /// </summary>
    public partial class TreeListFilterableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true the filter menu allows the user to input a second criteria.
        /// </summary>
        /// <param name="value">The value for Extra</param>
        public TreeListFilterableSettingsBuilder<T> Extra(bool value)
        {
            Container.Extra = value;
            return this;
        }

        /// <summary>
        /// The text messages displayed in the filter menu. Use it to customize or localize the filter menu messages.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public TreeListFilterableSettingsBuilder<T> Messages(Action<TreeListFilterableMessagesSettingsBuilder<T>> configurator)
        {

            Container.Messages.TreeList = Container.TreeList;
            configurator(new TreeListFilterableMessagesSettingsBuilder<T>(Container.Messages));

            return this;
        }

    }
}
