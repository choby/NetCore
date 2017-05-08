using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorPasteCleanupSettings class
    /// </summary>
    public partial class EditorPasteCleanupSettings 
    {
        public bool? All { get; set; }

        public bool? Css { get; set; }

        public ClientHandlerDescriptor Custom { get; set; }

        public bool? KeepNewLines { get; set; }

        public bool? MsAllFormatting { get; set; }

        public bool? MsConvertLists { get; set; }

        public bool? MsTags { get; set; }

        public bool? None { get; set; }

        public bool? Span { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (All.HasValue)
            {
                settings["all"] = All;
            }

            if (Css.HasValue)
            {
                settings["css"] = Css;
            }

            if (Custom?.HasValue() == true)
            {
                settings["custom"] = Custom;
            }

            if (KeepNewLines.HasValue)
            {
                settings["keepNewLines"] = KeepNewLines;
            }

            if (MsAllFormatting.HasValue)
            {
                settings["msAllFormatting"] = MsAllFormatting;
            }

            if (MsConvertLists.HasValue)
            {
                settings["msConvertLists"] = MsConvertLists;
            }

            if (MsTags.HasValue)
            {
                settings["msTags"] = MsTags;
            }

            if (None.HasValue)
            {
                settings["none"] = None;
            }

            if (Span.HasValue)
            {
                settings["span"] = Span;
            }

            return settings;
        }
    }
}
