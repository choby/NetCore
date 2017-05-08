using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLabelsSettings
    /// </summary>
    public partial class ChartYAxisLabelsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartYAxisLabelsSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartYAxisLabelsSettingsBuilder<T> Border(Action<ChartYAxisLabelsBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartYAxisLabelsBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartYAxisLabelsSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The culture to use when formatting date values. See the globalization overview for more information.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public ChartYAxisLabelsSettingsBuilder<T> Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels when the x values are dates. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="configurator">The configurator for the dateformats setting.</param>
        public ChartYAxisLabelsSettingsBuilder<T> DateFormats(Action<ChartYAxisLabelsDateFormatsSettingsBuilder<T>> configurator)
        {

            Container.DateFormats.Chart = Container.Chart;
            configurator(new ChartYAxisLabelsDateFormatsSettingsBuilder<T>(Container.DateFormats));

            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartYAxisLabelsSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartYAxisLabelsSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The margin of the labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartYAxisLabelsSettingsBuilder<T> Margin(Action<ChartYAxisLabelsMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartYAxisLabelsMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        /// <param name="value">The value for Mirror</param>
        public ChartYAxisLabelsSettingsBuilder<T> Mirror(bool value)
        {
            Container.Mirror = value;
            return this;
        }

        /// <summary>
        /// The padding of the labels. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartYAxisLabelsSettingsBuilder<T> Padding(Action<ChartYAxisLabelsPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartYAxisLabelsPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated.
        /// </summary>
        /// <param name="configurator">The configurator for the rotation setting.</param>
        public ChartYAxisLabelsSettingsBuilder<T> Rotation(Action<ChartYAxisLabelsRotationSettingsBuilder<T>> configurator)
        {

            Container.Rotation.Chart = Container.Chart;
            configurator(new ChartYAxisLabelsRotationSettingsBuilder<T>(Container.Rotation));

            return this;
        }

        /// <summary>
        /// The number of labels to skip.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartYAxisLabelsSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

        /// <summary>
        /// The label rendering step - render every n-th label. By default every label is rendered.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartYAxisLabelsSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartYAxisLabelsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartYAxisLabelsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the y axis labels. By default the y axis labels are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartYAxisLabelsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartYAxisLabelsSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartYAxisLabelsSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
