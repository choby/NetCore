using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MultiSelectPopupSettings class
    /// </summary>
    public partial class MultiSelectPopupSettings 
    {
        public string AppendTo { get; set; }

        public string Origin { get; set; }

        public string Position { get; set; }


        public MultiSelect MultiSelect { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AppendTo?.HasValue() == true)
            {
                settings["appendTo"] = AppendTo;
            }

            if (Origin?.HasValue() == true)
            {
                settings["origin"] = Origin;
            }

            if (Position?.HasValue() == true)
            {
                settings["position"] = Position;
            }

            return settings;
        }
    }
}
