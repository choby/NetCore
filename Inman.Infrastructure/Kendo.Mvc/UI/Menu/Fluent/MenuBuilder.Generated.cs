using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Menu
    /// </summary>
    public partial class MenuBuilder
        
    {
        /// <summary>
        /// Specifies that sub menus should close after item selection (provided they won't navigate).
        /// </summary>
        /// <param name="value">The value for CloseOnClick</param>
        public MenuBuilder CloseOnClick(bool value)
        {
            Container.CloseOnClick = value;
            return this;
        }

        /// <summary>
        /// Specifies the delay in ms before the menu is opened/closed - used to avoid accidental closure on leaving.
        /// </summary>
        /// <param name="value">The value for HoverDelay</param>
        public MenuBuilder HoverDelay(double value)
        {
            Container.HoverDelay = value;
            return this;
        }

        /// <summary>
        /// Specifies that the root sub menus will be opened on item click.
        /// </summary>
        /// <param name="value">The value for OpenOnClick</param>
        public MenuBuilder OpenOnClick(bool value)
        {
            Container.OpenOnClick = value;
            return this;
        }

        /// <summary>
        /// Specifies that the root sub menus will be opened on item click.
        /// </summary>
        public MenuBuilder OpenOnClick()
        {
            Container.OpenOnClick = true;
            return this;
        }

        /// <summary>
        /// Specifies the orientation in which the menu items will be ordered
        /// </summary>
        /// <param name="value">The value for Orientation</param>
        public MenuBuilder Orientation(MenuOrientation value)
        {
            Container.Orientation = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Menu()
        ///       .Name("Menu")
        ///       .Events(events => events
        ///           .Close("onClose")
        ///       )
        /// )
        /// </code>
        /// </example>
        public MenuBuilder Events(Action<MenuEventBuilder> configurator)
        {
            configurator(new MenuEventBuilder(Container.Events));
            return this;
        }
        
    }
}

