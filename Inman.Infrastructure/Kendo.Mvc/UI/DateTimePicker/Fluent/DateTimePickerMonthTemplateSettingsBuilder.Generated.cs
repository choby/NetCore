using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DateTimePickerMonthTemplateSettings
    /// </summary>
    public partial class DateTimePickerMonthTemplateSettingsBuilder
        
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Empty</param>
        public DateTimePickerMonthTemplateSettingsBuilder Empty(string value)
        {
            Container.Empty = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for EmptyId</param>
        public DateTimePickerMonthTemplateSettingsBuilder EmptyId(string value)
        {
            Container.EmptyId = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Content</param>
        public DateTimePickerMonthTemplateSettingsBuilder Content(string value)
        {
            Container.Content = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for ContentId</param>
        public DateTimePickerMonthTemplateSettingsBuilder ContentId(string value)
        {
            Container.ContentId = value;
            return this;
        }

    }
}
