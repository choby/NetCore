using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring FlatColorPickerMessagesSettings
    /// </summary>
    public partial class FlatColorPickerMessagesSettingsBuilder
        
    {
        /// <summary>
        /// Allows customization of "Apply" label.
        /// </summary>
        /// <param name="value">The value for Apply</param>
        public FlatColorPickerMessagesSettingsBuilder Apply(string value)
        {
            Container.Apply = value;
            return this;
        }

        /// <summary>
        /// Allows customization of "Cancel" label.
        /// </summary>
        /// <param name="value">The value for Cancel</param>
        public FlatColorPickerMessagesSettingsBuilder Cancel(string value)
        {
            Container.Cancel = value;
            return this;
        }

    }
}
