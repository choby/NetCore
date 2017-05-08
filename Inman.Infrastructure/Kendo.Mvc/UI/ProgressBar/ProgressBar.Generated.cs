using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ProgressBar component
    /// </summary>
    public partial class ProgressBar 
    {
        public ProgressBarAnimationSettings Animation { get; } = new ProgressBarAnimationSettings();

        public double? ChunkCount { get; set; }

        public bool? Enable { get; set; }

        public double? Max { get; set; }

        public double? Min { get; set; }

        public bool? Reverse { get; set; }

        public bool? ShowStatus { get; set; }

        public ProgressBarOrientation? Orientation { get; set; }

        public ProgressBarType? Type { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var animation = Animation.Serialize();
            if (animation.Any())
            {
                settings["animation"] = animation;
            }

            if (ChunkCount.HasValue)
            {
                settings["chunkCount"] = ChunkCount;
            }

            if (Enable.HasValue)
            {
                settings["enable"] = Enable;
            }

            if (Max.HasValue)
            {
                settings["max"] = Max;
            }

            if (Min.HasValue)
            {
                settings["min"] = Min;
            }

            if (Reverse.HasValue)
            {
                settings["reverse"] = Reverse;
            }

            if (ShowStatus.HasValue)
            {
                settings["showStatus"] = ShowStatus;
            }

            if (Orientation.HasValue)
            {
                settings["orientation"] = Orientation?.Serialize();
            }

            if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }

            return settings;
        }
    }
}
