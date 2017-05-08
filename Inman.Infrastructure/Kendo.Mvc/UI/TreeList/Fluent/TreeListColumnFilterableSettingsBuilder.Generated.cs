using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnFilterableSettings
    /// </summary>
    public partial class TreeListColumnFilterableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The role data attribute of the widget used in the filter menu or a JavaScript function which initializes that widget.
        /// </summary>
        /// <param name="value">The value for Ui</param>
        public TreeListColumnFilterableSettingsBuilder<T> Ui(string value)
        {
            Container.Ui = value;
            return this;
        }

    }
}
