using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeScaleSettings
    /// </summary>
    public partial class RadialGaugeScaleSettingsBuilder
        
    {
        /// <summary>
        /// The end angle of the gauge.
		/// The gauge is rendered clockwise(0 degrees are the 180 degrees in the polar coordinate system)
        /// </summary>
        /// <param name="value">The value for EndAngle</param>
        public RadialGaugeScaleSettingsBuilder EndAngle(double value)
        {
            Container.EndAngle = value;
            return this;
        }

        /// <summary>
        /// Configures the scale labels.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public RadialGaugeScaleSettingsBuilder Labels(Action<RadialGaugeScaleLabelsSettingsBuilder> configurator)
        {

            Container.Labels.RadialGauge = Container.RadialGauge;
            configurator(new RadialGaugeScaleLabelsSettingsBuilder(Container.Labels));

            return this;
        }

        /// <summary>
        /// Configures the scale major ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the majorticks setting.</param>
        public RadialGaugeScaleSettingsBuilder MajorTicks(Action<RadialGaugeScaleMajorTicksSettingsBuilder> configurator)
        {

            Container.MajorTicks.RadialGauge = Container.RadialGauge;
            configurator(new RadialGaugeScaleMajorTicksSettingsBuilder(Container.MajorTicks));

            return this;
        }

        /// <summary>
        /// The interval between major divisions.
        /// </summary>
        /// <param name="value">The value for MajorUnit</param>
        public RadialGaugeScaleSettingsBuilder MajorUnit(double value)
        {
            Container.MajorUnit = value;
            return this;
        }

        /// <summary>
        /// The maximum value of the scale.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public RadialGaugeScaleSettingsBuilder Max(double value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The minimum value of the scale.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public RadialGaugeScaleSettingsBuilder Min(double value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// Configures the scale minor ticks.
        /// </summary>
        /// <param name="configurator">The configurator for the minorticks setting.</param>
        public RadialGaugeScaleSettingsBuilder MinorTicks(Action<RadialGaugeScaleMinorTicksSettingsBuilder> configurator)
        {

            Container.MinorTicks.RadialGauge = Container.RadialGauge;
            configurator(new RadialGaugeScaleMinorTicksSettingsBuilder(Container.MinorTicks));

            return this;
        }

        /// <summary>
        /// The interval between minor divisions.
        /// </summary>
        /// <param name="value">The value for MinorUnit</param>
        public RadialGaugeScaleSettingsBuilder MinorUnit(double value)
        {
            Container.MinorUnit = value;
            return this;
        }

        /// <summary>
        /// The ranges of the scale.
        /// </summary>
        /// <param name="configurator">The configurator for the ranges setting.</param>
        public RadialGaugeScaleSettingsBuilder Ranges(Action<RadialGaugeScaleSettingsRangeFactory> configurator)
        {

            configurator(new RadialGaugeScaleSettingsRangeFactory(Container.Ranges)
            {
                RadialGauge = Container.RadialGauge
            });

            return this;
        }

        /// <summary>
        /// The default color for the ranges.
        /// </summary>
        /// <param name="value">The value for RangePlaceholderColor</param>
        public RadialGaugeScaleSettingsBuilder RangePlaceholderColor(string value)
        {
            Container.RangePlaceholderColor = value;
            return this;
        }

        /// <summary>
        /// The width of the range indicators.
        /// </summary>
        /// <param name="value">The value for RangeSize</param>
        public RadialGaugeScaleSettingsBuilder RangeSize(double value)
        {
            Container.RangeSize = value;
            return this;
        }

        /// <summary>
        /// The distance from the range indicators to the ticks.
        /// </summary>
        /// <param name="value">The value for RangeDistance</param>
        public RadialGaugeScaleSettingsBuilder RangeDistance(double value)
        {
            Container.RangeDistance = value;
            return this;
        }

        /// <summary>
        /// Reverses the scale direction - values are increase anticlockwise.
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public RadialGaugeScaleSettingsBuilder Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// Reverses the scale direction - values are increase anticlockwise.
        /// </summary>
        public RadialGaugeScaleSettingsBuilder Reverse()
        {
            Container.Reverse = true;
            return this;
        }

        /// <summary>
        /// The start angle of the gauge.
		/// The gauge is rendered clockwise(0 degrees are the 180 degrees in the polar coordinate system)
        /// </summary>
        /// <param name="value">The value for StartAngle</param>
        public RadialGaugeScaleSettingsBuilder StartAngle(double value)
        {
            Container.StartAngle = value;
            return this;
        }

    }
}
