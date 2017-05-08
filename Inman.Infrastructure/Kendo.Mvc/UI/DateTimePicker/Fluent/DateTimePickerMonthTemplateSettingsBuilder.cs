using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DateTimePickerMonthTemplateSettings
    /// </summary>
    public partial class DateTimePickerMonthTemplateSettingsBuilder
        
    {
        public DateTimePickerMonthTemplateSettingsBuilder(DateTimePickerMonthTemplateSettings container)
        {
            Container = container;
        }

        protected DateTimePickerMonthTemplateSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
