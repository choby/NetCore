using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI FlatColorPicker component
    /// </summary>
    public partial class FlatColorPicker : WidgetBase
        
    {
        public FlatColorPicker(ViewContext viewContext) : base(viewContext)
        {
			Enabled = true;
			Input = true;
			Buttons = false;
			Preview = true;
		}

		public bool Enabled { get; set; }

		public bool Input { get; set; }

		protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

			tag.AddCssClass("k-flatcolorpicker");

			if (!Enabled)
			{
				tag.MergeAttribute("disabled", "disabled");
			}

            tag.WriteTo(writer, HtmlEncoder);

			base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

			if (!Input)
			{
				settings["input"] = false;
			}

			writer.Write(Initializer.Initialize(Selector, "FlatColorPicker", settings));
        }
    }
}

