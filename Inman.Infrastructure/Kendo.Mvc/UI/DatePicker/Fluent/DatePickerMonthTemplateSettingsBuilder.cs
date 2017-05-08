using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DatePickerMonthTemplateSettings
    /// </summary>
    public partial class DatePickerMonthTemplateSettingsBuilder
        
    {
        public DatePickerMonthTemplateSettingsBuilder(DatePickerMonthTemplateSettings container)
        {
            Container = container;
        }

        protected DatePickerMonthTemplateSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
