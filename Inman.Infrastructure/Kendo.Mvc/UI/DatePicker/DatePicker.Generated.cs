using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DatePicker component
    /// </summary>
    public partial class DatePicker 
    {
        public string ARIATemplate { get; set; }

        public string ARIATemplateId { get; set; }

        public string Culture { get; set; }

        public DateTime[] Dates { get; set; }

        public string Footer { get; set; }

        public string Format { get; set; }

        public DateTime? Max { get; set; }

        public DateTime? Min { get; set; }

        public bool? WeekNumber { get; set; }

        public string[] ParseFormats { get; set; }

        public DateTime? Value { get; set; }

        public CalendarView? Start { get; set; }

        public CalendarView? Depth { get; set; }

        public DatePickerMonthTemplateSettings MonthTemplate { get; } = new DatePickerMonthTemplateSettings();


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

            if (Dates?.Any() == true)
            {
                settings["dates"] = Dates;
            }

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
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
