using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DateTimePickerMonthTemplateSettings class
    /// </summary>
    public partial class DateTimePickerMonthTemplateSettings 
    {
        public string Empty { get; set; }

        public string EmptyId { get; set; }

        public string Content { get; set; }

        public string ContentId { get; set; }


        public DateTimePicker DateTimePicker { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            return settings;
        }
    }
}
