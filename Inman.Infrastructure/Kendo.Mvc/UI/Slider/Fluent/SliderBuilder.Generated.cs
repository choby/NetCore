using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Slider
    /// </summary>
    public partial class SliderBuilder<T>
        where T : struct, IComparable 
    {
        /// <summary>
        /// The title of the decrease button of the Slider.
        /// </summary>
        /// <param name="value">The value for DecreaseButtonTitle</param>
        public SliderBuilder<T> DecreaseButtonTitle(string value)
        {
            Container.DecreaseButtonTitle = value;
            return this;
        }

        /// <summary>
        /// The title of the drag handle of the Slider.
        /// </summary>
        /// <param name="value">The value for DragHandleTitle</param>
        public SliderBuilder<T> DragHandleTitle(string value)
        {
            Container.DragHandleTitle = value;
            return this;
        }

        /// <summary>
        /// The title of the increase button of the Slider.
        /// </summary>
        /// <param name="value">The value for IncreaseButtonTitle</param>
        public SliderBuilder<T> IncreaseButtonTitle(string value)
        {
            Container.IncreaseButtonTitle = value;
            return this;
        }

        /// <summary>
        /// The delta with which the value will change when the user presses the Page Up or Page Down key (the drag
		/// handle must be focused). Note: largeStep will also set a large tick for every large step.Must be a positive number, larger than smallStep.
        /// </summary>
        /// <param name="value">The value for LargeStep</param>
        public SliderBuilder<T> LargeStep(T? value)
        {
            Container.LargeStep = value;
            return this;
        }

        /// <summary>
        /// The maximum value of the Slider.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public SliderBuilder<T> Max(T? value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The minimum value of the Slider.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public SliderBuilder<T> Min(T? value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// Can be used to show (true) or hide (false) the
		/// increase and decrease buttons of a Slider.
        /// </summary>
        /// <param name="value">The value for ShowButtons</param>
        public SliderBuilder<T> ShowButtons(bool value)
        {
            Container.ShowButtons = value;
            return this;
        }

        /// <summary>
        /// The small step value of the Slider. Must be a positive number, otherwise an Javascript exception will be thrown.The small step value determines the amount of Slider value change when the end user
        /// </summary>
        /// <param name="value">The value for SmallStep</param>
        public SliderBuilder<T> SmallStep(T? value)
        {
            Container.SmallStep = value;
            return this;
        }

        /// <summary>
        /// Configuration of the Slider tooltip.
        /// </summary>
        /// <param name="configurator">The configurator for the tooltip setting.</param>
        public SliderBuilder<T> Tooltip(Action<SliderTooltipSettingsBuilder<T>> configurator)
        {

            Container.Tooltip.Slider = Container;
            configurator(new SliderTooltipSettingsBuilder<T>(Container.Tooltip));

            return this;
        }

        /// <summary>
        /// The underlying value of the Slider.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public SliderBuilder<T> Value(T? value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// The orientation of a Slider
        /// </summary>
        /// <param name="value">The value for Orientation</param>
        public SliderBuilder<T> Orientation(SliderOrientation value)
        {
            Container.Orientation = value;
            return this;
        }

        /// <summary>
        /// Denotes the location of the tick marks in the Slider
        /// </summary>
        /// <param name="value">The value for TickPlacement</param>
        public SliderBuilder<T> TickPlacement(SliderTickPlacement value)
        {
            Container.TickPlacement = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Slider()
        ///       .Name("Slider")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public SliderBuilder<T> Events(Action<SliderEventBuilder> configurator)
        {
            configurator(new SliderEventBuilder(Container.Events));
            return this;
        }
        
    }
}

