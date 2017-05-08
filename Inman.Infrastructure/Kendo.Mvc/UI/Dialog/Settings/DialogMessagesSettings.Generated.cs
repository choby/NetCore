using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DialogMessagesSettings class
    /// </summary>
    public partial class DialogMessagesSettings 
    {
        public string Close { get; set; }


        public Dialog Dialog { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Close?.HasValue() == true)
            {
                settings["close"] = Close;
            }

            return settings;
        }
    }
}
