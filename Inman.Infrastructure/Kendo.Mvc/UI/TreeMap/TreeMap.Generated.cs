using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeMap component
    /// </summary>
    public partial class TreeMap 
    {
        public bool? AutoBind { get; set; }

        public string Theme { get; set; }

        public string ValueField { get; set; }

        public string ColorField { get; set; }

        public string TextField { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public String[] Colors { get; set; }

        public TreeMapType? Type { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (Theme?.HasValue() == true)
            {
                settings["theme"] = Theme;
            }

            if (ValueField?.HasValue() == true)
            {
                settings["valueField"] = ValueField;
            }

            if (ColorField?.HasValue() == true)
            {
                settings["colorField"] = ColorField;
            }

            if (TextField?.HasValue() == true)
            {
                settings["textField"] = TextField;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (Colors?.Any() == true)
            {
                settings["colors"] = Colors;
            }

            if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }

            return settings;
        }
    }
}
