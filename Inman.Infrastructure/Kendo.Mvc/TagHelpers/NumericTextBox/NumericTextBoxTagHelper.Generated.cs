using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class NumericTextBoxTagHelper
    {
        /// <summary>
        /// Specifies the culture info used by the widget.
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Specifies the number precision applied to the widget value and when the NumericTextBox is focused. If not set, the precision defined by the current culture is used. If the user enters a number with a greater precision than is currently configured, the widget value will be rounded. For example, if decimals is 2 and the user inputs 12.346, the value will become 12.35. If the user inputs 12.99, the value will become 13.00.Compare with the format property.
        /// </summary>
        public int? Decimals { get; set; }

        /// <summary>
        /// Specifies the text of the tooltip on the down arrow.
        /// </summary>
        public string DownArrowText { get; set; }

        /// <summary>
        /// Specifies the number format used when the widget is not focused. Any valid number format is allowed.Compare with the decimals property.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Specifies the largest value the user can enter.
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// Specifies the smallest value the user can enter.
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// The hint displayed by the widget when it is empty. Not set by default.
        /// </summary>
        public string Placeholder { get; set; }

        /// <summary>
        /// Specifies whether the decimals length should be restricted during typing. The length of the fraction is defined by the decimals value.
        /// </summary>
        public bool? RestrictDecimals { get; set; }

        /// <summary>
        /// Specifies whether the value should be rounded or truncated. The length of the fraction is defined by the decimals value.
        /// </summary>
        public bool? Round { get; set; }

        /// <summary>
        /// Specifies whether the up and down spin buttons should be rendered
        /// </summary>
        public bool? Spinners { get; set; }

        /// <summary>
        /// Specifies the value used to increment or decrement widget value.
        /// </summary>
        public double? Step { get; set; }

        /// <summary>
        /// Specifies the text of the tooltip on the up arrow.
        /// </summary>
        public string UpArrowText { get; set; }

        /// <summary>
        /// Specifies the value of the NumericTextBox widget.
        /// </summary>
        public double? Value { get; set; }

        /// <summary>
        /// Enables or disables the textbox.
        /// </summary>
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
