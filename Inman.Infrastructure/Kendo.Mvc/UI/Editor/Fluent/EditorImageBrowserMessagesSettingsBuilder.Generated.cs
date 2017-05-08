using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserMessagesSettings
    /// </summary>
    public partial class EditorImageBrowserMessagesSettingsBuilder
        
    {
        /// <summary>
        /// Defines text for upload button.
        /// </summary>
        /// <param name="value">The value for UploadFile</param>
        public EditorImageBrowserMessagesSettingsBuilder UploadFile(string value)
        {
            Container.UploadFile = value;
            return this;
        }

        /// <summary>
        /// Defines text for order by label.
        /// </summary>
        /// <param name="value">The value for OrderBy</param>
        public EditorImageBrowserMessagesSettingsBuilder OrderBy(string value)
        {
            Container.OrderBy = value;
            return this;
        }

        /// <summary>
        /// Defines text for Name item of order by drop down list.
        /// </summary>
        /// <param name="value">The value for OrderByName</param>
        public EditorImageBrowserMessagesSettingsBuilder OrderByName(string value)
        {
            Container.OrderByName = value;
            return this;
        }

        /// <summary>
        /// Defines text for Size item of order by drop down list.
        /// </summary>
        /// <param name="value">The value for OrderBySize</param>
        public EditorImageBrowserMessagesSettingsBuilder OrderBySize(string value)
        {
            Container.OrderBySize = value;
            return this;
        }

        /// <summary>
        /// Defines text for dialog shown when the directory not found error occurs.
        /// </summary>
        /// <param name="value">The value for DirectoryNotFound</param>
        public EditorImageBrowserMessagesSettingsBuilder DirectoryNotFound(string value)
        {
            Container.DirectoryNotFound = value;
            return this;
        }

        /// <summary>
        /// Defines text displayed when folder does not contain items.
        /// </summary>
        /// <param name="value">The value for EmptyFolder</param>
        public EditorImageBrowserMessagesSettingsBuilder EmptyFolder(string value)
        {
            Container.EmptyFolder = value;
            return this;
        }

        /// <summary>
        /// Defines text for dialog shown when the file or directory is deleted.
        /// </summary>
        /// <param name="value">The value for DeleteFile</param>
        public EditorImageBrowserMessagesSettingsBuilder DeleteFile(string value)
        {
            Container.DeleteFile = value;
            return this;
        }

        /// <summary>
        /// Defines text for dialog shown when an invalid file is set for upload.
        /// </summary>
        /// <param name="value">The value for InvalidFileType</param>
        public EditorImageBrowserMessagesSettingsBuilder InvalidFileType(string value)
        {
            Container.InvalidFileType = value;
            return this;
        }

        /// <summary>
        /// Defines text for dialog shown when an already existing file is set for upload.
        /// </summary>
        /// <param name="value">The value for OverwriteFile</param>
        public EditorImageBrowserMessagesSettingsBuilder OverwriteFile(string value)
        {
            Container.OverwriteFile = value;
            return this;
        }

        /// <summary>
        /// Defines text for search box placeholder.
        /// </summary>
        /// <param name="value">The value for Search</param>
        public EditorImageBrowserMessagesSettingsBuilder Search(string value)
        {
            Container.Search = value;
            return this;
        }

    }
}
