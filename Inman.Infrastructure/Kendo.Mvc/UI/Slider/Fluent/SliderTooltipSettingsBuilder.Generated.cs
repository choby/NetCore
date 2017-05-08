using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SliderTooltipSettings
    /// </summary>
    public partial class SliderTooltipSettingsBuilder<T>
        where T : struct, IComparable 
    {
        /// <summary>
        /// Disables (false) or enables (true) the tooltip of
		/// the Slider.
        /// </summary>
        /// <param name="value">The value for Enabled</param>
        public SliderTooltipSettingsBuilder<T> Enabled(bool value)
        {
            Container.Enabled = value;
            return this;
        }

        /// <summary>
        /// Format string for the text of the tooltip. Note: The applied
		/// format will also influence the appearance of the Slider
		/// tick labels.The slider widget supports precision of up-to 10 digits after the decimals point.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public SliderTooltipSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// Template of the tooltip. The following variables are passed by the Slider and are ready to be used inside the template:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public SliderTooltipSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// Template of the tooltip. The following variables are passed by the Slider and are ready to be used inside the template:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public SliderTooltipSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

    }
}
