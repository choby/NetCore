
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{	
	public abstract class PdfSettingsBuilder<TBuilder>  where TBuilder : PdfSettingsBuilder<TBuilder>
	{
		private readonly PdfSettings pdf;

		public PdfSettingsBuilder(PdfSettings pdf)
		{
			this.pdf = pdf;
		}

		/// <summary>
		/// Specifies a predefiend paper size e.g. "A3", "A4" or "auto" (default).
		/// </summary>
		public TBuilder PaperSize(string paperSize)
		{
			pdf.PaperSize = paperSize;

			return (TBuilder)this;
		}

		/// <summary>
		/// Specifies custom paper size in "pt" units.
		/// </summary>
		public TBuilder PaperSize(double width, double height)
		{
			pdf.PaperSize = new[] { width, height };
			return (TBuilder)this;
		}

		/// <summary>
		/// Specifies custom paper size in custom units ("in", "mm", "pt", "cm")
		/// </summary>
		public TBuilder PaperSize(string width, string height)
		{
			pdf.PaperSize = new[] { width, height };
			return (TBuilder)this;
		}

		/// <summary>
		/// Specifies the margins in "pt" units.
		/// </summary>
		public TBuilder Margin(double top, double right, double bottom, double left)
		{
			pdf.Margin = new Dictionary<string, object>
			{
			   { "top", top },
			   { "right", right },
			   { "bottom", bottom },
			   { "left", left }
			};

			return (TBuilder)this;
		}

		/// <summary>
		/// Specifies the margins in units ("in", "mm", "pt", "cm")
		/// </summary>
		public TBuilder Margin(string top, string right, string bottom, string left)
		{
			pdf.Margin = new Dictionary<string, object>
			{
			   { "top", top },
			   { "right", right },
			   { "bottom", bottom },
			   { "left", left }
			};

			return (TBuilder)this;
		}
	}
}