using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ProgressBar
    /// </summary>
    public partial class ProgressBarBuilder: WidgetBuilderBase<ProgressBar, ProgressBarBuilder>
        
    {
        public ProgressBarBuilder(ProgressBar component) : base(component)
        {
        }

		/// <summary>
		/// Use to enable or disable the animation.
		/// </summary>
		/// <param name="enable">The boolean value.</param>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().ProgressBar()
		///     .Name(&quot;progressBar&quot;)
		///     .Animation(false)
		/// %&gt;
		/// </code>
		/// </example>
		public ProgressBarBuilder Animation(bool enable)
		{
			Container.Animation.Enable = enable;

			return this;
		}

		/// <summary>
		/// Sets the initial value of the ProgressBar
		/// </summary>
		/// <param name="value">Number specifying the value</param>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().ProgressBar()
		///     .Name(&quot;progressBar&quot;)
		///     .Min(100)
		///     .Max(200)
		///     .Value(100)
		/// %&gt;
		/// </code>
		/// </example>
		public ProgressBarBuilder Value(double value)
		{
			Container.Value = value;

			return this;
		}

		/// <summary>
		/// Sets the initial value of the ProgressBar
		/// </summary>
		/// <param name="value">Pass false to set indeterminate value</param>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().ProgressBar()
		///     .Name(&quot;progressBar&quot;)
		///     .Min(100)
		///     .Max(200)
		///     .Value(false)
		/// %&gt;
		/// </code>
		/// </example>
		public ProgressBarBuilder Value(bool value)
		{
			Container.Value = value;

			return this;
		}
	}
}

