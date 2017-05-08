using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring CalendarMonthTemplateSettings
    /// </summary>
    public partial class CalendarMonthTemplateSettingsBuilder
        
    {
        public CalendarMonthTemplateSettingsBuilder(CalendarMonthTemplateSettings container)
        {
            Container = container;
        }

        protected CalendarMonthTemplateSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
