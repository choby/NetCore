using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesEditorSettings
    /// </summary>
    public partial class SchedulerMessagesEditorSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        public SchedulerMessagesEditorSettingsBuilder(SchedulerMessagesEditorSettings<T> container)
        {
            Container = container;
        }

        protected SchedulerMessagesEditorSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
