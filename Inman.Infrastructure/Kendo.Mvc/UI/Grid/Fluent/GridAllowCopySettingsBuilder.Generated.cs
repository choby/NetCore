using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridAllowCopySettings
    /// </summary>
    public partial class GridAllowCopySettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Changes the delimeter between the items on the same row. Use this option if you want to change the default TSV format to CSV - set the delimeter to comma ','.
        /// </summary>
        /// <param name="value">The value for Delimeter</param>
        public GridAllowCopySettingsBuilder<T> Delimeter(string value)
        {
            Container.Delimeter = value;
            return this;
        }

    }
}
