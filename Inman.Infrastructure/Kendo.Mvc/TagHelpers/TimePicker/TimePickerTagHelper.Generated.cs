using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class TimePickerTagHelper
    {
        /// <summary>
        /// Specifies the culture info used by the widget.
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Specifies the format, which is used to format the value of the TimePicker displayed in the input. The format also will be used to parse the input.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        public int? Interval { get; set; }

        /// <summary>
        /// Specifies the end value in the popup list.
        /// </summary>
        public DateTime? Max { get; set; }

        /// <summary>
        /// Specifies the start value in the popup list.
        /// </summary>
        public DateTime? Min { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with the value method or by direct input. If not set the value of the options.format will be used. Note that value of the format option is always used.
        /// </summary>
        public string[] ParseFormats { get; set; }

        /// <summary>
        /// Specifies the selected time.
        /// </summary>
        public DateTime? Value { get; set; }

        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

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

            if (ParseFormats?.Any() == true)
            {
                settings["parseFormats"] = ParseFormats;
            }

            if (Value.HasValue)
            {
                settings["value"] = Value;
            }

            return settings;
        }
    }
}
