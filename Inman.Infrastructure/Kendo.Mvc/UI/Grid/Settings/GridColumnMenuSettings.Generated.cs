using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridColumnMenuSettings class
    /// </summary>
    public partial class GridColumnMenuSettings<T> where T : class 
    {
        public bool? Columns { get; set; }

        public bool? Filterable { get; set; }

        public bool? Sortable { get; set; }

        public bool? Enabled { get; set; }

        public Grid<T> Grid { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Columns.HasValue)
            {
                settings["columns"] = Columns;
            }

            if (Filterable.HasValue)
            {
                settings["filterable"] = Filterable;
            }

            if (Sortable.HasValue)
            {
                settings["sortable"] = Sortable;
            }

            return settings;
        }
    }
}
