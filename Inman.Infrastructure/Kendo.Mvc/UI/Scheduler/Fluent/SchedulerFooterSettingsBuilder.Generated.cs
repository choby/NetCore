using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerFooterSettings
    /// </summary>
    public partial class SchedulerFooterSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// Sets the command which will be displayed in the scheduler footer. Currently only "workDay" option is supported. If the option is set to false, the "workDay" button will be removed from the footer.
        /// </summary>
        /// <param name="value">The value for Command</param>
        public SchedulerFooterSettingsBuilder<T> Command(string value)
        {
            Container.Command = value;
            return this;
        }

    }
}
