using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesAggregateSettings
    /// </summary>
    public partial class ChartSeriesAggregateSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesAggregateSettingsBuilder(ChartSeriesAggregateSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesAggregateSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        /// <summary>
        /// Specifies the aggregate for the close value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="value">The value for Close</param>
        public ChartSeriesAggregateSettingsBuilder<T> Close(ChartSeriesAggregate value)
        {
            Container.CloseHandler = null;
            Container.Close = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the close value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> CloseHandler(string handler)
        {
            Container.Close = null;
            Container.CloseHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the close value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> CloseHandler(Func<object, object> handler)
        {
            Container.Close = null;
            Container.CloseHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the high value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="value">The value for High</param>
        public ChartSeriesAggregateSettingsBuilder<T> High(ChartSeriesAggregate value)
        {
            Container.HighHandler = null;
            Container.High = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the high value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> HighHandler(string handler)
        {
            Container.High = null;
            Container.HighHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the high value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> HighHandler(Func<object, object> handler)
        {
            Container.High = null;
            Container.HighHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the low value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="value">The value for Low</param>
        public ChartSeriesAggregateSettingsBuilder<T> Low(ChartSeriesAggregate value)
        {
            Container.LowHandler = null;
            Container.Low = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the low value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> LowHandler(string handler)
        {
            Container.Low = null;
            Container.LowHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the low value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> LowHandler(Func<object, object> handler)
        {
            Container.Low = null;
            Container.LowHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the open value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="value">The value for Open</param>
        public ChartSeriesAggregateSettingsBuilder<T> Open(ChartSeriesAggregate value)
        {
            Container.OpenHandler = null;
            Container.Open = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the open value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> OpenHandler(string handler)
        {
            Container.Open = null;
            Container.OpenHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the open value. Applicable to "candlestick" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> OpenHandler(Func<object, object> handler)
        {
            Container.Open = null;
            Container.OpenHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the lower value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="value">The value for Lower</param>
        public ChartSeriesAggregateSettingsBuilder<T> Lower(ChartSeriesAggregate value)
        {
            Container.LowerHandler = null;
            Container.Lower = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the lower value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> LowerHandler(string handler)
        {
            Container.Lower = null;
            Container.LowerHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the lower value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> LowerHandler(Func<object, object> handler)
        {
            Container.Lower = null;
            Container.LowerHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the mean value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="value">The value for Mean</param>
        public ChartSeriesAggregateSettingsBuilder<T> Mean(ChartSeriesAggregate value)
        {
            Container.MeanHandler = null;
            Container.Mean = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the mean value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> MeanHandler(string handler)
        {
            Container.Mean = null;
            Container.MeanHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the mean value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> MeanHandler(Func<object, object> handler)
        {
            Container.Mean = null;
            Container.MeanHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the median value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="value">The value for Median</param>
        public ChartSeriesAggregateSettingsBuilder<T> Median(ChartSeriesAggregate value)
        {
            Container.MedianHandler = null;
            Container.Median = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the median value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> MedianHandler(string handler)
        {
            Container.Median = null;
            Container.MedianHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the median value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> MedianHandler(Func<object, object> handler)
        {
            Container.Median = null;
            Container.MedianHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for outliers. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="value">The value for Outliers</param>
        public ChartSeriesAggregateSettingsBuilder<T> Outliers(ChartSeriesAggregate value)
        {
            Container.OutliersHandler = null;
            Container.Outliers = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for outliers. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> OutliersHandler(string handler)
        {
            Container.Outliers = null;
            Container.OutliersHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for outliers. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> OutliersHandler(Func<object, object> handler)
        {
            Container.Outliers = null;
            Container.OutliersHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the q1 value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="value">The value for Q1</param>
        public ChartSeriesAggregateSettingsBuilder<T> Q1(ChartSeriesAggregate value)
        {
            Container.Q1Handler = null;
            Container.Q1 = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the q1 value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> Q1Handler(string handler)
        {
            Container.Q1 = null;
            Container.Q1Handler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the q1 value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> Q1Handler(Func<object, object> handler)
        {
            Container.Q1 = null;
            Container.Q1Handler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the q3 value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="value">The value for Q3</param>
        public ChartSeriesAggregateSettingsBuilder<T> Q3(ChartSeriesAggregate value)
        {
            Container.Q3Handler = null;
            Container.Q3 = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the q3 value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> Q3Handler(string handler)
        {
            Container.Q3 = null;
            Container.Q3Handler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the q3 value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> Q3Handler(Func<object, object> handler)
        {
            Container.Q3 = null;
            Container.Q3Handler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the upper value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="value">The value for Upper</param>
        public ChartSeriesAggregateSettingsBuilder<T> Upper(ChartSeriesAggregate value)
        {
            Container.UpperHandler = null;
            Container.Upper = value;
            return this;
        }
        /// <summary>
        /// Specifies the aggregate for the upper value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesAggregateSettingsBuilder<T> UpperHandler(string handler)
        {
            Container.Upper = null;
            Container.UpperHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the aggregate for the upper value. Applicable to "boxPlot" series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesAggregateSettingsBuilder<T> UpperHandler(Func<object, object> handler)
        {
            Container.Upper = null;
            Container.UpperHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
