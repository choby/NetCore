using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorFileBrowserSettings class
    /// </summary>
    public partial class EditorFileBrowserSettings 
    {
        public string FileTypes { get; set; }

        public string Path { get; set; }

        public EditorFileBrowserTransportSettings Transport { get; } = new EditorFileBrowserTransportSettings();

        public EditorFileBrowserSchemaSettings Schema { get; } = new EditorFileBrowserSchemaSettings();

        public EditorFileBrowserMessagesSettings Messages { get; } = new EditorFileBrowserMessagesSettings();


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
