using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridExcelSettings class
    /// </summary>
    public partial class GridExcelSettings<T> where T : class 
    {
        public bool? AllPages { get; set; }

        public string FileName { get; set; }

        public bool? Filterable { get; set; }

        public bool? ForceProxy { get; set; }

        public string ProxyURL { get; set; }


        public Grid<T> Grid { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AllPages.HasValue)
            {
                settings["allPages"] = AllPages;
            }

            if (FileName?.HasValue() == true)
            {
                settings["fileName"] = FileName;
            }

            if (Filterable.HasValue)
            {
                settings["filterable"] = Filterable;
            }

            if (ForceProxy.HasValue)
            {
                settings["forceProxy"] = ForceProxy;
            }

            if (ProxyURL?.HasValue() == true)
            {
                settings["proxyURL"] = ProxyURL;
            }

            return settings;
        }
    }
}
