namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerPdfSettings
    /// </summary>
    public partial class SchedulerPdfSettingsBuilder<T> : PdfSettingsBuilder<SchedulerPdfSettingsBuilder<T>>
        where T : class, ISchedulerEvent 
    {
        public SchedulerPdfSettingsBuilder(SchedulerPdfSettings<T> container) : base (container)
        {
            Container = container;
        }

        protected SchedulerPdfSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
