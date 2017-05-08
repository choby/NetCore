using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Sortable
    /// </summary>
    public partial class SortableBuilder
        
    {
        /// <summary>
        /// If set to true the widget will auto-scroll the container when the mouse/finger is close to the top/bottom of it.
        /// </summary>
        /// <param name="value">The value for AutoScroll</param>
        public SortableBuilder AutoScroll(bool value)
        {
            Container.AutoScroll = value;
            return this;
        }

        /// <summary>
        /// If set to true the widget will auto-scroll the container when the mouse/finger is close to the top/bottom of it.
        /// </summary>
        public SortableBuilder AutoScroll()
        {
            Container.AutoScroll = true;
            return this;
        }

        /// <summary>
        /// Selector which determines if items from the current Sortable widget can be accepted from another Sortable container(s). The connectWith option describes one way relationship, if the developer wants a two way connection then the connectWith option should be set on both widgets.
        /// </summary>
        /// <param name="value">The value for ConnectWith</param>
        public SortableBuilder ConnectWith(string value)
        {
            Container.ConnectWith = value;
            return this;
        }

        /// <summary>
        /// The cursor that will be shown while user drags sortable item.
        /// </summary>
        /// <param name="value">The value for Cursor</param>
        public SortableBuilder Cursor(string value)
        {
            Container.Cursor = value;
            return this;
        }

        /// <summary>
        /// If set, specifies the offset of the hint relative to the mouse cursor/finger.
		/// By default, the hint is initially positioned on top of the draggable source offset. The option accepts an object with two keys: top and left.
        /// </summary>
        /// <param name="configurator">The configurator for the cursoroffset setting.</param>
        public SortableBuilder CursorOffset(Action<SortableCursorOffsetSettingsBuilder> configurator)
        {

            Container.CursorOffset.Sortable = Container;
            configurator(new SortableCursorOffsetSettingsBuilder(Container.CursorOffset));

            return this;
        }

        /// <summary>
        /// Selector that determines which items are disabled. Disabled items cannot be dragged but are valid sort targets.
        /// </summary>
        /// <param name="value">The value for Disabled</param>
        public SortableBuilder Disabled(string value)
        {
            Container.Disabled = value;
            return this;
        }

        /// <summary>
        /// Selector that determines which items are sortable. Filtered items cannot be dragged and are not valid sort targets.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public SortableBuilder Filter(string value)
        {
            Container.Filter = value;
            return this;
        }

        /// <summary>
        /// Selector that determines which element will be used as a draggable handler. If a handler is defined, the user will be able to move the Sortable items only if the cursor/finger is positioned onto the handler element.
        /// </summary>
        /// <param name="value">The value for Handler</param>
        public SortableBuilder Handler(string value)
        {
            Container.Handler = value;
            return this;
        }

        /// <summary>
        /// Suitable for touch oriented user interface, in order to avoid collision with the touch scrolling gesture. When set to true, the item will be activated after the user taps and holds the finger on the element for a short amount of time.
		/// The item will also be activated by pressing, holding and lifting the finger without any movement. Dragging it afterwards will initiate the drag immediately.
        /// </summary>
        /// <param name="value">The value for HoldToDrag</param>
        public SortableBuilder HoldToDrag(bool value)
        {
            Container.HoldToDrag = value;
            return this;
        }

        /// <summary>
        /// Suitable for touch oriented user interface, in order to avoid collision with the touch scrolling gesture. When set to true, the item will be activated after the user taps and holds the finger on the element for a short amount of time.
		/// The item will also be activated by pressing, holding and lifting the finger without any movement. Dragging it afterwards will initiate the drag immediately.
        /// </summary>
        public SortableBuilder HoldToDrag()
        {
            Container.HoldToDrag = true;
            return this;
        }

        /// <summary>
        /// Selector that determines which elements inside the sorted item's container will be ignored. Useful if the sortable item contains input elements.
        /// </summary>
        /// <param name="value">The value for Ignore</param>
        public SortableBuilder Ignore(string value)
        {
            Container.Ignore = value;
            return this;
        }

        /// <summary>
        /// Represents the Sortable widget Axis
        /// </summary>
        /// <param name="value">The value for Axis</param>
        public SortableBuilder Axis(SortableAxis value)
        {
            Container.Axis = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Sortable()
        ///       .Name("Sortable")
        ///       .Events(events => events
        ///           .Start("onStart")
        ///       )
        /// )
        /// </code>
        /// </example>
        public SortableBuilder Events(Action<SortableEventBuilder> configurator)
        {
            configurator(new SortableEventBuilder(Container.Events));
            return this;
        }
        
    }
}

