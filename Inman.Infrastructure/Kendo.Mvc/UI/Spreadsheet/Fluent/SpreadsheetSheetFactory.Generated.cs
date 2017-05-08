using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Spreadsheet
    /// </summary>
    public partial class SpreadsheetSheetFactory
        
    {

        public Spreadsheet Spreadsheet { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetBuilder Add()
        {
            var item = new SpreadsheetSheet();
            item.Spreadsheet = Spreadsheet;
            Container.Add(item);

            return new SpreadsheetSheetBuilder(item);
        }
    }
}
