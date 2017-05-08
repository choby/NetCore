using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLabelsSettings
    /// </summary>
    public partial class ChartCategoryAxisLabelsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Border(Action<ChartCategoryAxisLabelsBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartCategoryAxisLabelsBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The culture to use when formatting date values. See the globalization overview for more information.
        /// </summary>
        /// <param name="value">The value for Culture</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Culture(string value)
        {
            Container.Culture = value;
            return this;
        }

        /// <summary>
        /// The format used to display labels for date category axis.
		/// The {0} placeholder represents the category value.The chart will choose the appropriate format for the current categoryAxis.baseUnit.
		/// Setting the categoryAxis.labels.format option will override the date formats.See also: kendo.format.
        /// </summary>
        /// <param name="configurator">The configurator for the dateformats setting.</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> DateFormats(Action<ChartCategoryAxisLabelsDateFormatsSettingsBuilder<T>> configurator)
        {

            Container.DateFormats.Chart = Container.Chart;
            configurator(new ChartCategoryAxisLabelsDateFormatsSettingsBuilder<T>(Container.DateFormats));

            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The margin of the labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Margin(Action<ChartCategoryAxisLabelsMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartCategoryAxisLabelsMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        /// <param name="value">The value for Mirror</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Mirror(bool value)
        {
            Container.Mirror = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Mirror()
        {
            Container.Mirror = true;
            return this;
        }

        /// <summary>
        /// The padding of the labels. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Padding(Action<ChartCategoryAxisLabelsPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartCategoryAxisLabelsPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated. Can be set to "auto" if the axis is horizontal in which case the labels will be rotated only if the slot size is not sufficient for the entire labels.
        /// </summary>
        /// <param name="configurator">The configurator for the rotation setting.</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Rotation(Action<ChartCategoryAxisLabelsRotationSettingsBuilder<T>> configurator)
        {

            Container.Rotation.Chart = Container.Chart;
            configurator(new ChartCategoryAxisLabelsRotationSettingsBuilder<T>(Container.Rotation));

            return this;
        }

        /// <summary>
        /// The number of labels to skip. By default no labels are skipped.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

        /// <summary>
        /// The label rendering step - render every n-th label. By default every label is rendered.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the category axis labels. By default the category axis labels are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartCategoryAxisLabelsSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
