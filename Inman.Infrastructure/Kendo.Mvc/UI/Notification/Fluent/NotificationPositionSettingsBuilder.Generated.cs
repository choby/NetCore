using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring NotificationPositionSettings
    /// </summary>
    public partial class NotificationPositionSettingsBuilder
        
    {
        /// <summary>
        /// Determines the pixel position of the first popup notification with regard to the viewport's bottom edge.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public NotificationPositionSettingsBuilder Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// Determines the pixel position of the first popup notification with regard to the viewport's left edge.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public NotificationPositionSettingsBuilder Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// Determines whether the popup notifications will move together with the other page content during scrolling.
        /// </summary>
        /// <param name="value">The value for Pinned</param>
        public NotificationPositionSettingsBuilder Pinned(bool value)
        {
            Container.Pinned = value;
            return this;
        }

        /// <summary>
        /// Determines the pixel position of the first popup notification with regard to the viewport's right edge.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public NotificationPositionSettingsBuilder Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// Determines the position of the first popup notification with regard to the viewport's top edge. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public NotificationPositionSettingsBuilder Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
