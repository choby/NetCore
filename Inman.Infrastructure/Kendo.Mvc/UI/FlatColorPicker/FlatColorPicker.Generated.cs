using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI FlatColorPicker component
    /// </summary>
    public partial class FlatColorPicker 
    {
        public bool? Opacity { get; set; }

        public bool? Buttons { get; set; }

        public string Value { get; set; }

        public bool? Preview { get; set; }

        public bool? Autoupdate { get; set; }

        public FlatColorPickerMessagesSettings Messages { get; } = new FlatColorPickerMessagesSettings();


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Buttons.HasValue)
            {
                settings["buttons"] = Buttons;
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            if (Preview.HasValue)
            {
                settings["preview"] = Preview;
            }

            if (Autoupdate.HasValue)
            {
                settings["autoupdate"] = Autoupdate;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            return settings;
        }
    }
}
