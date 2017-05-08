using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeMap component
    /// </summary>
    public partial class TreeMap : WidgetBase
    {
        public TreeMap(ViewContext viewContext) : base(viewContext)
        {
            //this.UrlGenerator = urlGenerator;
            DataSource = new DataSource(ModelMetadataProvider);
            DataSource.ModelType(typeof(object));
        }
        
        public DataSource DataSource
        {
            get;
            private set;
        }
                
        public List<string[]> ColorRanges { get; set; } = new List<string[]>();

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (!string.IsNullOrEmpty(DataSource.Transport.Read.Url) || DataSource.Type == DataSourceType.Custom)
            {
                settings["dataSource"] = DataSource.ToJson();
            }
            else if (DataSource.Data != null)
            {
                settings["dataSource"] = DataSource.Data;
            }

            if ((Colors == null || Colors.Any() == false) && ColorRanges?.Any() == true)
            {
                settings["colors"] = ColorRanges;
            }

            writer.Write(Initializer.Initialize(Selector, "TreeMap", settings));
        }
    }
}

