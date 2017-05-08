using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MultiSelect component
    /// </summary>
    public partial class MultiSelect : WidgetBase

    {
        private static readonly Regex EscapeRegex = new Regex(@"([;&,\.\+\*~'\:\""\!\^\$\[\]\(\)\|\/])", RegexOptions.Compiled);

        public DataSource DataSource
        {
            get;
            private set;
        }

        public PopupAnimation Animation { get; private set; }

        public IEnumerable Value
        {
            get;
            set;
        }

        public MultiSelect(ViewContext viewContext) : base(viewContext)
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

            var tag = Generator.GenerateMultiSelect(ViewContext, null, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            if (DataSource.ServerFiltering && !DataSource.Transport.Read.Data.HasValue())
            {
                DataSource.Transport.Read.Data = new ClientHandlerDescriptor
                {
                    HandlerName = "function() { return kendo.ui.MultiSelect.requestData(jQuery(\"" + EscapeRegex.Replace(Selector, @"\\$1") + "\")); }"
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

            var value = GetValue();
            if (value != null)
            {
                settings["value"] = value;
            }

            writer.Write(Initializer.Initialize(Selector, "MultiSelect", settings));
        }

        private IEnumerable GetValue()
        {
            ModelStateEntry modelState;
            if (ViewContext.ViewData.ModelState.TryGetValue(Name, out modelState) && modelState.RawValue != null)
            {
                return modelState.RawValue as IEnumerable;
            }
            else if (Value == null)
            {
                return ViewContext.ViewData.Eval(Name) as IEnumerable;
            }

            return Value;
        }
    }
}

