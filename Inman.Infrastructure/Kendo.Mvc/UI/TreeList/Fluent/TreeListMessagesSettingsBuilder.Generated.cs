using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListMessagesSettings
    /// </summary>
    public partial class TreeListMessagesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Defines the text for the command buttons used across the widget.
        /// </summary>
        /// <param name="configurator">The configurator for the commands setting.</param>
        public TreeListMessagesSettingsBuilder<T> Commands(Action<TreeListMessagesCommandsSettingsBuilder<T>> configurator)
        {

            Container.Commands.TreeList = Container.TreeList;
            configurator(new TreeListMessagesCommandsSettingsBuilder<T>(Container.Commands));

            return this;
        }

        /// <summary>
        /// Defines the text of the "Loading..." message when the widget loads its root-level items.
        /// </summary>
        /// <param name="value">The value for Loading</param>
        public TreeListMessagesSettingsBuilder<T> Loading(string value)
        {
            Container.Loading = value;
            return this;
        }

        /// <summary>
        /// Defines the text of "No records to display" message when the widget does not show any items.
        /// </summary>
        /// <param name="value">The value for NoRows</param>
        public TreeListMessagesSettingsBuilder<T> NoRows(string value)
        {
            Container.NoRows = value;
            return this;
        }

        /// <summary>
        /// Defines the text of "Request failed." message when the widget fails to load its root-level items.
        /// </summary>
        /// <param name="value">The value for RequestFailed</param>
        public TreeListMessagesSettingsBuilder<T> RequestFailed(string value)
        {
            Container.RequestFailed = value;
            return this;
        }

        /// <summary>
        /// Defines the text of "Retry" message assigned to the button that tries to load root-level items again.
        /// </summary>
        /// <param name="value">The value for Retry</param>
        public TreeListMessagesSettingsBuilder<T> Retry(string value)
        {
            Container.Retry = value;
            return this;
        }

    }
}
