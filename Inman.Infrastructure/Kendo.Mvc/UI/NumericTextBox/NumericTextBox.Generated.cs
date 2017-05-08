using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI NumericTextBox component
    /// </summary>
    public partial class NumericTextBox<T> where T : struct 
    {
        public string Culture { get; set; }

        public int? Decimals { get; set; }

        public string DownArrowText { get; set; }

        public string Format { get; set; }

        public T? Max { get; set; }

        public T? Min { get; set; }

        public string Placeholder { get; set; }

        public bool? RestrictDecimals { get; set; }

        public bool? Round { get; set; }

        public bool? Spinners { get; set; }

        public T? Step { get; set; }

        public string UpArrowText { get; set; }

        public T? Value { get; set; }

        public bool? Enable { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Culture?.HasValue() == true)
            {
                settings["culture"] = Culture;
            }

            if (Decimals.HasValue)
            {
                settings["decimals"] = Decimals;
            }

            if (DownArrowText?.HasValue() == true)
            {
                settings["downArrowText"] = DownArrowText;
            }

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
            }

            if (Placeholder?.HasValue() == true)
            {
                settings["placeholder"] = Placeholder;
            }

            if (RestrictDecimals.HasValue)
            {
                settings["restrictDecimals"] = RestrictDecimals;
            }

            if (Round.HasValue)
            {
                settings["round"] = Round;
            }

            if (Spinners.HasValue)
            {
                settings["spinners"] = Spinners;
            }

            if (UpArrowText?.HasValue() == true)
            {
                settings["upArrowText"] = UpArrowText;
            }

            return settings;
        }
    }
}
