using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Editor
    /// </summary>
    public partial class EditorBuilder
        
    {
        /// <summary>
        /// Fine-tune deserialization in the Editor widget. Deserialization is the process of parsing the HTML string input from the value() method or from the viewHtml dialog into editable content.
        /// </summary>
        /// <param name="configurator">The configurator for the deserialization setting.</param>
        public EditorBuilder Deserialization(Action<EditorDeserializationSettingsBuilder> configurator)
        {

            Container.Deserialization.Editor = Container;
            configurator(new EditorDeserializationSettingsBuilder(Container.Deserialization));

            return this;
        }

        /// <summary>
        /// Relaxes the same-origin policy when using the iframe-based editor.
		/// This is done automatically for all cases except when the policy is relaxed by document.domain = document.domain.
		/// In that case, this property must be used to allow the editor to function properly across browsers.
		/// This property has been introduced in internal builds after 2014.1.319.
        /// </summary>
        /// <param name="value">The value for Domain</param>
        public EditorBuilder Domain(string value)
        {
            Container.Domain = value;
            return this;
        }

        /// <summary>
        /// Indicates whether the Editor should submit encoded HTML tags. By default, the submitted value is encoded.
        /// </summary>
        /// <param name="value">The value for Encoded</param>
        public EditorBuilder Encoded(bool value)
        {
            Container.Encoded = value;
            return this;
        }

        /// <summary>
        /// If enabled, the editor disables the editing and command execution in elements marked with editablecontent="false" attribute.
        /// </summary>
        /// <param name="configurator">The configurator for the immutables setting.</param>
        public EditorBuilder Immutables(Action<EditorImmutablesSettingsBuilder> configurator)
        {
            Container.Immutables.Enabled = true;

            Container.Immutables.Editor = Container;
            configurator(new EditorImmutablesSettingsBuilder(Container.Immutables));

            return this;
        }

        /// <summary>
        /// If enabled, the editor disables the editing and command execution in elements marked with editablecontent="false" attribute.
        /// </summary>
        public EditorBuilder Immutables()
        {
            Container.Immutables.Enabled = true;
            return this;
        }

        /// <summary>
        /// If enabled, the editor disables the editing and command execution in elements marked with editablecontent="false" attribute.
        /// </summary>
        /// <param name="enabled">Enables or disables the immutables option.</param>
        public EditorBuilder Immutables(bool enabled)
        {
            Container.Immutables.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Defines the text of the labels that are shown within the editor. Used primarily for localization.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public EditorBuilder Messages(Action<EditorMessagesSettingsBuilder> configurator)
        {

            Container.Messages.Editor = Container;
            configurator(new EditorMessagesSettingsBuilder(Container.Messages));

            return this;
        }

        /// <summary>
        /// Options for controlling how the pasting content is modified before it is added in the editor.
        /// </summary>
        /// <param name="configurator">The configurator for the pastecleanup setting.</param>
        public EditorBuilder PasteCleanup(Action<EditorPasteCleanupSettingsBuilder> configurator)
        {

            Container.PasteCleanup.Editor = Container;
            configurator(new EditorPasteCleanupSettingsBuilder(Container.PasteCleanup));

            return this;
        }

        /// <summary>
        /// Configures the Kendo UI Editor PDF export settings.
        /// </summary>
        /// <param name="configurator">The configurator for the pdf setting.</param>
        public EditorBuilder Pdf(Action<EditorPdfSettingsBuilder> configurator)
        {

            Container.Pdf.Editor = Container;
            configurator(new EditorPdfSettingsBuilder(Container.Pdf));

            return this;
        }

        /// <summary>
        /// If enabled, the editor renders a resize handle to allow users to resize it.
        /// </summary>
        /// <param name="configurator">The configurator for the resizable setting.</param>
        public EditorBuilder Resizable(Action<EditorResizableSettingsBuilder> configurator)
        {
            Container.Resizable.Enabled = true;

            Container.Resizable.Editor = Container;
            configurator(new EditorResizableSettingsBuilder(Container.Resizable));

            return this;
        }

        /// <summary>
        /// If enabled, the editor renders a resize handle to allow users to resize it.
        /// </summary>
        public EditorBuilder Resizable()
        {
            Container.Resizable.Enabled = true;
            return this;
        }

        /// <summary>
        /// If enabled, the editor renders a resize handle to allow users to resize it.
        /// </summary>
        /// <param name="enabled">Enables or disables the resizable option.</param>
        public EditorBuilder Resizable(bool enabled)
        {
            Container.Resizable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Allows setting of serialization options.
        /// </summary>
        /// <param name="configurator">The configurator for the serialization setting.</param>
        public EditorBuilder Serialization(Action<EditorSerializationSettingsBuilder> configurator)
        {

            Container.Serialization.Editor = Container;
            configurator(new EditorSerializationSettingsBuilder(Container.Serialization));

            return this;
        }

        /// <summary>
        /// A collection of tools that are used to interact with the Editor.
		/// Tools may be switched on by specifying their name.
		/// Custom tools and tools that require configuration are defined as objects.The available editor commands are:
        /// </summary>
        /// <param name="configurator">The configurator for the tools setting.</param>
        public EditorBuilder Tools(Action<EditorToolFactory> configurator)
        {

            configurator(new EditorToolFactory(Container.Tools)
            {
                Editor = Container
            });

            return this;
        }

        /// <summary>
        /// Configuration for image browser dialog.
        /// </summary>
        /// <param name="configurator">The configurator for the imagebrowser setting.</param>
        public EditorBuilder ImageBrowser(Action<EditorImageBrowserSettingsBuilder> configurator)
        {

            Container.ImageBrowser.Editor = Container;
            configurator(new EditorImageBrowserSettingsBuilder(Container.ImageBrowser));

            return this;
        }

        /// <summary>
        /// Configuration for file browser dialog.
        /// </summary>
        /// <param name="configurator">The configurator for the filebrowser setting.</param>
        public EditorBuilder FileBrowser(Action<EditorFileBrowserSettingsBuilder> configurator)
        {

            Container.FileBrowser.Editor = Container;
            configurator(new EditorFileBrowserSettingsBuilder(Container.FileBrowser));

            return this;
        }

        /// <summary>
        /// The tag that will be rendered. Defaults to "textarea". Triggers the inline edit mode if different.
        /// </summary>
        /// <param name="value">The value for Tag</param>
        public EditorBuilder Tag(string value)
        {
            Container.Tag = value;
            return this;
        }

        /// <summary>
        /// The content of the editor.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public EditorBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Editor()
        ///       .Name("Editor")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public EditorBuilder Events(Action<EditorEventBuilder> configurator)
        {
            configurator(new EditorEventBuilder(Container.Events));
            return this;
        }
        
    }
}

