using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisLabelsSettings
    /// </summary>
    public partial class ChartValueAxisLabelsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Border(Action<ChartValueAxisLabelsBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartValueAxisLabelsBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The margin of the labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Margin(Action<ChartValueAxisLabelsMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartValueAxisLabelsMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        /// <param name="value">The value for Mirror</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Mirror(bool value)
        {
            Container.Mirror = value;
            return this;
        }

        /// <summary>
        /// The padding of the labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Padding(Action<ChartValueAxisLabelsPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartValueAxisLabelsPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The rotation angle (in degrees) of the labels. By default the labels are not rotated. Angles increase clockwise and zero is to the left. Negative values are acceptable. Can be set to "auto" if the axis is horizontal in which case the labels will be rotated only if the slot size is not sufficient for the entire labels.
        /// </summary>
        /// <param name="configurator">The configurator for the rotation setting.</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Rotation(Action<ChartValueAxisLabelsRotationSettingsBuilder<T>> configurator)
        {

            Container.Rotation.Chart = Container.Chart;
            configurator(new ChartValueAxisLabelsRotationSettingsBuilder<T>(Container.Rotation));

            return this;
        }

        /// <summary>
        /// The number of labels to skip. By default no labels are skipped.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

        /// <summary>
        /// Label rendering step.
		/// Every n-th label is rendered where n is the step
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartValueAxisLabelsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the value axis labels. By default the category axis labels are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
