using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RangeSliderTooltipSettings
    /// </summary>
    public partial class RangeSliderTooltipSettingsBuilder<T>
        where T : struct, IComparable 
    {
        /// <summary>
        /// Disables (false) or enables (true) the tooltip of the RangeSlider.
        /// </summary>
        /// <param name="value">The value for Enabled</param>
        public RangeSliderTooltipSettingsBuilder<T> Enabled(bool value)
        {
            Container.Enabled = value;
            return this;
        }

        /// <summary>
        /// Format string for the text of the tooltip. Note: The applied format will also influence the appearance of
		/// the RangeSlider tick labels.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public RangeSliderTooltipSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// Template of the tooltip.
        /// </summary>
        /// <param name="value">The value for Template</param>
        public RangeSliderTooltipSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// Template of the tooltip.
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public RangeSliderTooltipSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

    }
}
