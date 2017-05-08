using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsFromSettings
    /// </summary>
    public partial class ChartSeriesLabelsFromSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the from labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Background(string value)
        {
            Container.BackgroundHandler = null;
            Container.Background = value;
            return this;
        }
        /// <summary>
        /// The background color of the from labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> BackgroundHandler(string handler)
        {
            Container.Background = null;
            Container.BackgroundHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The background color of the from labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> BackgroundHandler(Func<object, object> handler)
        {
            Container.Background = null;
            Container.BackgroundHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The border of the from labels.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Border(Action<ChartSeriesLabelsFromBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsFromBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the from labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Color(string value)
        {
            Container.ColorHandler = null;
            Container.Color = value;
            return this;
        }
        /// <summary>
        /// The text color of the from labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> ColorHandler(string handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The text color of the from labels. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> ColorHandler(Func<object, object> handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The font style of the from labels.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Font(string value)
        {
            Container.FontHandler = null;
            Container.Font = value;
            return this;
        }
        /// <summary>
        /// The font style of the from labels.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> FontHandler(string handler)
        {
            Container.Font = null;
            Container.FontHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The font style of the from labels.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> FontHandler(Func<object, object> handler)
        {
            Container.Font = null;
            Container.FontHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The format of the from labels. Uses kendo.format.
        /// </summary>
        /// <param name="value">The value for Format</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Format(string value)
        {
            Container.FormatHandler = null;
            Container.Format = value;
            return this;
        }
        /// <summary>
        /// The format of the from labels. Uses kendo.format.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> FormatHandler(string handler)
        {
            Container.Format = null;
            Container.FormatHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The format of the from labels. Uses kendo.format.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> FormatHandler(Func<object, object> handler)
        {
            Container.Format = null;
            Container.FormatHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The margin of the from labels. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Margin(Action<ChartSeriesLabelsFromMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsFromMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The padding of the from labels. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Padding(Action<ChartSeriesLabelsFromPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartSeriesLabelsFromPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The position of the from labels.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Position(string value)
        {
            Container.PositionHandler = null;
            Container.Position = value;
            return this;
        }
        /// <summary>
        /// The position of the from labels.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> PositionHandler(string handler)
        {
            Container.Position = null;
            Container.PositionHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The position of the from labels.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> PositionHandler(Func<object, object> handler)
        {
            Container.Position = null;
            Container.PositionHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The template which renders the chart series from label.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The value for Template</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template which renders the chart series from label.The fields which can be used in the template are:
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the series from labels. By default chart series from labels are not displayed.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartSeriesLabelsFromSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the series from labels. By default chart series from labels are not displayed.
        /// </summary>
        public ChartSeriesLabelsFromSettingsBuilder<T> Visible()
        {
            Container.Visible = true;
            return this;
        }

    }
}
