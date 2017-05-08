using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ColorPalette component
    /// </summary>
    public partial class ColorPalette : WidgetBase
        
    {
        public ColorPalette(ViewContext viewContext) : base(viewContext)
        {
			Palette = ColorPickerPalette.Basic;

			Columns = ColumnsDefault;
		}

		public const int ColumnsDefault = 10;

		public IEnumerable<string> PaletteColors { get; set; }

		public ColorPickerPalette? Palette { get; set; }

		protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

			base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

			if (Columns == ColumnsDefault)
			{
				settings.Remove("columns");
			}

			if (Palette.HasValue)
			{
				settings["palette"] = Palette?.Serialize();

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
			}

			writer.Write(Initializer.Initialize(Selector, "ColorPalette", settings));
        }
    }
}

