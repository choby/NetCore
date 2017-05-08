using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ListViewSelectableSettings
    /// </summary>
    public partial class ListViewSelectableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Represents the selection modes supported by Kendo UI ListView for ASP.NET MVC
        /// </summary>
        /// <param name="value">The value for Mode</param>
        public ListViewSelectableSettingsBuilder<T> Mode(ListViewSelectionMode value)
        {
            Container.Mode = value;
            return this;
        }

    }
}
