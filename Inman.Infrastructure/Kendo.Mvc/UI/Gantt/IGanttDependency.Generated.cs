using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI IGanttDependency interface
    /// </summary>
    public interface IGanttDependency
    {
        DependencyType Type { get; set; }
    }
}

