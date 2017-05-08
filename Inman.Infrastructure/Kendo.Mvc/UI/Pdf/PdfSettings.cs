using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
	public class PdfSettings
    {
		public IDictionary<string, object> Margin { get; set; }

		public object PaperSize { get; set; }

		public virtual Dictionary<string, object> Serialize()
		{
			var settings = new Dictionary<string, object>();

			if (PaperSize != null)
			{
				settings["paperSize"] = PaperSize;
			}

			if (Margin != null && Margin.Any())
			{
				settings["margin"] = Margin;
			}

			return settings;
		}
	}
}