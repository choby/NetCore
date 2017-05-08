

using Microsoft.AspNetCore.Mvc;

namespace Kendo.Mvc.UI
{
    public interface IImageBrowserController : IFileBrowserController
    {
        IActionResult Thumbnail(string path);
    }
}
