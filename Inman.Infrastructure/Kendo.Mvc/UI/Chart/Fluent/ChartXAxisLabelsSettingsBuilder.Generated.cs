using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLabelsSettings
    /// </summary>
    public partial class ChartXAxisLabelsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartXAxisLabelsSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartXAxisLabelsSettingsBuilder<T> Border(Action<ChartXAxisLabelsBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartXAxisLabelsBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartXAxisLabelsSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The culture to use when formatting date values. See the globalization overview for more information.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public ChartXAxisLabelsSettingsBuilder<T> Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels when the x values are dates. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="configurator">The configurator for the dateformats setting.</param>
        public ChartXAxisLabelsSettingsBuilder<T> DateFormats(Action<ChartXAxisLabelsDateFormatsSettingsBuilder<T>> configurator)
        {

            Container.DateFormats.Chart = Container.Chart;
            configurator(new ChartXAxisLabelsDateFormatsSettingsBuilder<T>(Container.DateFormats));

            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartXAxisLabelsSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartXAxisLabelsSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The margin of the labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartXAxisLabelsSettingsBuilder<T> Margin(Action<ChartXAxisLabelsMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartXAxisLabelsMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        /// <param name="value">The value for Mirror</param>
        public ChartXAxisLabelsSettingsBuilder<T> Mirror(bool value)
        {
            Container.Mirror = value;
            return this;
        }

        /// <summary>
        /// The padding of the labels. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartXAxisLabelsSettingsBuilder<T> Padding(Action<ChartXAxisLabelsPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartXAxisLabelsPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated. Can be set to "auto" in which case the labels will be rotated only if the slot size is not sufficient for the entire labels.
        /// </summary>
        /// <param name="configurator">The configurator for the rotation setting.</param>
        public ChartXAxisLabelsSettingsBuilder<T> Rotation(Action<ChartXAxisLabelsRotationSettingsBuilder<T>> configurator)
        {

            Container.Rotation.Chart = Container.Chart;
            configurator(new ChartXAxisLabelsRotationSettingsBuilder<T>(Container.Rotation));

            return this;
        }

        /// <summary>
        /// The number of labels to skip.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartXAxisLabelsSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

        /// <summary>
        /// The label rendering step - render every n-th label. By default every label is rendered.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartXAxisLabelsSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartXAxisLabelsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartXAxisLabelsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the x axis labels. By default the x axis labels are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartXAxisLabelsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartXAxisLabelsSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartXAxisLabelsSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
