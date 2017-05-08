using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListColumnSortableSettings class
    /// </summary>
    public partial class TreeListColumnSortableSettings<T> where T : class 
    {
        public ClientHandlerDescriptor Compare { get; set; }

        public bool? Enabled { get; set; }

        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Compare?.HasValue() == true)
            {
                settings["compare"] = Compare;
            }

            return settings;
        }
    }
}
