using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridSortableSettings class
    /// </summary>
    public partial class GridSortableSettings<T> 
    {
        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

			if (SortMode.HasValue)
			{
				settings["mode"] = SortMode?.Serialize();
			}

            return settings;
        }
    }
}
