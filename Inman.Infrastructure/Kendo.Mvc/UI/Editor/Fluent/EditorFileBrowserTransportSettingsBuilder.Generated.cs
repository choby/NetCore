using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserTransportSettings
    /// </summary>
    public partial class EditorFileBrowserTransportSettingsBuilder
        
    {
        /// <summary>
        /// Options or URL for remote file retrieval.
        /// </summary>
        /// <param name="configurator">The configurator for the read setting.</param>
        public EditorFileBrowserTransportSettingsBuilder Read(Action<EditorFileBrowserTransportReadSettingsBuilder> configurator)
        {

            Container.Read.Editor = Container.Editor;
            configurator(new EditorFileBrowserTransportReadSettingsBuilder(Container.Read));

            return this;
        }

        /// <summary>
        /// The URL which will handle the upload of the new files. If not specified the Upload button will not be displayed.
        /// </summary>
        /// <param name="value">The value for UploadUrl</param>
        public EditorFileBrowserTransportSettingsBuilder UploadUrl(string value)
        {
            Container.UploadUrl = value;
            return this;
        }

        /// <summary>
        /// The URL responsible for serving the original file. A file name placeholder should be specified. By default the placeholder value is URL encoded. If this is not desired, use a function.
        /// </summary>
        /// <param name="value">The value for FileUrl</param>
        public EditorFileBrowserTransportSettingsBuilder FileUrl(string value)
        {
            Container.FileUrlHandler = null;
            Container.FileUrl = value;
            return this;
        }
        /// <summary>
        /// The URL responsible for serving the original file. A file name placeholder should be specified. By default the placeholder value is URL encoded. If this is not desired, use a function.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorFileBrowserTransportSettingsBuilder FileUrlHandler(string handler)
        {
            Container.FileUrl = null;
            Container.FileUrlHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The URL responsible for serving the original file. A file name placeholder should be specified. By default the placeholder value is URL encoded. If this is not desired, use a function.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorFileBrowserTransportSettingsBuilder FileUrlHandler(Func<object, object> handler)
        {
            Container.FileUrl = null;
            Container.FileUrlHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Options or URL which will handle the file and directory deletion. If not specified the delete button will not be present.
        /// </summary>
        /// <param name="configurator">The configurator for the destroy setting.</param>
        public EditorFileBrowserTransportSettingsBuilder Destroy(Action<EditorFileBrowserTransportDestroySettingsBuilder> configurator)
        {

            Container.Destroy.Editor = Container.Editor;
            configurator(new EditorFileBrowserTransportDestroySettingsBuilder(Container.Destroy));

            return this;
        }

        /// <summary>
        /// Options or URL which will handle the directory creation. If not specified that create new folder button will not be present.
        /// </summary>
        /// <param name="configurator">The configurator for the create setting.</param>
        public EditorFileBrowserTransportSettingsBuilder Create(Action<EditorFileBrowserTransportCreateSettingsBuilder> configurator)
        {

            Container.Create.Editor = Container.Editor;
            configurator(new EditorFileBrowserTransportCreateSettingsBuilder(Container.Create));

            return this;
        }

    }
}
