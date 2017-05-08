using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Editor component
    /// </summary>
    public partial class Editor 
    {
        public EditorDeserializationSettings Deserialization { get; } = new EditorDeserializationSettings();

        public string Domain { get; set; }

        public bool? Encoded { get; set; }

        public EditorImmutablesSettings Immutables { get; } = new EditorImmutablesSettings();

        public EditorMessagesSettings Messages { get; } = new EditorMessagesSettings();

        public EditorPasteCleanupSettings PasteCleanup { get; } = new EditorPasteCleanupSettings();

        public EditorPdfSettings Pdf { get; } = new EditorPdfSettings();

        public EditorResizableSettings Resizable { get; } = new EditorResizableSettings();

        public EditorSerializationSettings Serialization { get; } = new EditorSerializationSettings();

        public List<EditorTool> Tools { get; set; } = new List<EditorTool>();

        public EditorImageBrowserSettings ImageBrowser { get; } = new EditorImageBrowserSettings();

        public EditorFileBrowserSettings FileBrowser { get; } = new EditorFileBrowserSettings();

        public string Tag { get; set; }

        public string Value { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var deserialization = Deserialization.Serialize();
            if (deserialization.Any())
            {
                settings["deserialization"] = deserialization;
            }

            if (Domain?.HasValue() == true)
            {
                settings["domain"] = Domain;
            }

            if (Encoded.HasValue)
            {
                settings["encoded"] = Encoded;
            }

            var immutables = Immutables.Serialize();
            if (immutables.Any())
            {
                settings["immutables"] = immutables;
            }
            else if (Immutables.Enabled.HasValue)
            {
                settings["immutables"] = Immutables.Enabled;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            var pasteCleanup = PasteCleanup.Serialize();
            if (pasteCleanup.Any())
            {
                settings["pasteCleanup"] = pasteCleanup;
            }

            var pdf = Pdf.Serialize();
            if (pdf.Any())
            {
                settings["pdf"] = pdf;
            }

            var resizable = Resizable.Serialize();
            if (resizable.Any())
            {
                settings["resizable"] = resizable;
            }
            else if (Resizable.Enabled.HasValue)
            {
                settings["resizable"] = Resizable.Enabled;
            }

            var serialization = Serialization.Serialize();
            if (serialization.Any())
            {
                settings["serialization"] = serialization;
            }

            var tools = Tools.Select(i => i.Serialize());
            if (tools.Any())
            {
                settings["tools"] = tools;
            }

            var imageBrowser = ImageBrowser.Serialize();
            if (imageBrowser.Any())
            {
                settings["imageBrowser"] = imageBrowser;
            }

            var fileBrowser = FileBrowser.Serialize();
            if (fileBrowser.Any())
            {
                settings["fileBrowser"] = fileBrowser;
            }

            return settings;
        }
    }
}
