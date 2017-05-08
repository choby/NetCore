using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI CheckBox component
    /// </summary>
    public partial class CheckBox : WidgetBase

    {
        public CheckBox(ViewContext viewContext) : base(viewContext)
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
        
        protected virtual CheckBoxHtmlBuilder GetHtmlBuilder()
        {
            return new CheckBoxHtmlBuilder(this);
        }
    }
}