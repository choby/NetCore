using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ColorPickerMessagesSettings
    /// </summary>
    public partial class ColorPickerMessagesSettingsBuilder
        
    {
        /// <summary>
        /// Allows customization of the "Apply" button text.
        /// </summary>
        /// <param name="value">The value for Apply</param>
        public ColorPickerMessagesSettingsBuilder Apply(string value)
        {
            Container.Apply = value;
            return this;
        }

        /// <summary>
        /// Allows customization of the "Cancel" button text.
        /// </summary>
        /// <param name="value">The value for Cancel</param>
        public ColorPickerMessagesSettingsBuilder Cancel(string value)
        {
            Container.Cancel = value;
            return this;
        }

    }
}
