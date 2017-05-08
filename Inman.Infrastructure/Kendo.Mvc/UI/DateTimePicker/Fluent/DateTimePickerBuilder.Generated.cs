using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DateTimePicker
    /// </summary>
    public partial class DateTimePickerBuilder
        
    {
        /// <summary>
        /// Specifies a template used to populate value of the aria-label attribute.
        /// </summary>
        /// <param name="value">The value for ARIATemplate</param>
        public DateTimePickerBuilder ARIATemplate(string value)
        {
            Container.ARIATemplate = value;
            return this;
        }

        /// <summary>
        /// Specifies a template used to populate value of the aria-label attribute.
        /// </summary>
        /// <param name="value">The ID of the template element for ARIATemplate</param>
        public DateTimePickerBuilder ARIATemplateId(string templateId)
        {
            Container.ARIATemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Specifies the culture info used by the widget.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public DateTimePickerBuilder Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template of the DateView.
		/// All dates, which match the date portion of the selected date will be used to re-bind the TimeView.
        /// </summary>
        /// <param name="value">The value for Dates</param>
        public DateTimePickerBuilder Dates(params DateTime[] value)
        {
            Container.Dates = value;
            return this;
        }

        /// <summary>
        /// The template which renders the footer of the calendar. If false, the footer will not be rendered.
        /// </summary>
        /// <param name="value">The value for Footer</param>
        public DateTimePickerBuilder Footer(string value)
        {
            Container.Footer = value;
            return this;
        }

        /// <summary>
        /// Specifies the format, which is used to format the value of the DateTimePicker displayed in the input. The format also will be used to parse the input.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public DateTimePickerBuilder Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        /// <param name="value">The value for Interval</param>
        public DateTimePickerBuilder Interval(double value)
        {
            Container.Interval = value;
            return this;
        }

        /// <summary>
        /// Specifies the maximum date, which the calendar can show.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public DateTimePickerBuilder Max(DateTime value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// Specifies the minimum date that the calendar can show.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public DateTimePickerBuilder Min(DateTime value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// If set to true a week of the year will be shown on the left side of the calendar. It is possible to define a template in order to customize what will be displayed.
        /// </summary>
        /// <param name="value">The value for WeekNumber</param>
        public DateTimePickerBuilder WeekNumber(bool value)
        {
            Container.WeekNumber = value;
            return this;
        }

        /// <summary>
        /// If set to true a week of the year will be shown on the left side of the calendar. It is possible to define a template in order to customize what will be displayed.
        /// </summary>
        public DateTimePickerBuilder WeekNumber()
        {
            Container.WeekNumber = true;
            return this;
        }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input. If not set the value of the options.format and options.timeFormat will be used.
		///  Note that value of the format option is always used. The timeFormat value also will be used if defined.
        /// </summary>
        /// <param name="value">The value for ParseFormats</param>
        public DateTimePickerBuilder ParseFormats(params string[] value)
        {
            Container.ParseFormats = value;
            return this;
        }

        /// <summary>
        /// Specifies the format, which is used to format the values in the time drop-down list.
        /// </summary>
        /// <param name="value">The value for TimeFormat</param>
        public DateTimePickerBuilder TimeFormat(string value)
        {
            Container.TimeFormat = value;
            return this;
        }

        /// <summary>
        /// Specifies the selected value.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public DateTimePickerBuilder Value(DateTime value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Represents available types of calendar views.
        /// </summary>
        /// <param name="value">The value for Start</param>
        public DateTimePickerBuilder Start(CalendarView value)
        {
            Container.Start = value;
            return this;
        }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        /// <param name="value">The value for Depth</param>
        public DateTimePickerBuilder Depth(CalendarView value)
        {
            Container.Depth = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configurator">The configurator for the monthtemplate setting.</param>
        public DateTimePickerBuilder MonthTemplate(Action<DateTimePickerMonthTemplateSettingsBuilder> configurator)
        {

            Container.MonthTemplate.DateTimePicker = Container;
            configurator(new DateTimePickerMonthTemplateSettingsBuilder(Container.MonthTemplate));

            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().DateTimePicker()
        ///       .Name("DateTimePicker")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public DateTimePickerBuilder Events(Action<DateTimePickerEventBuilder> configurator)
        {
            configurator(new DateTimePickerEventBuilder(Container.Events));
            return this;
        }
        
    }
}

