using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserTransportSettings
    /// </summary>
    public partial class EditorImageBrowserTransportSettingsBuilder
        
    {
        /// <summary>
        /// Options or URL for remote image retrieval.
        /// </summary>
        /// <param name="configurator">The configurator for the read setting.</param>
        public EditorImageBrowserTransportSettingsBuilder Read(Action<EditorImageBrowserTransportReadSettingsBuilder> configurator)
        {

            Container.Read.Editor = Container.Editor;
            configurator(new EditorImageBrowserTransportReadSettingsBuilder(Container.Read));

            return this;
        }

        /// <summary>
        /// The URL for retrieving the thumbnail version of the image. If not specified a default image icon will be shown.
		/// If function is assigned, the current path and image name will be provided.
        /// </summary>
        /// <param name="value">The value for ThumbnailUrl</param>
        public EditorImageBrowserTransportSettingsBuilder ThumbnailUrl(string value)
        {
            Container.ThumbnailUrlHandler = null;
            Container.ThumbnailUrl = value;
            return this;
        }
        /// <summary>
        /// The URL for retrieving the thumbnail version of the image. If not specified a default image icon will be shown.
		/// If function is assigned, the current path and image name will be provided.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorImageBrowserTransportSettingsBuilder ThumbnailUrlHandler(string handler)
        {
            Container.ThumbnailUrl = null;
            Container.ThumbnailUrlHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The URL for retrieving the thumbnail version of the image. If not specified a default image icon will be shown.
		/// If function is assigned, the current path and image name will be provided.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorImageBrowserTransportSettingsBuilder ThumbnailUrlHandler(Func<object, object> handler)
        {
            Container.ThumbnailUrl = null;
            Container.ThumbnailUrlHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The URL which will handle the upload of the new images. If not specified the Upload button will not be displayed.The requirements for this handler are the same as for the save handler in the Upload widget.
        /// </summary>
        /// <param name="value">The value for UploadUrl</param>
        public EditorImageBrowserTransportSettingsBuilder UploadUrl(string value)
        {
            Container.UploadUrl = value;
            return this;
        }

        /// <summary>
        /// The URL responsible for serving the original image. A file name placeholder should be specified. By default the placeholder value is URL encoded. If this is not desired, use a function.
        /// </summary>
        /// <param name="value">The value for ImageUrl</param>
        public EditorImageBrowserTransportSettingsBuilder ImageUrl(string value)
        {
            Container.ImageUrlHandler = null;
            Container.ImageUrl = value;
            return this;
        }
        /// <summary>
        /// The URL responsible for serving the original image. A file name placeholder should be specified. By default the placeholder value is URL encoded. If this is not desired, use a function.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorImageBrowserTransportSettingsBuilder ImageUrlHandler(string handler)
        {
            Container.ImageUrl = null;
            Container.ImageUrlHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The URL responsible for serving the original image. A file name placeholder should be specified. By default the placeholder value is URL encoded. If this is not desired, use a function.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorImageBrowserTransportSettingsBuilder ImageUrlHandler(Func<object, object> handler)
        {
            Container.ImageUrl = null;
            Container.ImageUrlHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// Options or URL which will handle the file and directory deletion. If not specified the delete button will not be present.
        /// </summary>
        /// <param name="configurator">The configurator for the destroy setting.</param>
        public EditorImageBrowserTransportSettingsBuilder Destroy(Action<EditorImageBrowserTransportDestroySettingsBuilder> configurator)
        {

            Container.Destroy.Editor = Container.Editor;
            configurator(new EditorImageBrowserTransportDestroySettingsBuilder(Container.Destroy));

            return this;
        }

        /// <summary>
        /// Options or URL which will handle the directory creation. If not specified that create new folder button will not be present.
        /// </summary>
        /// <param name="configurator">The configurator for the create setting.</param>
        public EditorImageBrowserTransportSettingsBuilder Create(Action<EditorImageBrowserTransportCreateSettingsBuilder> configurator)
        {

            Container.Create.Editor = Container.Editor;
            configurator(new EditorImageBrowserTransportCreateSettingsBuilder(Container.Create));

            return this;
        }

    }
}
