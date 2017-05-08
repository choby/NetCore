using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DatePickerMonthTemplateSettings
    /// </summary>
    public partial class DatePickerMonthTemplateSettingsBuilder
        
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Empty</param>
        public DatePickerMonthTemplateSettingsBuilder Empty(string value)
        {
            Container.Empty = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for EmptyId</param>
        public DatePickerMonthTemplateSettingsBuilder EmptyId(string value)
        {
            Container.EmptyId = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Content</param>
        public DatePickerMonthTemplateSettingsBuilder Content(string value)
        {
            Container.Content = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for ContentId</param>
        public DatePickerMonthTemplateSettingsBuilder ContentId(string value)
        {
            Container.ContentId = value;
            return this;
        }

    }
}
