using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SchedulerMessagesEditableSettings
    /// </summary>
    public partial class SchedulerMessagesEditableSettingsBuilder<T>
        where T : class, ISchedulerEvent 
    {
        /// <summary>
        /// The text similar to "Are you sure you want to delete this event?" displayed in scheduler.
        /// </summary>
        /// <param name="value">The value for Confirmation</param>
        public SchedulerMessagesEditableSettingsBuilder<T> Confirmation(string value)
        {
            Container.Confirmation = value;
            return this;
        }

    }
}
