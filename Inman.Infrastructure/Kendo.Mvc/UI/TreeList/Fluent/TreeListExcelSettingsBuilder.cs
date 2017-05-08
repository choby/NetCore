using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListExcelSettings
    /// </summary>
    public partial class TreeListExcelSettingsBuilder<T>
        
    {
        public TreeListExcelSettingsBuilder(TreeListExcelSettings<T> container)
        {
            Container = container;
        }

        protected TreeListExcelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
