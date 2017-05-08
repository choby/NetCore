using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    public class LinearGaugePointerMarginSettings : ISpacing
    {
        public double? Top { get; set; }

        public double? Bottom { get; set; }

        public double? Left { get; set; }

        public double? Right { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (Top.HasValue)
            {
                settings["top"] = Top;
            }

            if (Bottom.HasValue)
            {
                settings["bottom"] = Bottom;
            }

            if (Left.HasValue)
            {
                settings["left"] = Left;
            }

            if (Right.HasValue)
            {
                settings["right"] = Right;
            }

            return settings;
        }
    }
}