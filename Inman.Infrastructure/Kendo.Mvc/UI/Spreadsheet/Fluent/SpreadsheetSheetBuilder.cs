using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheet
    /// </summary>
    public partial class SpreadsheetSheetBuilder
        
    {
        public SpreadsheetSheetBuilder(SpreadsheetSheet container)
        {
            Container = container;
            Spreadsheet = container.Spreadsheet;
        }

        protected SpreadsheetSheet Container
        {
            get;
            private set;
        }

        protected Spreadsheet Spreadsheet
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the data source configuration of the grid.
        /// </summary>
        /// <param name="configurator">The lambda which configures the data source</param>
        public SpreadsheetSheetBuilder DataSource<T>(Action<DataSourceBuilder<T>> configurator)
            where T : class
        {
            Container.DataSource = new DataSource(Spreadsheet.ModelMetadataProvider)
            {
                Type = DataSourceType.Ajax
            };
            Container.DataSource.ModelType(typeof(T));
            configurator(new DataSourceBuilder<T>(Container.DataSource, Spreadsheet.ViewContext, Spreadsheet.UrlGenerator));

            return this;
        }
    }
}
