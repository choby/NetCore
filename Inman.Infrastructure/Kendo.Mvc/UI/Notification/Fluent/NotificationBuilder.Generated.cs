using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Notification
    /// </summary>
    public partial class NotificationBuilder
        
    {
        /// <summary>
        /// Indicates the period in milliseconds after which a notification can be dismissed (hidden) by the user.
        /// </summary>
        /// <param name="value">The value for AllowHideAfter</param>
        public NotificationBuilder AllowHideAfter(double value)
        {
            Container.AllowHideAfter = value;
            return this;
        }

        /// <summary>
        /// Defines the element to which the notifications will be appended or prepended (depending on the stacking direction).
        /// </summary>
        /// <param name="value">The value for AppendTo</param>
        public NotificationBuilder AppendTo(string value)
        {
            Container.AppendTo = value;
            return this;
        }

        /// <summary>
        /// Indicates the period in milliseconds after which a notification disappears automatically. Setting a zero value disables this behavior.
        /// </summary>
        /// <param name="value">The value for AutoHideAfter</param>
        public NotificationBuilder AutoHideAfter(double value)
        {
            Container.AutoHideAfter = value;
            return this;
        }

        /// <summary>
        /// Determines whether the notifications will include a hide button. This setting works with the built-in templates only.
        /// </summary>
        /// <param name="value">The value for Button</param>
        public NotificationBuilder Button(bool value)
        {
            Container.Button = value;
            return this;
        }

        /// <summary>
        /// Determines whether the notifications will include a hide button. This setting works with the built-in templates only.
        /// </summary>
        public NotificationBuilder Button()
        {
            Container.Button = true;
            return this;
        }

        /// <summary>
        /// Defines the notifications' height. Numbers are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public NotificationBuilder Height(string value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// Determines whether notifications can be hidden by clicking anywhere on their content.
        /// </summary>
        /// <param name="value">The value for HideOnClick</param>
        public NotificationBuilder HideOnClick(bool value)
        {
            Container.HideOnClick = value;
            return this;
        }

        /// <summary>
        /// This setting applies to popup notifications only, i.e. in cases when appendTo is not set.
		/// It determines the position of the first notification on the screen, as well as whether the notifications will move together with the page content during scrolling.
		/// top takes precedence over bottom and left takes precedence over right.
        /// </summary>
        /// <param name="configurator">The configurator for the position setting.</param>
        public NotificationBuilder Position(Action<NotificationPositionSettingsBuilder> configurator)
        {

            Container.Position.Notification = Container;
            configurator(new NotificationPositionSettingsBuilder(Container.Position));

            return this;
        }

        /// <summary>
        /// Defines the notifications' width. Numbers are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public NotificationBuilder Width(string value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">The value for Stacking</param>
        public NotificationBuilder Stacking(NotificationStackingSettings value)
        {
            Container.Stacking = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Notification()
        ///       .Name("Notification")
        ///       .Events(events => events
        ///           .Hide("onHide")
        ///       )
        /// )
        /// </code>
        /// </example>
        public NotificationBuilder Events(Action<NotificationEventBuilder> configurator)
        {
            configurator(new NotificationEventBuilder(Container.Events));
            return this;
        }
        
    }
}

