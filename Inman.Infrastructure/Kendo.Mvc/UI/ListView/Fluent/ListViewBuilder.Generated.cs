using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ListView
    /// </summary>
    public partial class ListViewBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value for AutoBind</param>
        public ListViewBuilder<T> AutoBind(bool value)
        {
            Container.AutoBind = value;
            return this;
        }

        /// <summary>
        /// Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        /// <param name="value">The value for Navigatable</param>
        public ListViewBuilder<T> Navigatable(bool value)
        {
            Container.Navigatable = value;
            return this;
        }

        /// <summary>
        /// Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        public ListViewBuilder<T> Navigatable()
        {
            Container.Navigatable = true;
            return this;
        }

        /// <summary>
        /// Specifies ListView wrapper element tag name.
        /// </summary>
        /// <param name="value">The value for TagName</param>
        public ListViewBuilder<T> TagName(string value)
        {
            Container.TagName = value;
            return this;
        }

        /// <summary>
        /// Specifies whether item selection is allowed. By default selection is disabled
        /// </summary>
        /// <param name="configurator">The configurator for the selectable setting.</param>
        public ListViewBuilder<T> Selectable(Action<ListViewSelectableSettingsBuilder<T>> configurator)
        {
            Container.Selectable.Enabled = true;

            Container.Selectable.ListView = Container;
            configurator(new ListViewSelectableSettingsBuilder<T>(Container.Selectable));

            return this;
        }

        /// <summary>
        /// Specifies whether item selection is allowed. By default selection is disabled
        /// </summary>
        /// <param name="enabled">Enables or disables the selectable option.</param>
        public ListViewBuilder<T> Selectable(bool enabled)
        {
            Container.Selectable.Enabled = enabled;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().ListView()
        ///       .Name("ListView")
        ///       .Events(events => events
        ///           .Cancel("onCancel")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ListViewBuilder<T> Events(Action<ListViewEventBuilder> configurator)
        {
            configurator(new ListViewEventBuilder(Container.Events));
            return this;
        }
        
    }
}

