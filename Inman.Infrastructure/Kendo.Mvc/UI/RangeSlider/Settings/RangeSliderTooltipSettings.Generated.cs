using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RangeSliderTooltipSettings class
    /// </summary>
    public partial class RangeSliderTooltipSettings<T> where T : struct, IComparable 
    {
        public bool? Enabled { get; set; }

        public string Format { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }


        public RangeSlider<T> RangeSlider { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Enabled.HasValue)
            {
                settings["enabled"] = Enabled;
            }

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", RangeSlider.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            return settings;
        }
    }
}
