using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SplitterPane class
    /// </summary>
    public partial class SplitterPane 
    {
        public bool? Collapsed { get; set; }

        public string CollapsedSize { get; set; }

        public bool? Collapsible { get; set; }

        public bool? Resizable { get; set; }

        public bool? Scrollable { get; set; }

        public string Size { get; set; }


        public Splitter Splitter { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Collapsed.HasValue)
            {
                settings["collapsed"] = Collapsed;
            }

            if (CollapsedSize?.HasValue() == true)
            {
                settings["collapsedSize"] = CollapsedSize;
            }

            if (Collapsible.HasValue)
            {
                settings["collapsible"] = Collapsible;
            }

            if (Resizable.HasValue)
            {
                settings["resizable"] = Resizable;
            }

            if (Scrollable.HasValue)
            {
                settings["scrollable"] = Scrollable;
            }

            if (Size?.HasValue() == true)
            {
                settings["size"] = Size;
            }

            return settings;
        }
    }
}
