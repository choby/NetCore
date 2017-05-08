using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DropDownListPopupSettings
    /// </summary>
    public partial class DropDownListPopupSettingsBuilder
        
    {
        public DropDownListPopupSettingsBuilder(DropDownListPopupSettings container)
        {
            Container = container;
        }

        protected DropDownListPopupSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
