using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisLabelsSettings
    /// </summary>
    public partial class ChartValueAxisLabelsSettingsBuilder<T>
        where T : class
    {
        public ChartValueAxisLabelsSettingsBuilder(ChartValueAxisLabelsSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisLabelsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        /// <summary>
        /// Sets the labels margin.
        /// </summary>        
        public ChartValueAxisLabelsSettingsBuilder<T> Margin(int top, int right, int bottom, int left)
        {
            Container.Margin.Top = top;
            Container.Margin.Right = right;
            Container.Margin.Bottom = bottom;
            Container.Margin.Left = left;
            return this;
        }

        /// <summary>
        /// Sets the labels padding.
        /// </summary>       
        public ChartValueAxisLabelsSettingsBuilder<T> Padding(int top, int right, int bottom, int left)
        {
            Container.Padding.Top = top;
            Container.Padding.Right = right;
            Container.Padding.Bottom = bottom;
            Container.Padding.Left = left;
            return this;
        }

        /// <summary>
        /// The rotation angle of the labels. By default the labels are not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public ChartValueAxisLabelsSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation.Angle = value;
            return this;
        }        
    }
}
