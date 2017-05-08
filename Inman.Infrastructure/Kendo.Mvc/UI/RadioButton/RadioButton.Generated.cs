using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadioButton component
    /// </summary>
    public partial class RadioButton 
    {
        public bool? Checked { get; set; }

        public bool? Enabled { get; set; }

        public string Label { get; set; }

        public object Value { get; set; }
    }
}
