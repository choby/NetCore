using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<SpreadsheetSheetFilterSettingsColumn>
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsColumnFactory
        
    {
        public SpreadsheetSheetFilterSettingsColumnFactory(List<SpreadsheetSheetFilterSettingsColumn> container)
        {
            Container = container;
        }

        protected List<SpreadsheetSheetFilterSettingsColumn> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnFactory ValueFilter(Action<SpreadsheetValueFilterBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumn
            {
                Filter = "value",
                Spreadsheet = Spreadsheet
            };

            Container.Add(item);

            configuration(new SpreadsheetValueFilterBuilder(item));

            return this;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnFactory TopFilter(Action<SpreadsheetTopFilterBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumn
            {
                Filter = "top",
                Spreadsheet = Spreadsheet
            };

            Container.Add(item);

            configuration(new SpreadsheetTopFilterBuilder(item));

            return this;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnFactory DynamicFilter(Action<SpreadsheetDynamicFilterBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumn
            {
                Filter = "dynamic",
                Spreadsheet = Spreadsheet
            };

            Container.Add(item);

            configuration(new SpreadsheetDynamicFilterBuilder(item));

            return this;
        }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnFactory CustomFilter(Action<SpreadsheetCustomFilterBuilder> configuration)
        {
            var item = new SpreadsheetSheetFilterSettingsColumn
            {
                Filter = "custom",
                Spreadsheet = Spreadsheet
            };

            Container.Add(item);

            configuration(new SpreadsheetCustomFilterBuilder(item));

            return this;
        }
    }
}
