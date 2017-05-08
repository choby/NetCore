using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI RangeSlider
    /// </summary>
    public partial class RangeSliderBuilder<T>
        where T : struct, IComparable 
    {
        /// <summary>
        /// The delta with which the value will change when the user presses the Page Up or Page Down key (the drag
		/// handle must be focused). Note: The allied largeStep will also set large tick for every large step.
        /// </summary>
        /// <param name="value">The value for LargeStep</param>
        public RangeSliderBuilder<T> LargeStep(T? value)
        {
            Container.LargeStep = value;
            return this;
        }

        /// <summary>
        /// The title of the left drag handle of the RangeSlider.
        /// </summary>
        /// <param name="value">The value for LeftDragHandleTitle</param>
        public RangeSliderBuilder<T> LeftDragHandleTitle(string value)
        {
            Container.LeftDragHandleTitle = value;
            return this;
        }

        /// <summary>
        /// The maximum value of the RangeSlider.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public RangeSliderBuilder<T> Max(T? value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The minimum value of the RangeSlider.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public RangeSliderBuilder<T> Min(T? value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// The orientation of a RangeSlider - "horizontal" or "vertical".
        /// </summary>
        /// <param name="value">The value for Orientation</param>
        public RangeSliderBuilder<T> Orientation(SliderOrientation value)
        {
            Container.Orientation = value;
            return this;
        }

        /// <summary>
        /// The title of the right drag handle of the RangeSlider.
        /// </summary>
        /// <param name="value">The value for RightDragHandleTitle</param>
        public RangeSliderBuilder<T> RightDragHandleTitle(string value)
        {
            Container.RightDragHandleTitle = value;
            return this;
        }

        /// <summary>
        /// The selection end value of the RangeSlider.
        /// </summary>
        /// <param name="value">The value for SelectionEnd</param>
        public RangeSliderBuilder<T> SelectionEnd(T? value)
        {
            Container.SelectionEnd = value;
            return this;
        }

        /// <summary>
        /// The selection start value of the RangeSlider.
        /// </summary>
        /// <param name="value">The value for SelectionStart</param>
        public RangeSliderBuilder<T> SelectionStart(T? value)
        {
            Container.SelectionStart = value;
            return this;
        }

        /// <summary>
        /// The small step value of the RangeSlider. The underlying value will be changed when the end
		/// user (1) clicks on the increase or decrease buttons of the RangeSlider, (2) presses the
		/// arrow keys (the drag handle must be focused), or (3) drags the drag handle.
        /// </summary>
        /// <param name="value">The value for SmallStep</param>
        public RangeSliderBuilder<T> SmallStep(T? value)
        {
            Container.SmallStep = value;
            return this;
        }

        /// <summary>
        /// Denotes the location of the tick marks in the RangeSlider. The available options are:
        /// </summary>
        /// <param name="value">The value for TickPlacement</param>
        public RangeSliderBuilder<T> TickPlacement(SliderTickPlacement value)
        {
            Container.TickPlacement = value;
            return this;
        }

        /// <summary>
        /// Configuration of the RangeSlider tooltip.
        /// </summary>
        /// <param name="configurator">The configurator for the tooltip setting.</param>
        public RangeSliderBuilder<T> Tooltip(Action<RangeSliderTooltipSettingsBuilder<T>> configurator)
        {

            Container.Tooltip.RangeSlider = Container;
            configurator(new RangeSliderTooltipSettingsBuilder<T>(Container.Tooltip));

            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().RangeSlider()
        ///       .Name("RangeSlider")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public RangeSliderBuilder<T> Events(Action<RangeSliderEventBuilder> configurator)
        {
            configurator(new RangeSliderEventBuilder(Container.Events));
            return this;
        }
        
    }
}

