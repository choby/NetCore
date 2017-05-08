using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsSettings
    /// </summary>
    public partial class ChartSeriesLabelsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartSeriesLabelsSettingsBuilder<T> Background(string value)
        {
            Container.BackgroundHandler = null;
            Container.Background = value;
            return this;
        }
        /// <summary>
        /// The background color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsSettingsBuilder<T> BackgroundHandler(string handler)
        {
            Container.Background = null;
            Container.BackgroundHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The background color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsSettingsBuilder<T> BackgroundHandler(Func<object, object> handler)
        {
            Container.Background = null;
            Container.BackgroundHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The border of the labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartSeriesLabelsSettingsBuilder<T> Border(Action<ChartSeriesLabelsBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesLabelsSettingsBuilder<T> Color(string value)
        {
            Container.ColorHandler = null;
            Container.Color = value;
            return this;
        }
        /// <summary>
        /// The text color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsSettingsBuilder<T> ColorHandler(string handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The text color of the labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsSettingsBuilder<T> ColorHandler(Func<object, object> handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The distance of the labels when series.type is set to "donut" or "pie".
        /// </summary>
        /// <param name="value">The value for Distance</param>
        public ChartSeriesLabelsSettingsBuilder<T> Distance(double value)
        {
            Container.Distance = value;
            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartSeriesLabelsSettingsBuilder<T> Font(string value)
        {
            Container.FontHandler = null;
            Container.Font = value;
            return this;
        }
        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsSettingsBuilder<T> FontHandler(string handler)
        {
            Container.Font = null;
            Container.FontHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The font style of the labels.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsSettingsBuilder<T> FontHandler(Func<object, object> handler)
        {
            Container.Font = null;
            Container.FontHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The format of the labels. Uses kendo.format.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartSeriesLabelsSettingsBuilder<T> Format(string value)
        {
            Container.FormatHandler = null;
            Container.Format = value;
            return this;
        }
        /// <summary>
        /// The format of the labels. Uses kendo.format.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsSettingsBuilder<T> FormatHandler(string handler)
        {
            Container.Format = null;
            Container.FormatHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The format of the labels. Uses kendo.format.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsSettingsBuilder<T> FormatHandler(Func<object, object> handler)
        {
            Container.Format = null;
            Container.FormatHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The margin of the labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartSeriesLabelsSettingsBuilder<T> Margin(Action<ChartSeriesLabelsMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The padding of the labels. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartSeriesLabelsSettingsBuilder<T> Padding(Action<ChartSeriesLabelsPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The rotation angle of the labels. By default, the labels are not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public ChartSeriesLabelsSettingsBuilder<T> Rotation(string value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The template which renders the chart series label.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartSeriesLabelsSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the chart series label.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartSeriesLabelsSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the series labels. By default chart series labels are not displayed.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartSeriesLabelsSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the series labels. By default chart series labels are not displayed.
        /// </summary>
        public ChartSeriesLabelsSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the labels. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// The chart series from label configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the from setting.</param>
        public ChartSeriesLabelsSettingsBuilder<T> From(Action<ChartSeriesLabelsFromSettingsBuilder<T>> configurator)
        {

            Container.From.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsFromSettingsBuilder<T>(Container.From));

            return this;
        }

        /// <summary>
        /// The chart series to label configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the to setting.</param>
        public ChartSeriesLabelsSettingsBuilder<T> To(Action<ChartSeriesLabelsToSettingsBuilder<T>> configurator)
        {

            Container.To.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsToSettingsBuilder<T>(Container.To));

            return this;
        }

        /// <summary>
        /// Specifies the alignment of the labels.
        /// </summary>
        /// <param name="value">The value for Align</param>
        public ChartSeriesLabelsSettingsBuilder<T> Align(ChartSeriesLabelsAlign value)
        {
            Container.Align = value;
            return this;
        }

        /// <summary>
        /// Specifies the position of the labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartSeriesLabelsSettingsBuilder<T> Position(ChartSeriesLabelsPosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
