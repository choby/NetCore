using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI NotificationPositionSettings class
    /// </summary>
    public partial class NotificationPositionSettings 
    {
        public double? Bottom { get; set; }

        public double? Left { get; set; }

        public bool? Pinned { get; set; }

        public double? Right { get; set; }

        public double? Top { get; set; }


        public Notification Notification { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Bottom.HasValue)
            {
                settings["bottom"] = Bottom;
            }

            if (Left.HasValue)
            {
                settings["left"] = Left;
            }

            if (Pinned.HasValue)
            {
                settings["pinned"] = Pinned;
            }

            if (Right.HasValue)
            {
                settings["right"] = Right;
            }

            if (Top.HasValue)
            {
                settings["top"] = Top;
            }

            return settings;
        }
    }
}
