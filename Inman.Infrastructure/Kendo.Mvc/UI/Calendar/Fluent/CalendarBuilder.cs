using System;
using System.Collections.Generic;
using System.ComponentModel;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Calendar
    /// </summary>
    public partial class CalendarBuilder : WidgetBuilderBase<Calendar, CalendarBuilder>

    {
        public CalendarBuilder(Calendar component) : base(component)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public CalendarBuilder DisableDates(IEnumerable<string> disableDates)
        {
            Component.DisableDates = disableDates;

            return this;
        }

        /// <summary>
        /// Specifies the disabled dates in the Calendar widget using a function.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Calendar()
        ///             .Name("calendar")
        ///             .DisableDates(DayofWeek.Saturday, DayOfWeek.Sunday)
        /// %&gt;
        /// </code>
        /// </example>
        public CalendarBuilder DisableDates(params DayOfWeek[] days)
        {
            Component.DisableDates = days.ToAbbrev();

            return this;
        }

        /// <summary>
        /// Specifies the disabled dates in the Calendar widget using a function.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Calendar()
        ///             .Name("calendar")
        ///             .DisableDates("disableDates")
        /// %&gt;
        /// </code>
        /// </example>
        public CalendarBuilder DisableDates(string handler)
        {
            var handlerDescription = new ClientHandlerDescriptor { HandlerName = handler };
            Component.DisableDatesHandler = handlerDescription;

            return this;
        }

        /// <summary>
        /// FooterId to be used for rendering the footer of the Calendar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Calendar()
        ///             .Name("Calendar")
        ///             .FooterId("widgetFooterId")
        /// %&gt;
        /// </code>
        /// </example>
        public CalendarBuilder FooterId(string id)
        {
            Component.FooterId = id;

            return this;
        }

        /// <summary>
        /// Enable/disable footer.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Calendar()
        ///             .Name("Calendar")
        ///             .Footer(false)
        /// %&gt;
        /// </code>
        /// </example>
        public CalendarBuilder Footer(bool footer)
        {
            Component.EnableFooter = footer;

            return this;
        }

        /// <summary>
        /// MonthTemplateId to be used for rendering the cells of the Calendar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Calendar()
        ///             .Name("Calendar")
        ///             .MonthTemplateId("widgetMonthTemplateId")
        /// %&gt;
        /// </code>
        /// </example>
        public CalendarBuilder MonthTemplateId(string id)
        {
            Component.MonthTemplate.ContentId = id;

            return this;
        }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Calendar()
        ///             .Name("Calendar")
        ///             .MonthTemplate("#= data.value #")
        /// %&gt;
        /// </code>
        /// </example>
        public CalendarBuilder MonthTemplate(string content)
        {
            Component.MonthTemplate.Content = content;

            return this;
        }

        /// <summary>
        /// Sets the minimal date, which can be selected in the calendar.
        /// </summary>
        public CalendarBuilder Min(string date)
        {
            DateTime parsedDate;

            if (DateTime.TryParse(date, out parsedDate))
            {
                Component.Min = parsedDate;
            }
            else
            {
                throw new ArgumentException(Exceptions.StringNotCorrectDate);
            }
            return this;
        }

        /// <summary>
        /// Sets the maximal date, which can be selected in the calendar.
        /// </summary>
        public CalendarBuilder Max(string date)
        {
            DateTime parsedDate;

            if (DateTime.TryParse(date, out parsedDate))
            {
                Component.Max = parsedDate;
            }
            else
            {
                throw new ArgumentException(Exceptions.StringNotCorrectDate);
            }
            return this;
        }

        /// <summary>
        /// Sets the value of the calendar
        /// </summary>
        public CalendarBuilder Value(DateTime? date)
        {
            Component.Value = date;

            return this;
        }

        /// <summary>
        /// Sets the value of the calendar
        /// </summary>
        public CalendarBuilder Value(string date)
        {
            DateTime result;

            if (DateTime.TryParse(date, out result))
            {
                Component.Value = result;
            }
            else
            {
                Component.Value = null;
            }

            return this;
        }

        /// <summary>
        /// Configures the selection settings of the calendar.
        /// </summary>
        /// <param name="selectionAction">SelectAction settings, which includes Action name and IEnumerable of DateTime objects.</param>
        /// <returns></returns>
        public CalendarBuilder Selection(Action<CalendarSelectionSettingsBuilder> selectionAction)
        {
            selectionAction(new CalendarSelectionSettingsBuilder(Component.SelectionSettings));

            return this;

        }
    }
}

