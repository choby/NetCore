using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsLabelsSettings
    /// </summary>
    public partial class ChartAxisDefaultsLabelsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The format used to display the labels. Uses kendo.format. Contains one placeholder ("{0}") which represents the category value.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Format(string value)
        {
            Container.Format = value;
            return this;
        }

        /// <summary>
        /// The margin of the labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Margin(Action<ChartAxisDefaultsLabelsMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsLabelsMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        /// <param name="value">The value for Mirror</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Mirror(bool value)
        {
            Container.Mirror = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will mirror the axis labels and ticks. If the labels are normally on the left side of the axis, mirroring the axis will render them to the right.
        /// </summary>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Mirror()
        {
            Container.Mirror = true;
            return this;
        }

        /// <summary>
        /// The padding of the labels. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Padding(Action<ChartAxisDefaultsLabelsPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsLabelsPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated. Can be set to "auto" if the axis is horizontal in which case the labels will be rotated only if the slot size is not sufficient for the entire labels.
        /// </summary>
        /// <param name="configurator">The configurator for the rotation setting.</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Rotation(Action<ChartAxisDefaultsLabelsRotationSettingsBuilder<T>> configurator)
        {

            Container.Rotation.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsLabelsRotationSettingsBuilder<T>(Container.Rotation));

            return this;
        }

        /// <summary>
        /// The number of labels to skip. By default no labels are skipped.
        /// </summary>
        /// <param name="value">The value for Skip</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Skip(double value)
        {
            Container.Skip = value;
            return this;
        }

        /// <summary>
        /// The label rendering step - render every n-th label. By default every label is rendered.
        /// </summary>
        /// <param name="value">The value for Step</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Step(double value)
        {
            Container.Step = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the labels.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the axis labels. By default the axis labels are visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartAxisDefaultsLabelsSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
