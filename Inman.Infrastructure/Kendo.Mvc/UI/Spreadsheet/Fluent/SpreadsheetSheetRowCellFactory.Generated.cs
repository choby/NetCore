using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Row
    /// </summary>
    public partial class SpreadsheetSheetRowCellFactory
        
    {

        public Spreadsheet Spreadsheet { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetRowCellBuilder Add()
        {
            var item = new SpreadsheetSheetRowCell();
            item.Spreadsheet = Spreadsheet;
            Container.Add(item);

            return new SpreadsheetSheetRowCellBuilder(item);
        }
    }
}
