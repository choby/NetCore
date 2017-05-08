using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartCategoryAxisLabelsDateFormatsSettings class
    /// </summary>
    public partial class ChartCategoryAxisLabelsDateFormatsSettings<T> where T : class 
    {
        public string Days { get; set; }

        public string Hours { get; set; }

        public string Months { get; set; }

        public string Weeks { get; set; }

        public string Years { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Days?.HasValue() == true)
            {
                settings["days"] = Days;
            }

            if (Hours?.HasValue() == true)
            {
                settings["hours"] = Hours;
            }

            if (Months?.HasValue() == true)
            {
                settings["months"] = Months;
            }

            if (Weeks?.HasValue() == true)
            {
                settings["weeks"] = Weeks;
            }

            if (Years?.HasValue() == true)
            {
                settings["years"] = Years;
            }

            return settings;
        }
    }
}
