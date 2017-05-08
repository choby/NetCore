using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TimePicker
    /// </summary>
    public partial class TimePickerBuilder
        
    {
        /// <summary>
        /// Specifies the culture info used by the widget.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public TimePickerBuilder Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// Specifies a list of dates, which are shown in the time drop-down list. If not set, the TimePicker will auto-generate the available times.
        /// </summary>
        /// <param name="value">The value for Dates</param>
        public TimePickerBuilder Dates(params DateTime[] value)
        {
            Container.Dates = value;
            return this;
        }

        /// <summary>
        /// Specifies the format, which is used to format the value of the TimePicker displayed in the input. The format also will be used to parse the input.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public TimePickerBuilder Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        /// <param name="value">The value for Interval</param>
        public TimePickerBuilder Interval(int value)
        {
            Container.Interval = value;
            return this;
        }

        /// <summary>
        /// Specifies the end value in the popup list.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public TimePickerBuilder Max(DateTime value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// Specifies the start value in the popup list.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public TimePickerBuilder Min(DateTime value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with the value method or by direct input. If not set the value of the options.format will be used. Note that value of the format option is always used.
        /// </summary>
        /// <param name="value">The value for ParseFormats</param>
        public TimePickerBuilder ParseFormats(params string[] value)
        {
            Container.ParseFormats = value;
            return this;
        }

        /// <summary>
        /// Specifies the selected time.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public TimePickerBuilder Value(DateTime value)
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
        /// @(Html.Kendo().TimePicker()
        ///       .Name("TimePicker")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public TimePickerBuilder Events(Action<TimePickerEventBuilder> configurator)
        {
            configurator(new TimePickerEventBuilder(Container.Events));
            return this;
        }
        
    }
}

