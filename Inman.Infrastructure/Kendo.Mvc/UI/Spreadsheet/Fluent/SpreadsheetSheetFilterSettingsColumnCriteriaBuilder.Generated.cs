using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetFilterSettingsColumnCriteria
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsColumnCriteriaBuilder
        
    {
        /// <summary>
        /// The criterion operator type.
        /// </summary>
        /// <param name="value">The value for Operator</param>
        public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Operator(SpreadsheetFilterOperator value)
        {
            Container.Operator = value;
            return this;
        }

    }
}
