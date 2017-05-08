using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Spreadsheet
    /// </summary>
    public partial class SpreadsheetBuilder: WidgetBuilderBase<Spreadsheet, SpreadsheetBuilder>
        
    {
        public SpreadsheetBuilder(Spreadsheet component) : base(component)
        {
        }

        public SpreadsheetBuilder BindTo(IEnumerable<SpreadsheetSheet> value)
        {
            Container.Sheets.Clear();
            Container.Sheets.AddRange(value);

            return this;
        }

        public SpreadsheetBuilder BindTo(Dictionary<string, object> workbook)
        {
            Container.DplSettings = workbook;

            return this;
        }
    }
}

