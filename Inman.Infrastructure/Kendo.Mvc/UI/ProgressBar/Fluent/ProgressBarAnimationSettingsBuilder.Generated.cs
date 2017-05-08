using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ProgressBarAnimationSettings
    /// </summary>
    public partial class ProgressBarAnimationSettingsBuilder
        
    {
        /// <summary>
        /// The duration of each progress animation in milliseconds.
        /// </summary>
        /// <param name="value">The value for Duration</param>
        public ProgressBarAnimationSettingsBuilder Duration(double value)
        {
            Container.Duration = value;
            return this;
        }

    }
}
