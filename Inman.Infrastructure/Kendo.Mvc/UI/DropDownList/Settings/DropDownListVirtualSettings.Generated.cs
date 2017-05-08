using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DropDownListVirtualSettings class
    /// </summary>
    public partial class DropDownListVirtualSettings 
    {
        public double? ItemHeight { get; set; }

        public string MapValueTo { get; set; }

        public ClientHandlerDescriptor ValueMapper { get; set; }

        public bool? Enabled { get; set; }

        public DropDownList DropDownList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (ItemHeight.HasValue)
            {
                settings["itemHeight"] = ItemHeight;
            }

            if (MapValueTo?.HasValue() == true)
            {
                settings["mapValueTo"] = MapValueTo;
            }

            if (ValueMapper?.HasValue() == true)
            {
                settings["valueMapper"] = ValueMapper;
            }

            return settings;
        }
    }
}
