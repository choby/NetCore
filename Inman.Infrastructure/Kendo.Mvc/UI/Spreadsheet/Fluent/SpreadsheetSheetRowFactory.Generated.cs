using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Sheet
    /// </summary>
    public partial class SpreadsheetSheetRowFactory
        
    {

        public Spreadsheet Spreadsheet { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetRowBuilder Add()
        {
            var item = new SpreadsheetSheetRow();
            item.Spreadsheet = Spreadsheet;
            Container.Add(item);

            return new SpreadsheetSheetRowBuilder(item);
        }
    }
}
