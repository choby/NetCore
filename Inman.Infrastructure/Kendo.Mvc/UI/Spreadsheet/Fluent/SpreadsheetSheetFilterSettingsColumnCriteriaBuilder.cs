using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetFilterSettingsColumnCriteria
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsColumnCriteriaBuilder
        
    {
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder(SpreadsheetSheetFilterSettingsColumnCriteria container)
        {
            Container = container;
        }

        protected SpreadsheetSheetFilterSettingsColumnCriteria Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The value for the criteria operator.
        /// </summary>
        /// <param name="value">The value that configures the value.</param>
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(string value)
        {
            Container.Value = value;

            return this;
        }

        /// <summary>
        /// The value for the criteria operator.
        /// </summary>
        /// <param name="value">The value that configures the value.</param>
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(DateTime value)
        {
            Container.Value = value;

            return this;
        }

        /// <summary>
        /// The value for the criteria operator.
        /// </summary>
        /// <param name="value">The value that configures the value.</param>
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(double value)
        {
            Container.Value = value;

            return this;
        }
    }
}
