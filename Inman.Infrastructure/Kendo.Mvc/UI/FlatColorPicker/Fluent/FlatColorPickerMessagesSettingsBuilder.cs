using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring FlatColorPickerMessagesSettings
    /// </summary>
    public partial class FlatColorPickerMessagesSettingsBuilder
        
    {
        public FlatColorPickerMessagesSettingsBuilder(FlatColorPickerMessagesSettings container)
        {
            Container = container;
        }

        protected FlatColorPickerMessagesSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
