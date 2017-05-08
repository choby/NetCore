using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ContextMenu
    /// </summary>
    public partial class ContextMenuBuilder
        
    {
        /// <summary>
        /// Specifies that ContextMenu should be shown aligned to the target or the filter element if specified.
        /// </summary>
        /// <param name="value">The value for AlignToAnchor</param>
        public ContextMenuBuilder AlignToAnchor(bool value)
        {
            Container.AlignToAnchor = value;
            return this;
        }

        /// <summary>
        /// Specifies that ContextMenu should be shown aligned to the target or the filter element if specified.
        /// </summary>
        public ContextMenuBuilder AlignToAnchor()
        {
            Container.AlignToAnchor = true;
            return this;
        }

        /// <summary>
        /// The DOM element to which the ContextMenu will be appended. The element needs to be relatively positioned.
        /// </summary>
        /// <param name="value">The value for AppendTo</param>
        public ContextMenuBuilder AppendTo(string value)
        {
            Container.AppendTo = value;
            return this;
        }

        /// <summary>
        /// Specifies that sub menus should close after item selection (provided they won't navigate).
        /// </summary>
        /// <param name="value">The value for CloseOnClick</param>
        public ContextMenuBuilder CloseOnClick(bool value)
        {
            Container.CloseOnClick = value;
            return this;
        }

        /// <summary>
        /// Specifies ContextMenu filter selector - the ContextMenu will only be shown on items that satisfy the provided selector.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public ContextMenuBuilder Filter(string value)
        {
            Container.Filter = value;
            return this;
        }

        /// <summary>
        /// Specifies the delay in ms before the sub menus are opened/closed - used to avoid accidental closure on leaving.
        /// </summary>
        /// <param name="value">The value for HoverDelay</param>
        public ContextMenuBuilder HoverDelay(double value)
        {
            Container.HoverDelay = value;
            return this;
        }

        /// <summary>
        /// Specifies the event or events on which ContextMenu should open. By default ContextMenu will show on contextmenu event on desktop and hold event on touch devices.
		/// Could be any pointer/mouse/touch event, also several, separated by spaces.
        /// </summary>
        /// <param name="value">The value for ShowOn</param>
        public ContextMenuBuilder ShowOn(string value)
        {
            Container.ShowOn = value;
            return this;
        }

        /// <summary>
        /// Specifies the element on which ContextMenu should open. The default element is the document body.
        /// </summary>
        /// <param name="value">The value for Target</param>
        public ContextMenuBuilder Target(string value)
        {
            Container.Target = value;
            return this;
        }

        /// <summary>
        /// Specifies the orientation in which the menu items will be ordered
        /// </summary>
        /// <param name="value">The value for Orientation</param>
        public ContextMenuBuilder Orientation(ContextMenuOrientation value)
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
        /// @(Html.Kendo().ContextMenu()
        ///       .Name("ContextMenu")
        ///       .Events(events => events
        ///           .Close("onClose")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ContextMenuBuilder Events(Action<ContextMenuEventBuilder> configurator)
        {
            configurator(new ContextMenuEventBuilder(Container.Events));
            return this;
        }
        
    }
}

