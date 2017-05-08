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
        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            if (ContentId.HasValue())
            {
                settings["content"] = new ClientHandlerDescriptor { HandlerName = string.Format("jQuery('{0}{1}').html()", Calendar.IdPrefix, ContentId) };
            }
            else if (Content.HasValue())
            {
                settings["content"] = Content;
            }

            if (EmptyId.HasValue())
            {
                settings["empty"] = new ClientHandlerDescriptor { HandlerName = string.Format("jQuery('{0}{1}').html()", Calendar.IdPrefix, EmptyId) };
            }
            else if (Empty.HasValue())
            {
                settings["empty"] = Empty;
            }

            return settings;
        }
    }
}
