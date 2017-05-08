using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ColorPickerMessagesSettings class
    /// </summary>
    public partial class ColorPickerMessagesSettings 
    {
        public string Apply { get; set; }

        public string Cancel { get; set; }


        public ColorPicker ColorPicker { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Apply?.HasValue() == true)
            {
                settings["apply"] = Apply;
            }

            if (Cancel?.HasValue() == true)
            {
                settings["cancel"] = Cancel;
            }

            return settings;
        }
    }
}
