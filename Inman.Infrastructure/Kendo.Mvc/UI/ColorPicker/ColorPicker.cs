using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ColorPicker component
    /// </summary>
    public partial class ColorPicker : WidgetBase
        
    {
        public ColorPicker(ViewContext viewContext) : base(viewContext)
        {
			Enabled = true;
			Palette = ColorPickerPalette.None;
		}

		public IEnumerable<string> PaletteColors { get; set; }

		public bool Enabled { get; set;	}

		protected override void WriteHtml(TextWriter writer)
        {
			var explorer = ExpressionMetadataProvider.FromStringExpression(Name, HtmlHelper.ViewData, HtmlHelper.MetadataProvider);
			var tag = Generator.GenerateColorInput(ViewContext, explorer, Id, Name, Value, HtmlAttributes);

			if (String.IsNullOrEmpty(Value))
			{
				tag.Attributes.Remove("value");
			}

			if (Opacity.HasValue)
			{
				tag.Attributes.Remove("type");
			}

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

			if (Palette == ColorPickerPalette.None)
			{
				if (PaletteColors != null && PaletteColors.Any())
				{
					settings["palette"] = PaletteColors;
				}
				else
				{
					settings.Remove("palette");
				}
            }

            writer.Write(Initializer.Initialize(Selector, "ColorPicker", settings));
        }
    }
}

