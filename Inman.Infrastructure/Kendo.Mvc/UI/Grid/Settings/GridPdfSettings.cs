using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridPdfSettings class
    /// </summary>
    public partial class GridPdfSettings<T> : PdfSettings
    {
        public override Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

			settings.Merge(base.Serialize());            

            return settings;
        }
    }
}
