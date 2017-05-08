using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Upload
    /// </summary>
    public partial class UploadBuilder
        
    {
        /// <summary>
        /// Configures the ability to upload a file(s) in an asynchronous manner. Please refer to the
		/// async mode help topic
		/// for more details.
        /// </summary>
        /// <param name="configurator">The configurator for the async setting.</param>
        public UploadBuilder Async(Action<UploadAsyncSettingsBuilder> configurator)
        {

            Container.Async.Upload = Container;
            configurator(new UploadAsyncSettingsBuilder(Container.Async));

            return this;
        }

        /// <summary>
        /// Initializes a dropzone element(s) based on a given selector that provides drag and drop file upload.
        /// </summary>
        /// <param name="value">The value for DropZone</param>
        public UploadBuilder DropZone(string value)
        {
            Container.DropZone = value;
            return this;
        }

        /// <summary>
        /// List of files to be initially rendered in the Upload widget files list.
        /// </summary>
        /// <param name="configurator">The configurator for the files setting.</param>
        public UploadBuilder Files(Action<UploadFileFactory> configurator)
        {

            configurator(new UploadFileFactory(Container.Files)
            {
                Upload = Container
            });

            return this;
        }

        /// <summary>
        /// Enables (true) or disables (false) the ability to select multiple files.
		/// If false, users will be able to select only one file at a time. Note: This option does not
		/// limit the total number of uploaded files in an asynchronous configuration.
        /// </summary>
        /// <param name="value">The value for Multiple</param>
        public UploadBuilder Multiple(bool value)
        {
            Container.Multiple = value;
            return this;
        }

        /// <summary>
        /// Enables (true) or disables (false) the ability to display a file listing
		/// for uploading a file(s). Disabling a file listing may be useful you wish to customize the UI; use the
		/// client-side events to build your own UI.
        /// </summary>
        /// <param name="value">The value for ShowFileList</param>
        public UploadBuilder ShowFileList(bool value)
        {
            Container.ShowFileList = value;
            return this;
        }

        /// <summary>
        /// The template used to render the files in the list
        /// </summary>
        /// <param name="value">The value for Template</param>
        public UploadBuilder Template(string value)
        {
            Container.Template = value;
            return this;
        }

        /// <summary>
        /// The template used to render the files in the list
        /// </summary>
        /// <param name="value">The ID of the template element for Template</param>
        public UploadBuilder TemplateId(string templateId)
        {
            Container.TemplateId = templateId;
            return this;
        }

        /// <summary>
        /// Configures the validation options for uploaded files.
        /// </summary>
        /// <param name="configurator">The configurator for the validation setting.</param>
        public UploadBuilder Validation(Action<UploadValidationSettingsBuilder> configurator)
        {

            Container.Validation.Upload = Container;
            configurator(new UploadValidationSettingsBuilder(Container.Validation));

            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Upload()
        ///       .Name("Upload")
        ///       .Events(events => events
        ///           .Cancel("onCancel")
        ///       )
        /// )
        /// </code>
        /// </example>
        public UploadBuilder Events(Action<UploadEventBuilder> configurator)
        {
            configurator(new UploadEventBuilder(Container.Events));
            return this;
        }
        
    }
}

