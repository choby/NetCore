using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Sparkline component
    /// </summary>
    public partial class Sparkline<T> : Chart<T>
        where T : class
    {
        public Sparkline(ViewContext viewContext) : base(viewContext)
        {
        }

        /// <summary>
        /// Gets or sets the default series data
        /// </summary>
        public IEnumerable SeriesData
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the default series type.
        /// The default value is SparklineType.Line.
        /// </summary>
        /// <value>
        /// The default series type.
        /// </value>
        public SparklineType? Type
        {
            get;
            set;
        }
        
        protected override TagBuilder GenerateTag(TextWriter writer)
        {
            var tag = Generator.GenerateTag("span", ViewContext, Id, Name, HtmlAttributes);
            tag.AddCssClass("k-sparkline");
            return tag;
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            // TODO: Manually serialized settings go here

            SerializeCustomSettings(settings);

            writer.Write(Initializer.Initialize(Selector, "Sparkline", settings));
        }

        protected override void SerializeCustomSettings(IDictionary<string, object> settings)
        {
            base.SerializeCustomSettings(settings);

            if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }
        }

        protected override void SerializeDataSource(IDictionary<string, object> settings)
        {
            if (SeriesData != null)
            {
                settings.Add("data", SeriesData);
            }
            else
            {
                base.SerializeDataSource(settings);
            }
        }
    }
}

