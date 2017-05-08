using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleLabelsSettings
    /// </summary>
    public partial class LinearGaugeScaleLabelsSettingsBuilder
        
    {
        /// <summary>
        /// The background color of the labels.
		/// Any valid CSS color string will work here, including hex and rgb
        /// </summary>
        /// <param name="value">The value for Background</param>
        public LinearGaugeScaleLabelsSettingsBuilder Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public LinearGaugeScaleLabelsSettingsBuilder Border(Action<LinearGaugeScaleLabelsBorderSettingsBuilder> configurator)
        {

            Container.Border.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeScaleLabelsBorderSettingsBuilder(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the labels.
		/// Any valid CSS color string will work here, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public LinearGaugeScaleLabelsSettingsBuilder Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public LinearGaugeScaleLabelsSettingsBuilder Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format of the labels.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public LinearGaugeScaleLabelsSettingsBuilder Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The margin of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public LinearGaugeScaleLabelsSettingsBuilder Margin(Action<LinearGaugeScaleLabelsMarginSettingsBuilder> configurator)
        {

            Container.Margin.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeScaleLabelsMarginSettingsBuilder(Container.Margin));

            return this;
        }

        /// <summary>
        /// The padding of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public LinearGaugeScaleLabelsSettingsBuilder Padding(Action<LinearGaugeScaleLabelsPaddingSettingsBuilder> configurator)
        {

            Container.Padding.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeScaleLabelsPaddingSettingsBuilder(Container.Padding));

            return this;
        }

        /// <summary>
        /// The label template.
		/// Template variables:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public LinearGaugeScaleLabelsSettingsBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The label template.
		/// Template variables:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public LinearGaugeScaleLabelsSettingsBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// The visibility of the labels.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public LinearGaugeScaleLabelsSettingsBuilder Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

    }
}
