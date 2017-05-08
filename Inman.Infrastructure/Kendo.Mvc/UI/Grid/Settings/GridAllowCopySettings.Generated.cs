using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridAllowCopySettings class
    /// </summary>
    public partial class GridAllowCopySettings<T> where T : class 
    {
        public string Delimeter { get; set; }

        public bool? Enabled { get; set; }

        public Grid<T> Grid { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Delimeter?.HasValue() == true)
            {
                settings["delimeter"] = Delimeter;
            }

            return settings;
        }
    }
}
