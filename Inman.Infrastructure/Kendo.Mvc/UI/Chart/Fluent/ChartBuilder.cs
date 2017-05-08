using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Chart
    /// </summary>
    public partial class ChartBuilder<T>: WidgetBuilderBase<Chart<T>, ChartBuilder<T>>
        where T : class 
    {
        public ChartBuilder(Chart<T> component) : base(component)
        {
        }

        /// <summary>
        /// The chart title.
        /// </summary>
        /// <param name="title">The value of the Chart title</param>
        public ChartBuilder<T> Title(string title)
        {
            Container.Title.Text = title;
            return this;
        }

        public ChartBuilder<T> SeriesDefaults(Action<ChartSeriesDefaultsSettingsBuilder<T>> configurator)
        {
            configurator(new ChartSeriesDefaultsSettingsBuilder<T>(Container.SeriesDefaults));

            return this;
        }
        
        /// <summary>
        /// Configures the category axis
        /// </summary>
        /// <param name="configurator">The configurator</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Chart(Model)
        ///             .Name("Chart")
        ///             .CategoryAxis(axis => axis
        ///                 .Categories(s => s.DateString)
        ///             )
        /// )
        /// </code>
        /// </example>
        public ChartBuilder<T> CategoryAxis(Action<ChartCategoryAxisBuilder<T>> configurator)
        {
            var item = new ChartCategoryAxis<T>()
            {
                Chart = Container
            };
            Container.CategoryAxis.Add(item);
            configurator(new ChartCategoryAxisBuilder<T>(item));
            return this;
        }

        /// <summary>
        /// Data Source configuration
        /// </summary>
        /// <param name="configurator">Use the configurator to set different data binding options.</param>
        /// <example>
        /// <code lang="CS">
        ///  @(Html.Kendo().Chart()
        ///             .Name("Chart")
        ///             .DataSource(ds =>
        ///             {
        ///                 ds.Ajax().Read(r => r.Action("SalesData", "Chart"));
        ///             })
        /// )
        /// </code>
        /// </example>
        public ChartBuilder<T> DataSource(Action<ReadOnlyAjaxDataSourceBuilder<T>> configurator)
        {
            configurator(new ReadOnlyAjaxDataSourceBuilder<T>(Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));

            return this;
        }

        public ChartBuilder<T> DataSource(string dataSourceId)
        {
            this.Component.DataSourceId = dataSourceId;
            return this;
        }

        /// <summary>
        /// Sets the legend visibility.
        /// </summary>
        /// <param name="visible">A value indicating whether to show the legend.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Chart()
        ///             .Name("Chart")
        ///             .Legend(false)
        /// );
        /// </code>
        /// </example>
        public ChartBuilder<T> Legend(bool visible)
        {
            Component.Legend.Visible = visible;

            return this;
        }

        /// <summary>
        /// Configures the default value axis or adds a new one
        /// </summary>
        /// <param name="configurator">The configurator for the axis</param>
        /// <returns></returns>
        public ChartBuilder<T> ValueAxis(Action<ChartValueAxisBuilder<T>> configurator)
        {
            var axis = new ChartValueAxis<T>();
            configurator(new ChartValueAxisBuilder<T>(axis));
            Component.ValueAxis.Add(axis);
            return this;
        }

        /// <summary>
        /// Configures the default X axis or adds a new one
        /// </summary>
        /// <param name="configurator">The configurator for the axis</param>
        /// <returns></returns>
        public ChartBuilder<T> XAxis(Action<ChartXAxisBuilder<T>> configurator)
        {
            configurator(new ChartXAxisFactory<T>(Container.XAxis).Add());
            return this;
        }

        /// <summary>
        /// Configures the default Y axis or adds a new one
        /// </summary>
        /// <param name="configurator">The configurator for the axis</param>
        /// <returns></returns>
        public ChartBuilder<T> YAxis(Action<ChartYAxisBuilder<T>> configurator)
        {
            configurator(new ChartYAxisFactory<T>(Container.YAxis).Add());
            return this;
        }
    }
}

