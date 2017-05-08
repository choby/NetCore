using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorImageBrowserTransportCreateSettings class
    /// </summary>
    public partial class EditorImageBrowserTransportCreateSettings 
    {
        public string ContentType { get; set; }

        public string DataType { get; set; }

        public string Type { get; set; }

        public string Url { get; set; }
        public ClientHandlerDescriptor UrlHandler { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (ContentType?.HasValue() == true)
            {
                settings["contentType"] = ContentType;
            }

            if (DataType?.HasValue() == true)
            {
                settings["dataType"] = DataType;
            }

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (UrlHandler?.HasValue() == true)
            {
                settings["url"] = UrlHandler;
            }
            else if (Url?.HasValue() == true)
            {
               settings["url"] = Url;
            }


            return settings;
        }
    }
}
