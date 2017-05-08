using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Upload
    /// </summary>
    public partial class UploadFileFactory
        
    {

        public Upload Upload { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual UploadFileBuilder Add()
        {
            var item = new UploadFile();
            item.Upload = Upload;
            Container.Add(item);

            return new UploadFileBuilder(item);
        }
    }
}
