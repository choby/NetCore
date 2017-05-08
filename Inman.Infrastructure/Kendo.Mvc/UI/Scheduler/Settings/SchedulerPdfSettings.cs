namespace Kendo.Mvc.UI
{
    using Kendo.Mvc.Extensions;
    using System.Collections.Generic;

    /// <summary>
    /// Kendo UI SchedulerPdfSettings class
    /// </summary>
    public partial class SchedulerPdfSettings<T> : PdfSettings
        where T : class, ISchedulerEvent
    {
        public override Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            settings.Merge(base.Serialize());

            return settings;
        }
    }
}
