using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorCategoryAxisNotesSettings class
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisNotesSettings<T> where T : class 
    {
        public string Position { get; set; }

        public StockChartNavigatorCategoryAxisNotesIconSettings<T> Icon { get; } = new StockChartNavigatorCategoryAxisNotesIconSettings<T>();

        public StockChartNavigatorCategoryAxisNotesLabelSettings<T> Label { get; } = new StockChartNavigatorCategoryAxisNotesLabelSettings<T>();

        public StockChartNavigatorCategoryAxisNotesLineSettings<T> Line { get; } = new StockChartNavigatorCategoryAxisNotesLineSettings<T>();


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Position?.HasValue() == true)
            {
                settings["position"] = Position;
            }

            var icon = Icon.Serialize();
            if (icon.Any())
            {
                settings["icon"] = icon;
            }

            var label = Label.Serialize();
            if (label.Any())
            {
                settings["label"] = label;
            }

            var line = Line.Serialize();
            if (line.Any())
            {
                settings["line"] = line;
            }

            return settings;
        }
    }
}
