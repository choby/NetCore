using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLabelsPaddingSettings
    /// </summary>
    public partial class ChartXAxisLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the labels.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartXAxisLabelsPaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the labels.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartXAxisLabelsPaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the labels.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartXAxisLabelsPaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the labels.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartXAxisLabelsPaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
