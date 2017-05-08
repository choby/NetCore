using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadioButton component
    /// </summary>
    public partial class RadioButton : WidgetBase, IWidget
    {
        public RadioButton(ViewContext viewContext) : base(viewContext)
        {
            Enabled = true;
        }

        public override void WriteInitializationScript(TextWriter writer) { }

        protected override void WriteHtml(TextWriter writer)
        {
            VerifySettings();

            var builder = GetHtmlBuilder();

            builder.WriteHtml(writer, HtmlEncoder);
        }

        protected virtual RadioButtonHtmlBuilder GetHtmlBuilder()
        {
            return new RadioButtonHtmlBuilder(this);
        }
    }
}

