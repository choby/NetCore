using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleSettings
    /// </summary>
    public partial class LinearGaugeScaleSettingsBuilder
        
    {
        /// <summary>
        /// Configures the axis line.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public LinearGaugeScaleSettingsBuilder Line(Action<LinearGaugeScaleLineSettingsBuilder> configurator)
        {

            Container.Line.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeScaleLineSettingsBuilder(Container.Line));

            return this;
        }

        /// <summary>
        /// Configures the scale labels.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public LinearGaugeScaleSettingsBuilder Labels(Action<LinearGaugeScaleLabelsSettingsBuilder> configurator)
        {

            Container.Labels.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeScaleLabelsSettingsBuilder(Container.Labels));

            return this;
        }

        /// <summary>
        /// Configures the scale major ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the majorticks setting.</param>
        public LinearGaugeScaleSettingsBuilder MajorTicks(Action<LinearGaugeScaleMajorTicksSettingsBuilder> configurator)
        {

            Container.MajorTicks.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeScaleMajorTicksSettingsBuilder(Container.MajorTicks));

            return this;
        }

        /// <summary>
        /// The interval between major divisions.
        /// </summary>
        /// <param name="value">The value for MajorUnit</param>
        public LinearGaugeScaleSettingsBuilder MajorUnit(double value)
        {
            Container.MajorUnit = value;
            return this;
        }

        /// <summary>
        /// The maximum value of the scale.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public LinearGaugeScaleSettingsBuilder Max(double value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The minimum value of the scale.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public LinearGaugeScaleSettingsBuilder Min(double value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// Configures the scale minor ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the minorticks setting.</param>
        public LinearGaugeScaleSettingsBuilder MinorTicks(Action<LinearGaugeScaleMinorTicksSettingsBuilder> configurator)
        {

            Container.MinorTicks.LinearGauge = Container.LinearGauge;
            configurator(new LinearGaugeScaleMinorTicksSettingsBuilder(Container.MinorTicks));

            return this;
        }

        /// <summary>
        /// The interval between minor divisions.
        /// </summary>
        /// <param name="value">The value for MinorUnit</param>
        public LinearGaugeScaleSettingsBuilder MinorUnit(double value)
        {
            Container.MinorUnit = value;
            return this;
        }

        /// <summary>
        /// Mirrors the scale labels and ticks.
		/// If the labels are normally on the left side of the scale, mirroring the scale will render them to the right.
        /// </summary>
        /// <param name="value">The value for Mirror</param>
        public LinearGaugeScaleSettingsBuilder Mirror(bool value)
        {
            Container.Mirror = value;
            return this;
        }

        /// <summary>
        /// The ranges of the scale.
        /// </summary>
        /// <param name="configurator">The configurator for the ranges setting.</param>
        public LinearGaugeScaleSettingsBuilder Ranges(Action<LinearGaugeScaleSettingsRangeFactory> configurator)
        {

            configurator(new LinearGaugeScaleSettingsRangeFactory(Container.Ranges)
            {
                LinearGauge = Container.LinearGauge
            });

            return this;
        }

        /// <summary>
        /// The default color for the ranges.
        /// </summary>
        /// <param name="value">The value for RangePlaceholderColor</param>
        public LinearGaugeScaleSettingsBuilder RangePlaceholderColor(string value)
        {
            Container.RangePlaceholderColor = value;
            return this;
        }

        /// <summary>
        /// The width of the range indicators.
        /// </summary>
        /// <param name="value">The value for RangeSize</param>
        public LinearGaugeScaleSettingsBuilder RangeSize(double value)
        {
            Container.RangeSize = value;
            return this;
        }

        /// <summary>
        /// Reverses the axis direction - values increase from right to left and from top to bottom.
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public LinearGaugeScaleSettingsBuilder Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// Reverses the axis direction - values increase from right to left and from top to bottom.
        /// </summary>
        public LinearGaugeScaleSettingsBuilder Reverse()
        {
            Container.Reverse = true;
            return this;
        }

        /// <summary>
        /// The position of the gauge.
        /// </summary>
        /// <param name="value">The value for Vertical</param>
        public LinearGaugeScaleSettingsBuilder Vertical(bool value)
        {
            Container.Vertical = value;
            return this;
        }

    }
}
