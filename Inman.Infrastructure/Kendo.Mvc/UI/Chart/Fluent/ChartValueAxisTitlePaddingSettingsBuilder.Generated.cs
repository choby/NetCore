using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisTitlePaddingSettings
    /// </summary>
    public partial class ChartValueAxisTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The bottom padding of the title.
        /// </summary>
        /// <param name="value">The value for Bottom</param>
        public ChartValueAxisTitlePaddingSettingsBuilder<T> Bottom(double value)
        {
            Container.Bottom = value;
            return this;
        }

        /// <summary>
        /// The left padding of the title.
        /// </summary>
        /// <param name="value">The value for Left</param>
        public ChartValueAxisTitlePaddingSettingsBuilder<T> Left(double value)
        {
            Container.Left = value;
            return this;
        }

        /// <summary>
        /// The right padding of the title.
        /// </summary>
        /// <param name="value">The value for Right</param>
        public ChartValueAxisTitlePaddingSettingsBuilder<T> Right(double value)
        {
            Container.Right = value;
            return this;
        }

        /// <summary>
        /// The top padding of the title.
        /// </summary>
        /// <param name="value">The value for Top</param>
        public ChartValueAxisTitlePaddingSettingsBuilder<T> Top(double value)
        {
            Container.Top = value;
            return this;
        }

    }
}
