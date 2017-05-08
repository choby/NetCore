using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TabStrip
    /// </summary>
    public partial class TabStripBuilder
        
    {
        /// <summary>
        /// Specifies whether the TabStrip should be able to collapse completely when clicking an expanded tab.
        /// </summary>
        /// <param name="value">The value for Collapsible</param>
        public TabStripBuilder Collapsible(bool value)
        {
            Container.Collapsible = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the TabStrip should be able to collapse completely when clicking an expanded tab.
        /// </summary>
        public TabStripBuilder Collapsible()
        {
            Container.Collapsible = true;
            return this;
        }

        /// <summary>
        /// Specifies whether the TabStrip should be keyboard navigatable.
        /// </summary>
        /// <param name="value">The value for Navigatable</param>
        public TabStripBuilder Navigatable(bool value)
        {
            Container.Navigatable = value;
            return this;
        }

        /// <summary>
        /// If enabled, the TabStrip will display buttons that will scroll the tabs horizontally, when they cannot fit the TabStrip width. By default scrolling is enabled.The feature requires "top" or "bottom" tabPosition.Unless disabled, scrollable must be set to a JavaScript object, which represents the scrolling configuration.See Scrollable Tabs for more information.
        /// </summary>
        /// <param name="configurator">The configurator for the scrollable setting.</param>
        public TabStripBuilder Scrollable(Action<TabStripScrollableSettingsBuilder> configurator)
        {
            Container.Scrollable.Enabled = true;

            Container.Scrollable.TabStrip = Container;
            configurator(new TabStripScrollableSettingsBuilder(Container.Scrollable));

            return this;
        }

        /// <summary>
        /// If enabled, the TabStrip will display buttons that will scroll the tabs horizontally, when they cannot fit the TabStrip width. By default scrolling is enabled.The feature requires "top" or "bottom" tabPosition.Unless disabled, scrollable must be set to a JavaScript object, which represents the scrolling configuration.See Scrollable Tabs for more information.
        /// </summary>
        /// <param name="enabled">Enables or disables the scrollable option.</param>
        public TabStripBuilder Scrollable(bool enabled)
        {
            Container.Scrollable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The criterion operator type.
        /// </summary>
        /// <param name="value">The value for TabPosition</param>
        public TabStripBuilder TabPosition(TabStripTabPosition value)
        {
            Container.TabPosition = value;
            return this;
        }

        /// <summary>
        /// Specifies the selected tab. Should be corresponding to the dataTextField configuration and used when bound to a DataSource component.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public TabStripBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().TabStrip()
        ///       .Name("TabStrip")
        ///       .Events(events => events
        ///           .Activate("onActivate")
        ///       )
        /// )
        /// </code>
        /// </example>
        public TabStripBuilder Events(Action<TabStripEventBuilder> configurator)
        {
            configurator(new TabStripEventBuilder(Container.Events));
            return this;
        }
        
    }
}

