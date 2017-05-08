using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI CalendarMonthSettings class
    /// </summary>
    public partial class CalendarMonthSettings 
    {
        public string Content { get; set; }

        public string Empty { get; set; }


        public Calendar Calendar { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Content?.HasValue() == true)
            {
                settings["content"] = Content;
            }

            if (Empty?.HasValue() == true)
            {
                settings["empty"] = Empty;
            }

            return settings;
        }
    }
}
