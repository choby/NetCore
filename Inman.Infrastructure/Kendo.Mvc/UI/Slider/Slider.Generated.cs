using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Slider component
    /// </summary>
    public partial class Slider<T> where T : struct, IComparable 
    {
        public string DecreaseButtonTitle { get; set; }

        public string DragHandleTitle { get; set; }

        public string IncreaseButtonTitle { get; set; }

        public T? LargeStep { get; set; }

        public T? Max { get; set; }

        public T? Min { get; set; }

        public bool? ShowButtons { get; set; }

        public T? SmallStep { get; set; }

        public SliderTooltipSettings<T> Tooltip { get; } = new SliderTooltipSettings<T>();

        public T? Value { get; set; }

        public SliderOrientation? Orientation { get; set; }

        public SliderTickPlacement? TickPlacement { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (DecreaseButtonTitle?.HasValue() == true)
            {
                settings["decreaseButtonTitle"] = DecreaseButtonTitle;
            }

            if (DragHandleTitle?.HasValue() == true)
            {
                settings["dragHandleTitle"] = DragHandleTitle;
            }

            if (IncreaseButtonTitle?.HasValue() == true)
            {
                settings["increaseButtonTitle"] = IncreaseButtonTitle;
            }

            if (LargeStep.HasValue)
            {
                settings["largeStep"] = LargeStep;
            }

            if (Max.HasValue)
            {
                settings["max"] = Max;
            }

            if (Min.HasValue)
            {
                settings["min"] = Min;
            }

            if (ShowButtons.HasValue)
            {
                settings["showButtons"] = ShowButtons;
            }

            if (SmallStep.HasValue)
            {
                settings["smallStep"] = SmallStep;
            }

            var tooltip = Tooltip.Serialize();
            if (tooltip.Any())
            {
                settings["tooltip"] = tooltip;
            }

            if (Value.HasValue)
            {
                settings["value"] = Value;
            }

            if (Orientation.HasValue)
            {
                settings["orientation"] = Orientation?.Serialize();
            }

            if (TickPlacement.HasValue)
            {
                settings["tickPlacement"] = TickPlacement?.Serialize();
            }

            return settings;
        }
    }
}
