using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListColumnFilterableSettings class
    /// </summary>
    public partial class TreeListColumnFilterableSettings<T> where T : class 
    {
        public string Ui { get; set; }

        public bool? Enabled { get; set; }

        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Ui?.HasValue() == true)
            {
                settings["ui"] = Ui;
            }

            return settings;
        }
    }
}
