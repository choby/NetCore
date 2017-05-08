using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI UploadAsyncSettings class
    /// </summary>
    public partial class UploadAsyncSettings
    {
		/// <summary>
		/// Defines the Save action
		/// </summary>
		public INavigatable Save { get; } = new RequestSettings();

		/// <summary>
		/// Defines the Remove action
		/// </summary>
		public INavigatable Remove { get; } = new RequestSettings();

		public ViewContext ViewContext { get; set; }

		public Func<string, string> UrlDecoder { get; set; }

		public IUrlGenerator UrlGenerator { get; set; }

		public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

			if (Save.HasValue())
			{
				settings["saveUrl"] = UrlDecoder(Save.GenerateUrl(ViewContext, UrlGenerator));

				if (Remove.HasValue())
				{
					settings["removeUrl"] = UrlDecoder(Remove.GenerateUrl(ViewContext, UrlGenerator));
				}
			}

            return settings;
        }
    }
}
