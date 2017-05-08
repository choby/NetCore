using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Calendar
    /// </summary>
    public partial class CalendarBuilder
        
    {
        /// <summary>
        /// Specifies the culture info used by the widget.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public CalendarBuilder Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        /// <param name="value">The value for Dates</param>
        public CalendarBuilder Dates(params DateTime[] value)
        {
            Container.Dates = value;
            return this;
        }

        /// <summary>
        /// The template which renders the footer. If false, the footer will not be rendered.
        /// </summary>
        /// <param name="value">The value for Footer</param>
        public CalendarBuilder Footer(string value)
        {
            Container.Footer = value;
            return this;
        }

        /// <summary>
        /// Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public CalendarBuilder Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// Specifies the maximum date, which the calendar can show.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public CalendarBuilder Max(DateTime value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// Specifies the minimum date, which the calendar can show.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public CalendarBuilder Min(DateTime value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// If set to true a week of the year will be shown on the left side of the calendar. It is possible to define a template in order to customize what will be displayed.
        /// </summary>
        /// <param name="value">The value for WeekNumber</param>
        public CalendarBuilder WeekNumber(bool value)
        {
            Container.WeekNumber = value;
            return this;
        }

        /// <summary>
        /// If set to true a week of the year will be shown on the left side of the calendar. It is possible to define a template in order to customize what will be displayed.
        /// </summary>
        public CalendarBuilder WeekNumber()
        {
            Container.WeekNumber = true;
            return this;
        }

        /// <summary>
        /// Specifies the selected date.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public CalendarBuilder Value(DateTime value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Start</param>
        public CalendarBuilder Start(CalendarView value)
        {
            Container.Start = value;
            return this;
        }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        /// <param name="value">The value for Depth</param>
        public CalendarBuilder Depth(CalendarView value)
        {
            Container.Depth = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="configurator">The configurator for the monthtemplate setting.</param>
        public CalendarBuilder MonthTemplate(Action<CalendarMonthTemplateSettingsBuilder> configurator)
        {

            Container.MonthTemplate.Calendar = Container;
            configurator(new CalendarMonthTemplateSettingsBuilder(Container.MonthTemplate));

            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Calendar()
        ///       .Name("Calendar")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public CalendarBuilder Events(Action<CalendarEventBuilder> configurator)
        {
            configurator(new CalendarEventBuilder(Container.Events));
            return this;
        }
        
    }
}

