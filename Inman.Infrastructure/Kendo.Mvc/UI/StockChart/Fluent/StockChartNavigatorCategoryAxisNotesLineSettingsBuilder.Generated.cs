using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisNotesLineSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisNotesLineSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The line width of the notes.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorCategoryAxisNotesLineSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The line color of the notes.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorCategoryAxisNotesLineSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The length of the connecting lines in pixels.
        /// </summary>
        /// <param name="value">The value for Length</param>
        public StockChartNavigatorCategoryAxisNotesLineSettingsBuilder<T> Length(double value)
        {
            Container.Length = value;
            return this;
        }

    }
}
