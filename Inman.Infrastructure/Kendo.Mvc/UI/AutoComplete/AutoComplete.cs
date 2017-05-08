using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI AutoComplete component
    /// </summary>
    public partial class AutoComplete : WidgetBase
        
    {
        public AutoComplete(ViewContext viewContext) : base(viewContext)
        {
            DataSource = new DataSource(ModelMetadataProvider);
        }

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

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("input", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (DataSourceId.HasValue())
            {
                settings["dataSourceId"] = DataSourceId;
            }
            else
            {
                if (!string.IsNullOrEmpty(DataSource.Transport.Read.Url) ||
                    !string.IsNullOrEmpty(DataSource.Transport.Read.ActionName) ||
                    DataSource.Type == DataSourceType.Custom)
                {
                    settings["dataSource"] = DataSource.ToJson();
                }
                else if (DataSource.Data != null)
                {
                    settings["dataSource"] = DataSource.Data;
                }
            }

            writer.Write(Initializer.Initialize(Selector, "AutoComplete", settings));
        }
    }
}

