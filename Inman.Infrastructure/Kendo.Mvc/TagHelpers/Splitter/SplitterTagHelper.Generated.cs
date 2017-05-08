using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Linq;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
    public partial class SplitterTagHelper
    {
        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            return settings;
        }
    }
}
