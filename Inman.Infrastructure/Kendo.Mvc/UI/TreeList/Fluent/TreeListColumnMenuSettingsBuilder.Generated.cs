using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnMenuSettings
    /// </summary>
    public partial class TreeListColumnMenuSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true the column menu would allow the user to select (show and hide) treelist columns. By default the column menu allows column selection.
        /// </summary>
        /// <param name="value">The value for Columns</param>
        public TreeListColumnMenuSettingsBuilder<T> Columns(bool value)
        {
            Container.Columns = value;
            return this;
        }

        /// <summary>
        /// If set to true the column menu would allow the user to filter the treelist. By default the column menu allows the user to filter if filtering is enabled via the filterable.
        /// </summary>
        /// <param name="value">The value for Filterable</param>
        public TreeListColumnMenuSettingsBuilder<T> Filterable(bool value)
        {
            Container.Filterable = value;
            return this;
        }

        /// <summary>
        /// If set to true the column menu would allow the user to sort the treelist by the column field. By default the column menu allows the user to sort if sorting is enabled via the sortable option.
        /// </summary>
        /// <param name="value">The value for Sortable</param>
        public TreeListColumnMenuSettingsBuilder<T> Sortable(bool value)
        {
            Container.Sortable = value;
            return this;
        }

        /// <summary>
        /// The text messages displayed in the column menu. Use it to customize or localize the column menu messages.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public TreeListColumnMenuSettingsBuilder<T> Messages(Action<TreeListColumnMenuMessagesSettingsBuilder<T>> configurator)
        {

            Container.Messages.TreeList = Container.TreeList;
            configurator(new TreeListColumnMenuMessagesSettingsBuilder<T>(Container.Messages));

            return this;
        }

    }
}
