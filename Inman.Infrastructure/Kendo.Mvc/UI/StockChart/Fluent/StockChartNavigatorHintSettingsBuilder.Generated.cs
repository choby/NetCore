using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorHintSettings
    /// </summary>
    public partial class StockChartNavigatorHintSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The visibility of the hint.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public StockChartNavigatorHintSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The hint template.
		/// Template variables:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public StockChartNavigatorHintSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The hint template.
		/// Template variables:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public StockChartNavigatorHintSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The format of the hint.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public StockChartNavigatorHintSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

    }
}
