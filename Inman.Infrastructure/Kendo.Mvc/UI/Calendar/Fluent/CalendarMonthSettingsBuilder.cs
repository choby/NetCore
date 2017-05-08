using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring CalendarMonthSettings
    /// </summary>
    public partial class CalendarMonthSettingsBuilder
        
    {
        public CalendarMonthSettingsBuilder(CalendarMonthSettings container)
        {
            Container = container;
        }

        protected CalendarMonthSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
