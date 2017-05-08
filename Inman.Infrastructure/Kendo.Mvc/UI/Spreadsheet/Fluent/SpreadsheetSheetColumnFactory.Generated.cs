using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Sheet
    /// </summary>
    public partial class SpreadsheetSheetColumnFactory
        
    {

        public Spreadsheet Spreadsheet { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetColumnBuilder Add()
        {
            var item = new SpreadsheetSheetColumn();
            item.Spreadsheet = Spreadsheet;
            Container.Add(item);

            return new SpreadsheetSheetColumnBuilder(item);
        }
    }
}
