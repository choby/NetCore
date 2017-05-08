using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI CalendarMonthTemplateSettings class
    /// </summary>
    public partial class CalendarMonthTemplateSettings 
    {
        public string Empty { get; set; }

        public string EmptyId { get; set; }

        public string Content { get; set; }

        public string ContentId { get; set; }


        public Calendar Calendar { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            return settings;
        }
    }
}
