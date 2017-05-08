using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserMessagesSettings
    /// </summary>
    public partial class EditorFileBrowserMessagesSettingsBuilder
        
    {
        /// <summary>
        /// Defines text for upload button.
        /// </summary>
        /// <param name="value">The value for UploadFile</param>
        public EditorFileBrowserMessagesSettingsBuilder UploadFile(string value)
        {
            Container.UploadFile = value;
            return this;
        }

        /// <summary>
        /// Defines text for order by label.
        /// </summary>
        /// <param name="value">The value for OrderBy</param>
        public EditorFileBrowserMessagesSettingsBuilder OrderBy(string value)
        {
            Container.OrderBy = value;
            return this;
        }

        /// <summary>
        /// Defines text for Name item of order by drop down list.
        /// </summary>
        /// <param name="value">The value for OrderByName</param>
        public EditorFileBrowserMessagesSettingsBuilder OrderByName(string value)
        {
            Container.OrderByName = value;
            return this;
        }

        /// <summary>
        /// Defines text for Size item of order by drop down list.
        /// </summary>
        /// <param name="value">The value for OrderBySize</param>
        public EditorFileBrowserMessagesSettingsBuilder OrderBySize(string value)
        {
            Container.OrderBySize = value;
            return this;
        }

        /// <summary>
        /// Defines text for dialog shown when the directory not found error occurs.
        /// </summary>
        /// <param name="value">The value for DirectoryNotFound</param>
        public EditorFileBrowserMessagesSettingsBuilder DirectoryNotFound(string value)
        {
            Container.DirectoryNotFound = value;
            return this;
        }

        /// <summary>
        /// Defines text displayed when folder does not contain items.
        /// </summary>
        /// <param name="value">The value for EmptyFolder</param>
        public EditorFileBrowserMessagesSettingsBuilder EmptyFolder(string value)
        {
            Container.EmptyFolder = value;
            return this;
        }

        /// <summary>
        /// Defines text for dialog shown when the file or directory is deleted.
        /// </summary>
        /// <param name="value">The value for DeleteFile</param>
        public EditorFileBrowserMessagesSettingsBuilder DeleteFile(string value)
        {
            Container.DeleteFile = value;
            return this;
        }

        /// <summary>
        /// Defines text for dialog shown when an invalid file is set for upload.
        /// </summary>
        /// <param name="value">The value for InvalidFileType</param>
        public EditorFileBrowserMessagesSettingsBuilder InvalidFileType(string value)
        {
            Container.InvalidFileType = value;
            return this;
        }

        /// <summary>
        /// Defines text for dialog shown when an already existing file is set for upload.
        /// </summary>
        /// <param name="value">The value for OverwriteFile</param>
        public EditorFileBrowserMessagesSettingsBuilder OverwriteFile(string value)
        {
            Container.OverwriteFile = value;
            return this;
        }

        /// <summary>
        /// Defines text for search box placeholder.
        /// </summary>
        /// <param name="value">The value for Search</param>
        public EditorFileBrowserMessagesSettingsBuilder Search(string value)
        {
            Container.Search = value;
            return this;
        }

    }
}
