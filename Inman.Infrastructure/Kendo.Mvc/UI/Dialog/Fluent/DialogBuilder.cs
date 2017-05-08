using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Dialog
    /// </summary>
    public partial class DialogBuilder: WidgetBuilderBase<Dialog, DialogBuilder>
        
    {
        public DialogBuilder(Dialog component) : base(component)
        {
        }

        /// <summary>
		/// Configures the animation effects of the panelbar.
		/// </summary>
		/// <param name="animationAction">The action that configures the animation.</param>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .Animation(animation => animation.Expand)
		/// </code>
		/// </example>
		public DialogBuilder Animation(Action<PopupAnimationBuilder> animationAction)
        {
            animationAction(new PopupAnimationBuilder(Component.Animation));

            return this;
        }

        /// <summary>
		/// Configures the animation effects of the window.
		/// </summary>
		/// <param name="enable">Whether the component animation is enabled.</param>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .Animation(false)
		/// </code>
		/// </example>
		public DialogBuilder Animation(bool enable)
        {
            Component.Animation.Enabled = enable;

            return this;

        }

        // Place custom settings here
    }
}

