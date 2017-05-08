using Kendo.Mvc.Extensions;
using System;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI IGanttTask interface
    /// </summary>
    public interface IGanttTask
    {
        string Title { get; set; }
        DateTime Start { get; set; }
        DateTime End { get; set; }
        decimal PercentComplete { get; set; }
        int OrderId { get; set; }
        bool Summary { get; set; }
        bool Expanded { get; set; }
    }
}

