using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorImageBrowserSettings class
    /// </summary>
    public partial class EditorImageBrowserSettings 
    {
        public string FileTypes { get; set; }

        public string Path { get; set; }

        public EditorImageBrowserTransportSettings Transport { get; } = new EditorImageBrowserTransportSettings();

        public EditorImageBrowserSchemaSettings Schema { get; } = new EditorImageBrowserSchemaSettings();

        public EditorImageBrowserMessagesSettings Messages { get; } = new EditorImageBrowserMessagesSettings();


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (FileTypes?.HasValue() == true)
            {
                settings["fileTypes"] = FileTypes;
            }

            if (Path?.HasValue() == true)
            {
                settings["path"] = Path;
            }

            var transport = Transport.Serialize();
            if (transport.Any())
            {
                settings["transport"] = transport;
            }

            var schema = Schema.Serialize();
            if (schema.Any())
            {
                settings["schema"] = schema;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            return settings;
        }
    }
}
