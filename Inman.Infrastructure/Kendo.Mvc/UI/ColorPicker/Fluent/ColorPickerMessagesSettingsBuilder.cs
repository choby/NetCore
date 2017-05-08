using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ColorPickerMessagesSettings
    /// </summary>
    public partial class ColorPickerMessagesSettingsBuilder
        
    {
        public ColorPickerMessagesSettingsBuilder(ColorPickerMessagesSettings container)
        {
            Container = container;
        }

        protected ColorPickerMessagesSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
