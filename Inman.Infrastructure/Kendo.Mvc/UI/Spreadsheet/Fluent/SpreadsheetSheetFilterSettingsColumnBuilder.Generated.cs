using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetFilterSettingsColumn
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsColumnBuilder
        
    {
        /// <summary>
        /// An array of filter criteria for custom filters.
        /// </summary>
        /// <param name="configurator">The configurator for the criteria setting.</param>
        public SpreadsheetSheetFilterSettingsColumnBuilder Criteria(Action<SpreadsheetSheetFilterSettingsColumnCriteriaFactory> configurator)
        {

            configurator(new SpreadsheetSheetFilterSettingsColumnCriteriaFactory(Container.Criteria)
            {
                Spreadsheet = Container.Spreadsheet
            });

            return this;
        }

        /// <summary>
        /// The filter to apply to this column.The supported filters are:
		///   * value - filters based on unique values
		///   * custom - applies custom filtering criteria
		///   * top - filters the top or bottom records
		///   * dynamic - filters based on dynamic criteria
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public SpreadsheetSheetFilterSettingsColumnBuilder Filter(string value)
        {
            Container.Filter = value;
            return this;
        }

        /// <summary>
        /// The index of the column relative to the filter range.
        /// </summary>
        /// <param name="value">The value for Index</param>
        public SpreadsheetSheetFilterSettingsColumnBuilder Index(double value)
        {
            Container.Index = value;
            return this;
        }

        /// <summary>
        /// The logical operator to apply to filter criteria.Possible values are and, or.
        /// </summary>
        /// <param name="value">The value for Logic</param>
        public SpreadsheetSheetFilterSettingsColumnBuilder Logic(string value)
        {
            Container.Logic = value;
            return this;
        }

        /// <summary>
        /// The filter sub-type, if any.Applicable types according to the main filter.
		/// * top
		///     * topNumber
		///     * topPercent
		///     * bottomNumber
		///     * bottomPercent
		/// * dynamic
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
        /// <param name="value">The value for Type</param>
        public SpreadsheetSheetFilterSettingsColumnBuilder Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// The filter value for filters that require a single value, e.g. "top".
        /// </summary>
        /// <param name="value">The value for Value</param>
        public SpreadsheetSheetFilterSettingsColumnBuilder Value(double value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// The filter values for filters that support multiple values.
        /// </summary>
        /// <param name="value">The value for Values</param>
        public SpreadsheetSheetFilterSettingsColumnBuilder Values(params object[] value)
        {
            Container.Values = value;
            return this;
        }

    }
}
