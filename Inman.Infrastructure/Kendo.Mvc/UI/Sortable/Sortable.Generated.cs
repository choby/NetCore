using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Sortable component
    /// </summary>
    public partial class Sortable 
    {
        public bool? AutoScroll { get; set; }

        public string ConnectWith { get; set; }

        public string Cursor { get; set; }

        public SortableCursorOffsetSettings CursorOffset { get; } = new SortableCursorOffsetSettings();

        public string Disabled { get; set; }

        public string Filter { get; set; }

        public string Handler { get; set; }

        public bool? HoldToDrag { get; set; }

        public string Ignore { get; set; }

        public SortableAxis? Axis { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoScroll.HasValue)
            {
                settings["autoScroll"] = AutoScroll;
            }

            var cursorOffset = CursorOffset.Serialize();
            if (cursorOffset.Any())
            {
                settings["cursorOffset"] = cursorOffset;
            }

            return settings;
        }
    }
}
