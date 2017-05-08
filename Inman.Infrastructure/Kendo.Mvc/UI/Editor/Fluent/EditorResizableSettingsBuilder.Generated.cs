using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorResizableSettings
    /// </summary>
    public partial class EditorResizableSettingsBuilder
        
    {
        /// <summary>
        /// If enabled, the editor renders a resize handle to allow users to resize it.
        /// </summary>
        /// <param name="value">The value for Content</param>
        public EditorResizableSettingsBuilder Content(bool value)
        {
            Container.Content = value;
            return this;
        }

        /// <summary>
        /// The minimum height that the editor can be resized to.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public EditorResizableSettingsBuilder Min(double value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// The maximum height that the editor can be resized to.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public EditorResizableSettingsBuilder Max(double value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// If resizable is set to true the widget will detect changes in the viewport width and will hide the overflowing controls in the tool overflow popup.
        /// </summary>
        /// <param name="value">The value for Toolbar</param>
        public EditorResizableSettingsBuilder Toolbar(bool value)
        {
            Container.Toolbar = value;
            return this;
        }

    }
}
