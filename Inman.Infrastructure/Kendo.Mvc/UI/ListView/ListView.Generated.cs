using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ListView component
    /// </summary>
    public partial class ListView<T> where T : class 
    {
        public bool? AutoBind { get; set; }

        public bool? Navigatable { get; set; }

        public string TagName { get; set; }

        public ListViewSelectableSettings<T> Selectable { get; } = new ListViewSelectableSettings<T>();


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (Navigatable.HasValue)
            {
                settings["navigatable"] = Navigatable;
            }

            if (TagName?.HasValue() == true)
            {
                settings["tagName"] = TagName;
            }


            return settings;
        }
    }
}
