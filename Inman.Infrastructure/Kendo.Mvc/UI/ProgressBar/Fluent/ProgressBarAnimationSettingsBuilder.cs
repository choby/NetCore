using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ProgressBarAnimationSettings
    /// </summary>
    public partial class ProgressBarAnimationSettingsBuilder
        
    {
        public ProgressBarAnimationSettingsBuilder(ProgressBarAnimationSettings container)
        {
            Container = container;
        }

        protected ProgressBarAnimationSettings Container
        {
            get;
            private set;
        }

		/// <summary>
		/// Enables or disables the progress animation
		/// </summary>
		/// <param name="enable">The boolean value</param>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().ProgressBar()
		///     .Name(&quot;progressBar&quot;)
		///     .Animation(a => a.Enable(false))
		/// %&gt;
		/// </code>
		/// </example>
		public ProgressBarAnimationSettingsBuilder Enable(bool enable)
		{
			Container.Enable = enable;

			return this;
		}
	}
}
