using Microsoft.AspNetCore.Hosting;

namespace Kendo.Mvc.UI
{
    public abstract class EditorFileBrowserController : FileBrowserController
    {
        /// <summary>
        /// Gets the valid file extensions by which served files will be filtered.
        /// </summary>
        public override string Filter
        {
            get
            {
                return EditorFileBrowserSettings.DefaultFileTypes;
            }
        }

        public EditorFileBrowserController(IHostingEnvironment hostingEnvironment)
            : base(hostingEnvironment)
        {

        }
    }
}
