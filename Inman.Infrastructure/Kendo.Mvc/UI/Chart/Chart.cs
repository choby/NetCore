using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Chart component
    /// </summary>
    public partial class Chart<T> : WidgetBase
        where T : class
    {
        public ChartSeriesDefaultsSettings<T> SeriesDefaults { get; } = new ChartSeriesDefaultsSettings<T>();

        public Chart(ViewContext viewContext) : base(viewContext)
        {
            DataSource = new DataSource(ModelMetadataProvider);
            DataSource.Schema.Data = "";
            DataSource.Schema.Total = "";
            DataSource.Schema.Errors = "";
            DataSource.ModelType(typeof(T));
        }

        /// <summary>
        /// The Chart data source configuration
        /// </summary>
        public DataSource DataSource
        {
            get;
            private set;
        }

        public string DataSourceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        /// <value>The data source.</value>
        public IEnumerable<T> Data
        {
            get;
            set;
        }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = GenerateTag(writer);
            tag.WriteTo(writer, HtmlEncoder);
            base.WriteHtml(writer);
        }

        protected virtual TagBuilder GenerateTag(TextWriter writer)
        {
            return Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();
            
            // TODO: Manually serialized settings go here

            SerializeCustomSettings(settings);

            writer.Write(Initializer.Initialize(Selector, "Chart", settings));
        }

        protected virtual void SerializeCustomSettings(IDictionary<string, object> settings)
        {
            if (DataSourceId.HasValue())
            {
                settings["dataSourceId"] = DataSourceId;
            }
            else
            {
                SerializeDataSource(settings);
            }

            var seriesDefaults = SeriesDefaults.Serialize();
            if (seriesDefaults.Any())
            {
                settings["seriesDefaults"] = seriesDefaults;
            }
        }

        protected virtual void SerializeDataSource(IDictionary<string, object> settings)
        {
            if (DataSource.Type == DataSourceType.Custom)
            {
                settings["dataSource"] = DataSource.ToJson();
            }
            else if (!string.IsNullOrEmpty(DataSource.Transport.Read.Url))
            {
                if (!DataSource.Transport.Read.Type.HasValue())
                {
                    DataSource.Transport.Read.Type = "POST";
                }

                if (DataSource.Type == null)
                {
                    DataSource.Type = DataSourceType.Ajax;
                }

                settings["dataSource"] = DataSource.ToJson();
            }
            else if (Data != null)
            {
                IDictionary<string, object> result = DataSource.ToJson();
                result["data"] = Data;
                result.Remove("transport");
                settings["dataSource"] = result;
            }
        }
    }
}

