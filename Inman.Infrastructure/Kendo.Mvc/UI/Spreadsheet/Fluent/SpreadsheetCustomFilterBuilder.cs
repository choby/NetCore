using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the SpreadsheetSheetFilterSettingsColumn settings.
    /// </summary>
    public class SpreadsheetCustomFilterBuilder
    {
        public SpreadsheetCustomFilterBuilder(SpreadsheetSheetFilterSettingsColumn settings)
        {
            Container = settings;
        }

        protected SpreadsheetSheetFilterSettingsColumn Container
        {
            get;
            private set;
        }

        /// <summary>
        /// An array of filter criteria for custom filters.
        /// </summary>
        /// <param name="configurator">The action that configures the criteria.</param>
        public SpreadsheetCustomFilterBuilder Criteria(Action<SpreadsheetSheetFilterSettingsColumnCriteriaFactory> configurator)
        {
            configurator(new SpreadsheetSheetFilterSettingsColumnCriteriaFactory(Container.Criteria));
            return this;
        }

        /// <summary>
        /// The index of the column relative to the filter range.
        /// </summary>
        /// <param name="value">The value that configures the index.</param>
        public SpreadsheetCustomFilterBuilder Index(double value)
        {
            Container.Index = value;

            return this;
        }

        /// <summary>
        /// The logical operator to apply to filter criteria.Possible values are and, or.
        /// </summary>
        /// <param name="value">The value that configures the logic.</param>
        public SpreadsheetCustomFilterBuilder Logic(SpreadsheetFilterLogic value)
        {
            Container.Logic = value.Serialize();

            return this;
        }
    }
}
