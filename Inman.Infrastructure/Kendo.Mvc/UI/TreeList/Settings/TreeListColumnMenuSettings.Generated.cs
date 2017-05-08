using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListColumnMenuSettings class
    /// </summary>
    public partial class TreeListColumnMenuSettings<T> where T : class 
    {
        public bool? Columns { get; set; }

        public bool? Filterable { get; set; }

        public bool? Sortable { get; set; }

        public TreeListColumnMenuMessagesSettings<T> Messages { get; } = new TreeListColumnMenuMessagesSettings<T>();

        public bool? Enabled { get; set; }

        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Columns.HasValue)
            {
                settings["columns"] = Columns;
            }

            if (Filterable.HasValue)
            {
                settings["filterable"] = Filterable;
            }

            if (Sortable.HasValue)
            {
                settings["sortable"] = Sortable;
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
