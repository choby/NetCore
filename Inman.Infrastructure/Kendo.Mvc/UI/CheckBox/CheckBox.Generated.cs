using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI CheckBox component
    /// </summary>
    public partial class CheckBox 
    {
        public bool? Checked { get; set; }

        public bool? Enabled { get; set; }

        public string Label { get; set; }
    }
}
