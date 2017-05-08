using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ComboBoxPopupSettings
    /// </summary>
    public partial class ComboBoxPopupSettingsBuilder
        
    {
        /// <summary>
        /// Defines a jQuery selector that will be used to find a container element, where the popup will be appended to.
        /// </summary>
        /// <param name="value">The value for AppendTo</param>
        public ComboBoxPopupSettingsBuilder AppendTo(string value)
        {
            Container.AppendTo = value;
            return this;
        }

        /// <summary>
        /// Specifies how to position the popup element based on anchor point. The value is
		/// space separated "y" plus "x" position.The available "y" positions are:
		/// - "bottom"
		/// - "center"
		/// - "top"The available "x" positions are:
		/// - "left"
		/// - "center"
		/// - "right"
        /// </summary>
        /// <param name="value">The value for Origin</param>
        public ComboBoxPopupSettingsBuilder Origin(string value)
        {
            Container.Origin = value;
            return this;
        }

        /// <summary>
        /// Specifies which point of the popup element to attach to the anchor's origin point. The value is
		/// space separated "y" plus "x" position.The available "y" positions are:
		/// - "bottom"
		/// - "center"
		/// - "top"The available "x" positions are:
		/// - "left"
		/// - "center"
		/// - "right"
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ComboBoxPopupSettingsBuilder Position(string value)
        {
            Container.Position = value;
            return this;
        }

    }
}
