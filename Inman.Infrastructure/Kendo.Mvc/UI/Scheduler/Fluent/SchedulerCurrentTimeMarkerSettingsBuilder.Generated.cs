using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerCurrentTimeMarkerSettings
    /// </summary>
    public partial class SchedulerCurrentTimeMarkerSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The update interval of the "current time" marker, in milliseconds.
        /// </summary>
        /// <param name="value">The value for UpdateInterval</param>
        public SchedulerCurrentTimeMarkerSettingsBuilder<T> UpdateInterval(double value)
        {
            Container.UpdateInterval = value;
            return this;
        }

        /// <summary>
        /// If set to false the "current time" marker would be displayed using the scheduler timezone.
        /// </summary>
        /// <param name="value">The value for UseLocalTimezone</param>
        public SchedulerCurrentTimeMarkerSettingsBuilder<T> UseLocalTimezone(bool value)
        {
            Container.UseLocalTimezone = value;
            return this;
        }

    }
}
