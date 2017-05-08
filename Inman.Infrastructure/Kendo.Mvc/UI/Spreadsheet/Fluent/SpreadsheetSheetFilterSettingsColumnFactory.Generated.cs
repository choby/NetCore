using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Filter
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsColumnFactory
        
    {

        public Spreadsheet Spreadsheet { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnBuilder Add()
        {
            var item = new SpreadsheetSheetFilterSettingsColumn();
            item.Spreadsheet = Spreadsheet;
            Container.Add(item);

            return new SpreadsheetSheetFilterSettingsColumnBuilder(item);
        }
    }
}
