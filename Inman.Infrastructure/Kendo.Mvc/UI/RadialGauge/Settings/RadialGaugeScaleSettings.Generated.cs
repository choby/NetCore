using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGaugeScaleSettings class
    /// </summary>
    public partial class RadialGaugeScaleSettings 
    {
        public double? EndAngle { get; set; }

        public RadialGaugeScaleLabelsSettings Labels { get; } = new RadialGaugeScaleLabelsSettings();

        public RadialGaugeScaleMajorTicksSettings MajorTicks { get; } = new RadialGaugeScaleMajorTicksSettings();

        public double? MajorUnit { get; set; }

        public double? Max { get; set; }

        public double? Min { get; set; }

        public RadialGaugeScaleMinorTicksSettings MinorTicks { get; } = new RadialGaugeScaleMinorTicksSettings();

        public double? MinorUnit { get; set; }

        public List<RadialGaugeScaleSettingsRange> Ranges { get; set; } = new List<RadialGaugeScaleSettingsRange>();

        public string RangePlaceholderColor { get; set; }

        public double? RangeSize { get; set; }

        public double? RangeDistance { get; set; }

        public bool? Reverse { get; set; }

        public double? StartAngle { get; set; }


        public RadialGauge RadialGauge { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (EndAngle.HasValue)
            {
                settings["endAngle"] = EndAngle;
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

            if (RangeDistance.HasValue)
            {
                settings["rangeDistance"] = RangeDistance;
            }

            if (Reverse.HasValue)
            {
                settings["reverse"] = Reverse;
            }

            if (StartAngle.HasValue)
            {
                settings["startAngle"] = StartAngle;
            }

            return settings;
        }
    }
}
