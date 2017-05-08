using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring UploadLocalizationSettings
    /// </summary>
    public partial class UploadMessagesSettingsBuilder
        
    {
        public UploadMessagesSettingsBuilder(UploadMessagesSettings container)
        {
            Container = container;
        }

        protected UploadMessagesSettings Container
        {
            get;
            private set;
        }

		/// <summary>
		/// Sets the text of the cancel button text.
		/// </summary>
		/// <param name="value">The value for Cancel</param>
		public UploadMessagesSettingsBuilder Cancel(string value)
		{
			Container.Cancel = value;
			return this;
		}

		/// <summary>
		/// Sets the drop zone hint.
		/// </summary>
		/// <param name="value">The value for DropFilesHere</param>
		public UploadMessagesSettingsBuilder DropFilesHere(string value)
		{
			Container.DropFilesHere = value;
			return this;
		}

		/// <summary>
		/// Sets the header status message for uploaded files.
		/// </summary>
		/// <param name="value">The value for HeaderStatusUploaded</param>
		public UploadMessagesSettingsBuilder HeaderStatusUploaded(string value)
		{
			Container.HeaderStatusUploaded = value;
			return this;
		}

		/// <summary>
		/// Sets the header status message for files that are being uploaded.
		/// </summary>
		/// <param name="value">The value for HeaderStatusUploading</param>
		public UploadMessagesSettingsBuilder HeaderStatusUploading(string value)
		{
			Container.HeaderStatusUploading = value;
			return this;
		}

		/// <summary>
		/// Sets the text of the remove button text.
		/// </summary>
		/// <param name="value">The value for Remove</param>
		public UploadMessagesSettingsBuilder Remove(string value)
		{
			Container.Remove = value;
			return this;
		}

		/// <summary>
		/// Sets the text of the retry button text.
		/// </summary>
		/// <param name="value">The value for Retry</param>
		public UploadMessagesSettingsBuilder Retry(string value)
		{
			Container.Retry = value;
			return this;
		}

		/// <summary>
		/// Sets the "Select..." button text.
		/// </summary>
		/// <param name="value">The value for Select</param>
		public UploadMessagesSettingsBuilder Select(string value)
		{
			Container.Select = value;
			return this;
		}

		/// <summary>
		/// Sets the status message for failed uploads.
		/// </summary>
		/// <param name="value">The value for StatusFailed</param>
		public UploadMessagesSettingsBuilder StatusFailed(string value)
		{
			Container.StatusFailed = value;
			return this;
		}

		/// <summary>
		/// Sets the status message for uploaded files.
		/// </summary>
		/// <param name="value">The value for StatusUploaded</param>
		public UploadMessagesSettingsBuilder StatusUploaded(string value)
		{
			Container.StatusUploaded = value;
			return this;
		}

		/// <summary>
		/// Sets the status message for files that are being uploaded.
		/// </summary>
		/// <param name="value">The value for StatusUploading</param>
		public UploadMessagesSettingsBuilder StatusUploading(string value)
		{
			Container.StatusUploading = value;
			return this;
		}

		/// <summary>
		/// Sets the text of the "Upload files" button.
		/// </summary>
		/// <param name="value">The value for UploadSelectedFiles</param>
		public UploadMessagesSettingsBuilder UploadSelectedFiles(string value)
		{
			Container.UploadSelectedFiles = value;
			return this;
		}

		/// <summary>
		/// Sets the status message for invalid maximal size.
		/// </summary>
		/// <param name="value">The value for InvalidMaxFileSize</param>
		public UploadMessagesSettingsBuilder InvalidMaxFileSize(string value)
		{
			Container.InvalidMaxFileSize = value;
			return this;
		}

		/// <summary>
		/// Sets the status message for invalid minimal file size.
		/// </summary>
		/// <param name="value">The value for InvalidMinFileSize</param>
		public UploadMessagesSettingsBuilder InvalidMinFileSize(string value)
		{
			Container.InvalidMinFileSize = value;
			return this;
		}

		/// <summary>
		/// Sets the status message for invalid file extension.
		/// </summary>
		/// <param name="value">The value for InvalidFileExtension</param>
		public UploadMessagesSettingsBuilder InvalidFileExtension(string value)
		{
			Container.InvalidFileExtension = value;
			return this;
		}

		/// <summary>
		/// Sets the text of the clear files.
		/// </summary>
		/// <param name="value">The value for ClearSelectedFiles</param>
		public UploadMessagesSettingsBuilder ClearSelectedFiles(string value)
		{
			Container.ClearSelectedFiles = value;
			return this;
		}
	}
}
