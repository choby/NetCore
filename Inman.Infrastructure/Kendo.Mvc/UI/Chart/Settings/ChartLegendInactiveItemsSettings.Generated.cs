using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartLegendInactiveItemsSettings class
    /// </summary>
    public partial class ChartLegendInactiveItemsSettings<T> where T : class 
    {
        public ChartLegendInactiveItemsLabelsSettings<T> Labels { get; } = new ChartLegendInactiveItemsLabelsSettings<T>();


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var labels = Labels.Serialize();
            if (labels.Any())
            {
                settings["labels"] = labels;
            }

            return settings;
        }
    }
}
