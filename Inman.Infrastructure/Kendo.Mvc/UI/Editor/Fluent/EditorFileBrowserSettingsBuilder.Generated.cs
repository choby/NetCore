using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserSettings
    /// </summary>
    public partial class EditorFileBrowserSettingsBuilder
        
    {
        /// <summary>
        /// Defines the allowed file extensions.
        /// </summary>
        /// <param name="value">The value for FileTypes</param>
        public EditorFileBrowserSettingsBuilder FileTypes(string value)
        {
            Container.FileTypes = value;
            return this;
        }

        /// <summary>
        /// Defines the initial folder to display, relative to the root.
        /// </summary>
        /// <param name="value">The value for Path</param>
        public EditorFileBrowserSettingsBuilder Path(string value)
        {
            Container.Path = value;
            return this;
        }

        /// <summary>
        /// Specifies the settings for loading and saving data.
        /// </summary>
        /// <param name="configurator">The configurator for the transport setting.</param>
        public EditorFileBrowserSettingsBuilder Transport(Action<EditorFileBrowserTransportSettingsBuilder> configurator)
        {

            Container.Transport.Editor = Container.Editor;
            configurator(new EditorFileBrowserTransportSettingsBuilder(Container.Transport));

            return this;
        }

        /// <summary>
        /// Set the object responsible for describing the file raw data format.
        /// </summary>
        /// <param name="configurator">The configurator for the schema setting.</param>
        public EditorFileBrowserSettingsBuilder Schema(Action<EditorFileBrowserSchemaSettingsBuilder> configurator)
        {

            Container.Schema.Editor = Container.Editor;
            configurator(new EditorFileBrowserSchemaSettingsBuilder(Container.Schema));

            return this;
        }

        /// <summary>
        /// Defines texts shown within the file browser.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public EditorFileBrowserSettingsBuilder Messages(Action<EditorFileBrowserMessagesSettingsBuilder> configurator)
        {

            Container.Messages.Editor = Container.Editor;
            configurator(new EditorFileBrowserMessagesSettingsBuilder(Container.Messages));

            return this;
        }

    }
}
