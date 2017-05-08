using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListFilterableSettings class
    /// </summary>
    public partial class TreeListFilterableSettings<T> where T : class 
    {
        public bool? Extra { get; set; }

        public TreeListFilterableMessagesSettings<T> Messages { get; } = new TreeListFilterableMessagesSettings<T>();

        public bool? Enabled { get; set; }

        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Extra.HasValue)
            {
                settings["extra"] = Extra;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            return settings;
        }
    }
}
