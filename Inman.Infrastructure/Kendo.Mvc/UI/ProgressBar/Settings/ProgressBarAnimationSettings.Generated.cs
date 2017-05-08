using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ProgressBarAnimationSettings class
    /// </summary>
    public partial class ProgressBarAnimationSettings 
    {
        public double? Duration { get; set; }


        public ProgressBar ProgressBar { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Duration.HasValue)
            {
                settings["duration"] = Duration;
            }

            return settings;
        }
    }
}
