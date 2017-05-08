using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorImageBrowserSettings class
    /// </summary>
    public partial class EditorImageBrowserSettings
    {
        public const string DefaultFileTypes = "*.png,*.gif,*.jpg,*.jpeg";

        public EditorImageBrowserSettings()
        {
            FileTypes = DefaultFileTypes;
            Create = new EditorImageBrowserOperation();
            Destroy = new EditorImageBrowserOperation();
            Image = new EditorImageBrowserOperation();
            Read = new EditorImageBrowserOperation();
            Upload = new EditorImageBrowserOperation();
            Thumbnail = new EditorImageBrowserOperation();
        }

        public EditorImageBrowserOperation Create { get; set; }

        public EditorImageBrowserOperation Destroy { get; set; }

        public EditorImageBrowserOperation Read { get; set; }

        public EditorImageBrowserOperation Image { get; set; }

        public EditorImageBrowserOperation Upload { get; set; }

        public EditorImageBrowserOperation Thumbnail { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            // Do manual serialization here

            var read = Read.Serialize();
            if (read.Any())
            {
                var transport = new Dictionary<string, object>();
                settings["transport"] = transport;

                transport["read"] = read;
                transport["type"] = "imagebrowser-aspnetmvc";

                var create = Create.Serialize();
                if (create.Any())
                {
                    transport["create"] = create;
                }

                var destroy = Destroy.Serialize();
                if (destroy.Any())
                {
                    transport["destroy"] = destroy;
                }

                var image = Image.Url;
                if (image.HasValue())
                {
                    image = Regex.Replace(image, "(%20)*%7B0(%20)*", "{0", RegexOptions.IgnoreCase);
                    image = Regex.Replace(image, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);
                    transport["imageUrl"] = image;
                }

                var upload = Upload.Serialize();
                if (upload.Any())
                {
                    transport["uploadUrl"] = upload["url"];
                }

                var thumbnail = Thumbnail.Serialize();
                if (thumbnail.Any())
                {
                    transport["thumbnailUrl"] = thumbnail["url"];
                }
            }

            return settings;
        }
    }
}
