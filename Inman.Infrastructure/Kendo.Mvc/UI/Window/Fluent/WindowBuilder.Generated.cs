using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Window
    /// </summary>
    public partial class WindowBuilder
        
    {
        /// <summary>
        /// Determines whether the Window will be focused automatically when opened. The property also influences the focus behavior when the Window is clicked when already opened.
        /// </summary>
        /// <param name="value">The value for AutoFocus</param>
        public WindowBuilder AutoFocus(bool value)
        {
            Container.AutoFocus = value;
            return this;
        }

        /// <summary>
        /// Enables (true) or disables (false) the ability for users to move/drag the widget.
        /// </summary>
        /// <param name="value">The value for Draggable</param>
        public WindowBuilder Draggable(bool value)
        {
            Container.Draggable = value;
            return this;
        }

        /// <summary>
        /// Explicitly states whether a content iframe should be created. For more information, please read Using iframes.
        /// </summary>
        /// <param name="value">The value for Iframe</param>
        public WindowBuilder Iframe(bool value)
        {
            Container.Iframe = value;
            return this;
        }

        /// <summary>
        /// Specifies height of the window.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public WindowBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The maximum height (in pixels) that may be achieved by resizing the window.
        /// </summary>
        /// <param name="value">The value for MaxHeight</param>
        public WindowBuilder MaxHeight(double value)
        {
            Container.MaxHeight = value;
            return this;
        }

        /// <summary>
        /// The maximum width (in pixels) that may be achieved by resizing the window.
        /// </summary>
        /// <param name="value">The value for MaxWidth</param>
        public WindowBuilder MaxWidth(double value)
        {
            Container.MaxWidth = value;
            return this;
        }

        /// <summary>
        /// The minimum height (in pixels) that may be achieved by resizing the window.
        /// </summary>
        /// <param name="value">The value for MinHeight</param>
        public WindowBuilder MinHeight(double value)
        {
            Container.MinHeight = value;
            return this;
        }

        /// <summary>
        /// The minimum width (in pixels) that may be achieved by resizing the window.
        /// </summary>
        /// <param name="value">The value for MinWidth</param>
        public WindowBuilder MinWidth(double value)
        {
            Container.MinWidth = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the window should show a modal overlay over the page.
        /// </summary>
        /// <param name="value">The value for Modal</param>
        public WindowBuilder Modal(bool value)
        {
            Container.Modal = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the window should show a modal overlay over the page.
        /// </summary>
        public WindowBuilder Modal()
        {
            Container.Modal = true;
            return this;
        }

        /// <summary>
        /// Specifies whether the window should be pinned, i.e. it will not move together with the page content during scrolling.
        /// </summary>
        /// <param name="value">The value for Pinned</param>
        public WindowBuilder Pinned(bool value)
        {
            Container.Pinned = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the window should be pinned, i.e. it will not move together with the page content during scrolling.
        /// </summary>
        public WindowBuilder Pinned()
        {
            Container.Pinned = true;
            return this;
        }

        /// <summary>
        /// A collection of one or two members, which define the initial Window's top and/or left position on the page.
        /// </summary>
        /// <param name="configurator">The configurator for the position setting.</param>
        public WindowBuilder Position(Action<WindowPositionSettingsBuilder> configurator)
        {

            Container.Position.Window = Container;
            configurator(new WindowPositionSettingsBuilder(Container.Position));

            return this;
        }

        /// <summary>
        /// Enables (true) or disables (false) the ability for users to scroll the window contents.
        /// </summary>
        /// <param name="value">The value for Scrollable</param>
        public WindowBuilder Scrollable(bool value)
        {
            Container.Scrollable = value;
            return this;
        }

        /// <summary>
        /// The text in the window title bar. If false, the window will be displayed without a title bar. Note that this will prevent the window from being dragged, and the window titlebar buttons will not be shown.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public WindowBuilder Title(string value)
        {
            Container.Title = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the window will be initially visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public WindowBuilder Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// Specifies width of the window.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public WindowBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Window()
        ///       .Name("Window")
        ///       .Events(events => events
        ///           .Activate("onActivate")
        ///       )
        /// )
        /// </code>
        /// </example>
        public WindowBuilder Events(Action<WindowEventBuilder> configurator)
        {
            configurator(new WindowEventBuilder(Container.Events));
            return this;
        }
        
    }
}

