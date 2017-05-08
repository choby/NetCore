using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Sort
    /// </summary>
    public partial class SpreadsheetSheetSortSettingsColumnFactory
        
    {

        public Spreadsheet Spreadsheet { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetSortSettingsColumnBuilder Add()
        {
            var item = new SpreadsheetSheetSortSettingsColumn();
            item.Spreadsheet = Spreadsheet;
            Container.Add(item);

            return new SpreadsheetSheetSortSettingsColumnBuilder(item);
        }
    }
}
