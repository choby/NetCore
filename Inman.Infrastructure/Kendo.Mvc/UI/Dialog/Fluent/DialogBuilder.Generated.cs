using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Dialog
    /// </summary>
    public partial class DialogBuilder
        
    {
        /// <summary>
        /// A collection of objects containing text, action and primary attributes used to specify the dialog buttons.
		/// #### Example
        /// </summary>
        /// <param name="configurator">The configurator for the actions setting.</param>
        public DialogBuilder Actions(Action<DialogActionFactory> configurator)
        {

            configurator(new DialogActionFactory(Container.Actions)
            {
                Dialog = Container
            });

            return this;
        }

        /// <summary>
        /// Specifies the possible layout of the action buttons in the Dialog.Possible values are:
        /// </summary>
        /// <param name="value">The value for ButtonLayout</param>
        public DialogBuilder ButtonLayout(string value)
        {
            Container.ButtonLayout = value;
            return this;
        }

        /// <summary>
        /// Specifies whether a close button should be rendered at the top corner of the dialog.
        /// </summary>
        /// <param name="value">The value for Closable</param>
        public DialogBuilder Closable(bool value)
        {
            Container.Closable = value;
            return this;
        }

        /// <summary>
        /// Specifies height of the dialog.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public DialogBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The maximum height (in pixels) that may be achieved by resizing the dialog.
        /// </summary>
        /// <param name="value">The value for MaxHeight</param>
        public DialogBuilder MaxHeight(double value)
        {
            Container.MaxHeight = value;
            return this;
        }

        /// <summary>
        /// The maximum width (in pixels) that may be achieved by resizing the dialog.
        /// </summary>
        /// <param name="value">The value for MaxWidth</param>
        public DialogBuilder MaxWidth(double value)
        {
            Container.MaxWidth = value;
            return this;
        }

        /// <summary>
        /// Defines the text of the labels that are shown within the dialog. Used primarily for localization.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public DialogBuilder Messages(Action<DialogMessagesSettingsBuilder> configurator)
        {

            Container.Messages.Dialog = Container;
            configurator(new DialogMessagesSettingsBuilder(Container.Messages));

            return this;
        }

        /// <summary>
        /// The minimum height (in pixels) that may be achieved by resizing the dialog.
        /// </summary>
        /// <param name="value">The value for MinHeight</param>
        public DialogBuilder MinHeight(double value)
        {
            Container.MinHeight = value;
            return this;
        }

        /// <summary>
        /// The minimum width (in pixels) that may be achieved by resizing the dialog.
        /// </summary>
        /// <param name="value">The value for MinWidth</param>
        public DialogBuilder MinWidth(double value)
        {
            Container.MinWidth = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the dialog should show a modal overlay over the page.
        /// </summary>
        /// <param name="value">The value for Modal</param>
        public DialogBuilder Modal(bool value)
        {
            Container.Modal = value;
            return this;
        }

        /// <summary>
        /// The text in the dialog title bar. If false, the dialog will be displayed without a title bar.
        /// </summary>
        /// <param name="value">The value for Title</param>
        public DialogBuilder Title(string value)
        {
            Container.Title = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the dialog will be initially visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public DialogBuilder Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// Specifies width of the dialog.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public DialogBuilder Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The content of the dialog
        /// </summary>
        /// <param name="value">The value for Content</param>
        public DialogBuilder Content(string value)
        {
            Container.Content = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Dialog()
        ///       .Name("Dialog")
        ///       .Events(events => events
        ///           .Close("onClose")
        ///       )
        /// )
        /// </code>
        /// </example>
        public DialogBuilder Events(Action<DialogEventBuilder> configurator)
        {
            configurator(new DialogEventBuilder(Container.Events));
            return this;
        }
        
    }
}

