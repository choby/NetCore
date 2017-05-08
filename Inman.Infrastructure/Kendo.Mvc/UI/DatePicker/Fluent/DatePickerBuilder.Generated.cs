using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DatePicker
    /// </summary>
    public partial class DatePickerBuilder
        
    {
        /// <summary>
        /// Specifies a template used to populate value of the aria-label attribute.
        /// </summary>
        /// <param name="value">The value for ARIATemplate</param>
        public DatePickerBuilder ARIATemplate(string value)
        {
            Container.ARIATemplate = value;
            return this;
        }

        /// <summary>
        /// Specifies a template used to populate value of the aria-label attribute.
        /// </summary>
        /// <param name="value">The ID of the template element for ARIATemplate</param>
        public DatePickerBuilder ARIATemplateId(string templateId)
        {
            Container.ARIATemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Specifies the culture info used by the widget.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public DatePickerBuilder Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        /// <param name="value">The value for Dates</param>
        public DatePickerBuilder Dates(params DateTime[] value)
        {
            Container.Dates = value;
            return this;
        }

        /// <summary>
        /// The template which renders the footer of the calendar. If false, the footer will not be rendered.
        /// </summary>
        /// <param name="value">The value for Footer</param>
        public DatePickerBuilder Footer(string value)
        {
            Container.Footer = value;
            return this;
        }

        /// <summary>
        /// Specifies the format, which is used to format the value of the DatePicker displayed in the input. The format also will be used to parse the input.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public DatePickerBuilder Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// Specifies the maximum date, which the calendar can show.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public DatePickerBuilder Max(DateTime value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// Specifies the minimum date that the calendar can show.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public DatePickerBuilder Min(DateTime value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// If set to true a week of the year will be shown on the left side of the calendar. It is possible to define a template in order to customize what will be displayed.
        /// </summary>
        /// <param name="value">The value for WeekNumber</param>
        public DatePickerBuilder WeekNumber(bool value)
        {
            Container.WeekNumber = value;
            return this;
        }

        /// <summary>
        /// If set to true a week of the year will be shown on the left side of the calendar. It is possible to define a template in order to customize what will be displayed.
        /// </summary>
        public DatePickerBuilder WeekNumber()
        {
            Container.WeekNumber = true;
            return this;
        }

        /// <summary>
        /// Specifies a list of date formats used to parse the value set with value() method or by direct user input. If not set the value of the format will be used.
		///  Note that the format option is always used during parsing.
        /// </summary>
        /// <param name="value">The value for ParseFormats</param>
        public DatePickerBuilder ParseFormats(params string[] value)
        {
            Container.ParseFormats = value;
            return this;
        }

        /// <summary>
        /// Specifies the selected date.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public DatePickerBuilder Value(DateTime value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Start</param>
        public DatePickerBuilder Start(CalendarView value)
        {
            Container.Start = value;
            return this;
        }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        /// <param name="value">The value for Depth</param>
        public DatePickerBuilder Depth(CalendarView value)
        {
            Container.Depth = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configurator">The configurator for the monthtemplate setting.</param>
        public DatePickerBuilder MonthTemplate(Action<DatePickerMonthTemplateSettingsBuilder> configurator)
        {

            Container.MonthTemplate.DatePicker = Container;
            configurator(new DatePickerMonthTemplateSettingsBuilder(Container.MonthTemplate));

            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().DatePicker()
        ///       .Name("DatePicker")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public DatePickerBuilder Events(Action<DatePickerEventBuilder> configurator)
        {
            configurator(new DatePickerEventBuilder(Container.Events));
            return this;
        }
        
    }
}

