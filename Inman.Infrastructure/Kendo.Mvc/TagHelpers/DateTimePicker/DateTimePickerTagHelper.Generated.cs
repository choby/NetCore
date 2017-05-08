using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class DateTimePickerTagHelper
    {
        /// <summary>
        /// Specifies a template used to populate value of the aria-label attribute.
        /// </summary>
        [HtmlAttributeName("ariatemplate")]
        public string ARIATemplate { get; set; }

        /// <summary>
        /// Specifies a template used to populate value of the aria-label attribute.
        /// </summary>
        /// <param name="value">The ID of the template element for ARIATemplate</param>
        [HtmlAttributeName("ariatemplate-id")]
        public string ARIATemplateId { get; set; }

        /// <summary>
        /// Specifies the culture info used by the widget.
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// The template which renders the footer of the calendar. If false, the footer will not be rendered.
        /// </summary>
        public string Footer { get; set; }

        /// <summary>
        /// Specifies the format, which is used to format the value of the DateTimePicker displayed in the input. The format also will be used to parse the input.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        public double? Interval { get; set; }

        /// <summary>
        /// Specifies the maximum date, which the calendar can show.
        /// </summary>
        public DateTime? Max { get; set; }

        /// <summary>
        /// Specifies the minimum date that the calendar can show.
        /// </summary>
        public DateTime? Min { get; set; }

        /// <summary>
        /// If set to true a week of the year will be shown on the left side of the calendar. It is possible to define a template in order to customize what will be displayed.
        /// </summary>
        public bool? WeekNumber { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input. If not set the value of the options.format and options.timeFormat will be used.
		///  Note that value of the format option is always used. The timeFormat value also will be used if defined.
        /// </summary>
        public string[] ParseFormats { get; set; }

        /// <summary>
        /// Specifies the format, which is used to format the values in the time drop-down list.
        /// </summary>
        public string TimeFormat { get; set; }

        /// <summary>
        /// Specifies the selected value.
        /// </summary>
        public DateTime? Value { get; set; }

        /// <summary>
        /// Specifies the start view of the calendar.
        /// </summary>
        public CalendarView? Start { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        public CalendarView? Depth { get; set; }

        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (ARIATemplateId.HasValue())
            {
                settings["ARIATemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, ARIATemplateId
                    )
                };
            }
            else if (ARIATemplate.HasValue())
            {
                settings["ARIATemplate"] = ARIATemplate;
            }

            if (Culture?.HasValue() == true)
            {
                settings["culture"] = Culture;
            }

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
            }

            if (Interval.HasValue)
            {
                settings["interval"] = Interval;
            }

            if (Max.HasValue)
            {
                settings["max"] = Max;
            }

            if (Min.HasValue)
            {
                settings["min"] = Min;
            }

            if (WeekNumber.HasValue)
            {
                settings["weekNumber"] = WeekNumber;
            }

            if (ParseFormats?.Any() == true)
            {
                settings["parseFormats"] = ParseFormats;
            }

            if (TimeFormat?.HasValue() == true)
            {
                settings["timeFormat"] = TimeFormat;
            }

            if (Value.HasValue)
            {
                settings["value"] = Value;
            }

            if (Start.HasValue)
            {
                settings["start"] = Start?.Serialize();
            }

            if (Depth.HasValue)
            {
                settings["depth"] = Depth?.Serialize();
            }

            return settings;
        }
    }
}
