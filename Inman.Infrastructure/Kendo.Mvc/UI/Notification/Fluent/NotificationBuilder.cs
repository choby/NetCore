using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Notification
    /// </summary>
    public partial class NotificationBuilder: WidgetBuilderBase<Notification, NotificationBuilder>
        
    {
        public NotificationBuilder(Notification component) : base(component)
        {
        }

		/// <summary>Sets the Notification HTML tag. A SPAN tag is used by default.</summary>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().Notification()
		///            .Name("Notification")
		///            .Tag("div")
		/// %&gt;
		/// </code>
		/// </example>
		public NotificationBuilder Tag(string tag)
		{
			Component.Tag = tag;

			return this;
		}

		/// <summary>Defines the width of the notifications to be displayed.</summary>
		public NotificationBuilder Width(int value)
		{
			Component.Width = value.ToString() + "px";

			return this;
		}

		/// <summary>Defines the height of the notifications to be displayed.</summary>
		public NotificationBuilder Height(int value)
		{
			Component.Height = value.ToString() + "px";

			return this;
		}

		/// <summary>Configures the Notification templates.</summary>
		public NotificationBuilder Templates(Action<NotificationTemplateFactory> configurator)
		{
			var builder = new NotificationTemplateFactory(Component);

			configurator(builder);

			return this;
		}

		/// <summary>
		/// Configures the animation effects of the displayed notifications.
		/// </summary>
		/// <param name="animationAction">The action that configures the animation.</param>
		public NotificationBuilder Animation(Action<PopupAnimationBuilder> animationAction)
		{
			animationAction(new PopupAnimationBuilder(Component.Animation));

			return this;
		}
	}
}

