using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListSelectableSettings class
    /// </summary>
    public partial class TreeListSelectableSettings<T> where T : class 
    {
        public TreeListSelectionMode? Mode { get; set; }

        public TreeListSelectionType? Type { get; set; }

        public bool? Enabled { get; set; }

        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            return settings;
        }
    }
}
