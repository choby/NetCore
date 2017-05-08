using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesLineSettings
    /// </summary>
    public partial class ChartValueAxisNotesLineSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The dash type of the note line.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartValueAxisNotesLineSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The line width of the notes.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartValueAxisNotesLineSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The line color of the notes.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartValueAxisNotesLineSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The length of the connecting lines in pixels.
        /// </summary>
        /// <param name="value">The value for Length</param>
        public ChartValueAxisNotesLineSettingsBuilder<T> Length(double value)
        {
            Container.Length = value;
            return this;
        }

    }
}
