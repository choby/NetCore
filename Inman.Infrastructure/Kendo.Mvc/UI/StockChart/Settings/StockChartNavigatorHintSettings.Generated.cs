using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorHintSettings class
    /// </summary>
    public partial class StockChartNavigatorHintSettings<T> where T : class 
    {
        public bool? Visible { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public string Format { get; set; }


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", StockChart.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
            }

            return settings;
        }
    }
}
