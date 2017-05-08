using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridNoRecordsSettings
    /// </summary>
    public partial class GridNoRecordsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The template which is rendered when current view contains no records.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public GridNoRecordsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which is rendered when current view contains no records.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public GridNoRecordsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

    }
}
