using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DropDownList component
    /// </summary>
    public partial class DropDownList : WidgetBase
    {
        private static readonly Regex EscapeRegex = new Regex(@"([;&,\.\+\*~'\:\""\!\^\$\[\]\(\)\|\/])", RegexOptions.Compiled);

        public DataSource DataSource
        {
            get;
            private set;
        }

        public int? SelectedIndex { get; set; }

        public PopupAnimation Animation { get; private set; }

        public DropDownList(ViewContext viewContext) : base(viewContext)
        {
            DataSource = new DataSource(ModelMetadataProvider);

            Animation = new PopupAnimation();
        }

        protected override void WriteHtml(TextWriter writer)
        {
            if (Enable == false)
            {
                HtmlAttributes.Merge("disabled", "disabled", true);
            }

            var tag = Generator.GenerateTextInput(ViewContext, null, Id, Name, Value, string.Empty, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            if (DataSource.ServerFiltering && !DataSource.Transport.Read.Data.HasValue() &&
                DataSource.Type != DataSourceType.Custom && DataSource.Type != DataSourceType.Ajax)
            {
                DataSource.Transport.Read.Data = new ClientHandlerDescriptor
                {
                    HandlerName = "function() { return kendo.ui.DropDownList.requestData(jQuery(\"" + EscapeRegex.Replace(Selector, @"\\$1") + "\")); }"
                };
            }

            var settings = SerializeSettings();

            var animation = Animation.ToJson();
            if (animation.Keys.Any())
            {
                settings["animation"] = animation["animation"];
            }

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

            if (SelectedIndex.HasValue && SelectedIndex > -1)
            {
                settings["index"] = SelectedIndex;
            }

            writer.Write(Initializer.Initialize(Selector, "DropDownList", settings));
        }
    }
}

