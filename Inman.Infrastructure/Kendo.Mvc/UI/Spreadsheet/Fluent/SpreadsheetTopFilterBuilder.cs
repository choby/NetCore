namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetFilterSettingsColumn settings.
    /// </summary>
    public class SpreadsheetTopFilterBuilder
    {
        public SpreadsheetTopFilterBuilder(SpreadsheetSheetFilterSettingsColumn container)
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
        public SpreadsheetTopFilterBuilder Index(double value)
        {
            Container.Index = value;

            return this;
        }

        /// <summary>
        /// The filter sub-type, if any.Applicable types according to the main filter.		
        ///     * topNumber
        ///     * topPercent
        ///     * bottomNumber
        ///     * bottomPercent	
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public SpreadsheetTopFilterBuilder Type(SpreadsheetTopFilterType value)
        {
            Container.Type = value.Serialize();

            return this;
        }

        /// <summary>
        /// The filter value for filters that require a single value, e.g. "top".
        /// </summary>
        /// <param name="value">The value that configures the value.</param>
        public SpreadsheetTopFilterBuilder Value(double value)
        {
            Container.Value = value;

            return this;
        }
    }
}
