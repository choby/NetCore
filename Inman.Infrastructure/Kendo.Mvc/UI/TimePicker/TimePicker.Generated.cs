using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TimePicker component
    /// </summary>
    public partial class TimePicker 
    {
        public string Culture { get; set; }

        public DateTime[] Dates { get; set; }

        public string Format { get; set; }

        public int? Interval { get; set; }

        public DateTime? Max { get; set; }

        public DateTime? Min { get; set; }

        public string[] ParseFormats { get; set; }

        public DateTime? Value { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Culture?.HasValue() == true)
            {
                settings["culture"] = Culture;
            }

            if (Dates?.Any() == true)
            {
                settings["dates"] = Dates;
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
