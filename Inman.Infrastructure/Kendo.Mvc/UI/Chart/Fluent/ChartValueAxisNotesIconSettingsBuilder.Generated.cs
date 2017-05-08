using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesIconSettings
    /// </summary>
    public partial class ChartValueAxisNotesIconSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the notes icon.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartValueAxisNotesIconSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the icon.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartValueAxisNotesIconSettingsBuilder<T> Border(Action<ChartValueAxisNotesIconBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartValueAxisNotesIconBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The size of the icon.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartValueAxisNotesIconSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// The icon shape.The supported values are:
		/// * "circle" - the marker shape is circle.
		/// * "square" - the marker shape is square.
		/// * "triangle" - the marker shape is triangle.
		/// * "cross" - the marker shape is cross.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ChartValueAxisNotesIconSettingsBuilder<T> Type(string value)
        {
            Container.Type = value;
            return this;
        }

        /// <summary>
        /// The icon visibility.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartValueAxisNotesIconSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

    }
}
