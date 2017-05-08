using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisNotesSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisNotesSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The position of the category axis note.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> Position(string value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The icon of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the icon setting.</param>
        public StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> Icon(Action<StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T>> configurator)
        {

            Container.Icon.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisNotesIconSettingsBuilder<T>(Container.Icon));

            return this;
        }

        /// <summary>
        /// The label of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the label setting.</param>
        public StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> Label(Action<StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T>> configurator)
        {

            Container.Label.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisNotesLabelSettingsBuilder<T>(Container.Label));

            return this;
        }

        /// <summary>
        /// The line of the notes.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public StockChartNavigatorCategoryAxisNotesSettingsBuilder<T> Line(Action<StockChartNavigatorCategoryAxisNotesLineSettingsBuilder<T>> configurator)
        {

            Container.Line.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorCategoryAxisNotesLineSettingsBuilder<T>(Container.Line));

            return this;
        }

    }
}
