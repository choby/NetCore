using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring CalendarMonthTemplateSettings
    /// </summary>
    public partial class CalendarMonthTemplateSettingsBuilder
        
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Empty</param>
        public CalendarMonthTemplateSettingsBuilder Empty(string value)
        {
            Container.Empty = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for EmptyId</param>
        public CalendarMonthTemplateSettingsBuilder EmptyId(string value)
        {
            Container.EmptyId = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Content</param>
        public CalendarMonthTemplateSettingsBuilder Content(string value)
        {
            Container.Content = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for ContentId</param>
        public CalendarMonthTemplateSettingsBuilder ContentId(string value)
        {
            Container.ContentId = value;
            return this;
        }

    }
}
