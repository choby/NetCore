using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetToolbarSettings class
    /// </summary>
    public partial class SpreadsheetToolbarSettings 
    {
        public bool? Home { get; set; }

        public bool? Insert { get; set; }

        public bool? Data { get; set; }

        public bool? Enabled { get; set; }

        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Home.HasValue)
            {
                settings["home"] = Home;
            }

            if (Insert.HasValue)
            {
                settings["insert"] = Insert;
            }

            if (Data.HasValue)
            {
                settings["data"] = Data;
            }

            return settings;
        }
    }
}
