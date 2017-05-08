using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserSettings
    /// </summary>
    public partial class EditorImageBrowserSettingsBuilder
        
    {
        /// <summary>
        /// Defines the allowed file extensions.
        /// </summary>
        /// <param name="value">The value for FileTypes</param>
        public EditorImageBrowserSettingsBuilder FileTypes(string value)
        {
            Container.FileTypes = value;
            return this;
        }

        /// <summary>
        /// Defines the initial folder to display, relative to the root.
        /// </summary>
        /// <param name="value">The value for Path</param>
        public EditorImageBrowserSettingsBuilder Path(string value)
        {
            Container.Path = value;
            return this;
        }

        /// <summary>
        /// Specifies the settings for loading and saving data.
        /// </summary>
        /// <param name="configurator">The configurator for the transport setting.</param>
        public EditorImageBrowserSettingsBuilder Transport(Action<EditorImageBrowserTransportSettingsBuilder> configurator)
        {

            Container.Transport.Editor = Container.Editor;
            configurator(new EditorImageBrowserTransportSettingsBuilder(Container.Transport));

            return this;
        }

        /// <summary>
        /// Set the object responsible for describing the image raw data format.
        /// </summary>
        /// <param name="configurator">The configurator for the schema setting.</param>
        public EditorImageBrowserSettingsBuilder Schema(Action<EditorImageBrowserSchemaSettingsBuilder> configurator)
        {

            Container.Schema.Editor = Container.Editor;
            configurator(new EditorImageBrowserSchemaSettingsBuilder(Container.Schema));

            return this;
        }

        /// <summary>
        /// Defines texts shown within the image browser.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public EditorImageBrowserSettingsBuilder Messages(Action<EditorImageBrowserMessagesSettingsBuilder> configurator)
        {

            Container.Messages.Editor = Container.Editor;
            configurator(new EditorImageBrowserMessagesSettingsBuilder(Container.Messages));

            return this;
        }

    }
}
