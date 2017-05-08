using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsPaddingSettings
    /// </summary>
    public partial class ChartSeriesLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the labels.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartSeriesLabelsPaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the labels.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartSeriesLabelsPaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the labels.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartSeriesLabelsPaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the labels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartSeriesLabelsPaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
