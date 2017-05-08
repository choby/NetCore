using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI PanelBarMessagesSettings class
    /// </summary>
    public partial class PanelBarMessagesSettings 
    {
        public string Loading { get; set; }

        public string RequestFailed { get; set; }

        public string Retry { get; set; }


        public PanelBar PanelBar { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Loading?.HasValue() == true)
            {
                settings["loading"] = Loading;
            }

            if (RequestFailed?.HasValue() == true)
            {
                settings["requestFailed"] = RequestFailed;
            }

            if (Retry?.HasValue() == true)
            {
                settings["retry"] = Retry;
            }

            return settings;
        }
    }
}
