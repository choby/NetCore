using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
	/// <summary>
	/// Kendo UI UploadMessagesSettings class
	/// </summary>
	public partial class UploadMessagesSettings 
    {

		public string Cancel { get; set; }

		public string DropFilesHere { get; set; }

		public string HeaderStatusUploaded { get; set; }

		public string HeaderStatusUploading { get; set; }

		public string Remove { get; set; }

		public string Retry { get; set; }

		public string Select { get; set; }

		public string StatusFailed { get; set; }

		public string StatusUploaded { get; set; }

		public string StatusUploading { get; set; }

		public string UploadSelectedFiles { get; set; }

		public string InvalidMaxFileSize { get; set; }

		public string InvalidMinFileSize { get; set; }

		public string InvalidFileExtension { get; set; }

		public string ClearSelectedFiles { get; set; }

		public Dictionary<string, object> Serialize()
		{
			var settings = new Dictionary<string, object>();

			if (Cancel.HasValue())
			{
				settings["cancel"] = Cancel;
			}

			if (DropFilesHere.HasValue())
			{
				settings["dropFilesHere"] = DropFilesHere;
			}

			if (HeaderStatusUploaded.HasValue())
			{
				settings["headerStatusUploaded"] = HeaderStatusUploaded;
			}

			if (HeaderStatusUploading.HasValue())
			{
				settings["headerStatusUploading"] = HeaderStatusUploading;
			}

			if (Remove.HasValue())
			{
				settings["remove"] = Remove;
			}

			if (Retry.HasValue())
			{
				settings["retry"] = Retry;
			}

			if (Select.HasValue())
			{
				settings["select"] = Select;
			}

			if (StatusFailed.HasValue())
			{
				settings["statusFailed"] = StatusFailed;
			}

			if (StatusUploaded.HasValue())
			{
				settings["statusUploaded"] = StatusUploaded;
			}

			if (StatusUploading.HasValue())
			{
				settings["statusUploading"] = StatusUploading;
			}

			if (UploadSelectedFiles.HasValue())
			{
				settings["uploadSelectedFiles"] = UploadSelectedFiles;
			}

			if (InvalidMaxFileSize.HasValue())
			{
				settings["invalidMaxFileSize"] = InvalidMaxFileSize;
			}

			if (InvalidMinFileSize.HasValue())
			{
				settings["invalidMinFileSize"] = InvalidMinFileSize;
			}

			if (InvalidFileExtension.HasValue())
			{
				settings["invalidFileExtension"] = InvalidFileExtension;
			}

			if (ClearSelectedFiles.HasValue())
			{
				settings["clearSelectedFiles"] = ClearSelectedFiles;
			}

			return settings;
		}
    }
}
