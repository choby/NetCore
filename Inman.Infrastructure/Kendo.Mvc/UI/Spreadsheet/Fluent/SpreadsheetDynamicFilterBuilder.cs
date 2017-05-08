namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetFilterSettingsColumn
    /// </summary>
    public class SpreadsheetDynamicFilterBuilder
    {
        public SpreadsheetDynamicFilterBuilder(SpreadsheetSheetFilterSettingsColumn container)
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
        public SpreadsheetDynamicFilterBuilder Index(double value)
        {
            Container.Index = value;

            return this;
        }

        /// <summary>
        /// The filter sub-type, if any.Applicable types according to the main filter.		
        ///     * aboveAverage
        ///     * belowAverage
        ///     * tomorrow
        ///     * today
        ///     * yesterday
        ///     * nextWeek
        ///     * thisWeek
        ///     * lastWeek
        ///     * nextMonth
        ///     * thisMonth
        ///     * lastMonth
        ///     * nextQuarter
        ///     * thisQuarter
        ///     * lastQuarter
        ///     * nextYear
        ///     * thisYear
        ///     * lastYear
        ///     * yearToDate
        /// </summary>
        /// <param name="value">The value that configures the type.</param>
        public SpreadsheetDynamicFilterBuilder Type(SpreadsheetDynamicFilterType value)
        {
            Container.Type = value.Serialize();

            return this;
        }
    }
}
