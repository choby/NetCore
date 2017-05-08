using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Column
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsColumnCriteriaFactory
        
    {

        public Spreadsheet Spreadsheet { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Add()
        {
            var item = new SpreadsheetSheetFilterSettingsColumnCriteria();
            item.Spreadsheet = Spreadsheet;
            Container.Add(item);

            return new SpreadsheetSheetFilterSettingsColumnCriteriaBuilder(item);
        }
    }
}
