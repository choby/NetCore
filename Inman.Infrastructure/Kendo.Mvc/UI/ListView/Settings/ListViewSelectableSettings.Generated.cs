using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ListViewSelectableSettings class
    /// </summary>
    public partial class ListViewSelectableSettings<T> where T : class 
    {
        public ListViewSelectionMode? Mode { get; set; }

        public bool? Enabled { get; set; }

        public ListView<T> ListView { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            return settings;
        }
    }
}
