using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapMarkerDefaultsSettings class
    /// </summary>
    public interface IMapMarkersShapeSettings
    {
        MapMarkersShape? Shape { get; set; }

        string ShapeName { get; set; }
    }
}
