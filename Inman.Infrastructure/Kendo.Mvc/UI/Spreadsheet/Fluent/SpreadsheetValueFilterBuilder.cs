namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetFilterSettingsColumn
    /// </summary>
    public partial class SpreadsheetValueFilterBuilder
    {
        public SpreadsheetValueFilterBuilder(SpreadsheetSheetFilterSettingsColumn container)
        {
            Container = container;
        }

        protected SpreadsheetSheetFilterSettingsColumn Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The index of the column relative to the filter range.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetValueFilterBuilder Index(double value)
        {
            Container.Index = value;

            return this;
        }

        /// <summary>
        /// The filter values for filters that support multiple values.
        /// </summary>
        /// <param name="value">The value that configures the values.</param>
        public SpreadsheetValueFilterBuilder Values(params object[] value)
        {
            Container.Values = value;

            return this;
        }
    }
}
