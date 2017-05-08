using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettings class
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettings<T> where T : class 
    {
        public int[] Seconds { get; set; }

        public int[] Minutes { get; set; }

        public int[] Hours { get; set; }

        public int[] Days { get; set; }

        public int[] Weeks { get; set; }

        public int[] Months { get; set; }

        public int[] Years { get; set; }


        public StockChart<T> StockChart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Seconds?.Any() == true)
            {
                settings["seconds"] = Seconds;
            }

            if (Minutes?.Any() == true)
            {
                settings["minutes"] = Minutes;
            }

            if (Hours?.Any() == true)
            {
                settings["hours"] = Hours;
            }

            if (Days?.Any() == true)
            {
                settings["days"] = Days;
            }

            if (Weeks?.Any() == true)
            {
                settings["weeks"] = Weeks;
            }

            if (Months?.Any() == true)
            {
                settings["months"] = Months;
            }

            if (Years?.Any() == true)
            {
                settings["years"] = Years;
            }

            return settings;
        }
    }
}
