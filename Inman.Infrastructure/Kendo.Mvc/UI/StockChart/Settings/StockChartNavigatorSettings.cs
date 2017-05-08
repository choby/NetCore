using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorSettings class
    /// </summary>
    public partial class StockChartNavigatorSettings<T> where T : class
    {
        public List<ChartSeries<T>> Series { get; set; } = new List<ChartSeries<T>>();

        public DataSource DataSource { get; private set; }

        public ViewContext ViewContext { get; private set; }
        
        public IUrlGenerator UrlGenerator { get; private set; }
        
        public StockChartNavigatorSettings() { }

        public StockChartNavigatorSettings(StockChart<T> chart, ViewContext viewContext)
        {
            ViewContext = viewContext;
            UrlGenerator = chart.UrlGenerator;
            DataSource = new DataSource(chart.ModelMetadataProvider);
            DataSource.Schema.Data = "";
            DataSource.Schema.Total = "";
            DataSource.Schema.Errors = "";
            DataSource.ModelType(typeof(T));

            StockChart = chart;
        }
        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            // Do manual serialization here

            if (!string.IsNullOrEmpty(DataSource.Transport.Read.Url))
            {
                if (!DataSource.Transport.Read.Type.HasValue())
                {
                    DataSource.Transport.Read.Type = "POST";
                }

                settings["dataSource"] = DataSource.ToJson();
            }

            var series = Series.Select(i => i.Serialize());
            if (series.Any())
            {
                settings["series"] = series;
            }

            return settings;
        }
    }
}
