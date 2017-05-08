using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI LinearGaugeScaleSettings class
    /// </summary>
    public partial class LinearGaugeScaleSettings 
    {
        public LinearGaugeScaleLineSettings Line { get; } = new LinearGaugeScaleLineSettings();

        public LinearGaugeScaleLabelsSettings Labels { get; } = new LinearGaugeScaleLabelsSettings();

        public LinearGaugeScaleMajorTicksSettings MajorTicks { get; } = new LinearGaugeScaleMajorTicksSettings();

        public double? MajorUnit { get; set; }

        public double? Max { get; set; }

        public double? Min { get; set; }

        public LinearGaugeScaleMinorTicksSettings MinorTicks { get; } = new LinearGaugeScaleMinorTicksSettings();

        public double? MinorUnit { get; set; }

        public bool? Mirror { get; set; }

        public List<LinearGaugeScaleSettingsRange> Ranges { get; set; } = new List<LinearGaugeScaleSettingsRange>();

        public string RangePlaceholderColor { get; set; }

        public double? RangeSize { get; set; }

        public bool? Reverse { get; set; }

        public bool? Vertical { get; set; }


        public LinearGauge LinearGauge { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var line = Line.Serialize();
            if (line.Any())
            {
                settings["line"] = line;
            }

            var labels = Labels.Serialize();
            if (labels.Any())
            {
                settings["labels"] = labels;
            }

            var majorTicks = MajorTicks.Serialize();
            if (majorTicks.Any())
            {
                settings["majorTicks"] = majorTicks;
            }

            if (MajorUnit.HasValue)
            {
                settings["majorUnit"] = MajorUnit;
            }

            if (Max.HasValue)
            {
                settings["max"] = Max;
            }

            if (Min.HasValue)
            {
                settings["min"] = Min;
            }

            var minorTicks = MinorTicks.Serialize();
            if (minorTicks.Any())
            {
                settings["minorTicks"] = minorTicks;
            }

            if (MinorUnit.HasValue)
            {
                settings["minorUnit"] = MinorUnit;
            }

            if (Mirror.HasValue)
            {
                settings["mirror"] = Mirror;
            }

            var ranges = Ranges.Select(i => i.Serialize());
            if (ranges.Any())
            {
                settings["ranges"] = ranges;
            }

            if (RangePlaceholderColor?.HasValue() == true)
            {
                settings["rangePlaceholderColor"] = RangePlaceholderColor;
            }

            if (RangeSize.HasValue)
            {
                settings["rangeSize"] = RangeSize;
            }

            if (Reverse.HasValue)
            {
                settings["reverse"] = Reverse;
            }

            if (Vertical.HasValue)
            {
                settings["vertical"] = Vertical;
            }

            return settings;
        }
    }
}
