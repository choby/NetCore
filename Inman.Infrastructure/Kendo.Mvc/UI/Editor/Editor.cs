using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Editor component
    /// </summary>
    public partial class Editor : WidgetBase, IWidget

    {
        public Editor(ViewContext viewContext) : base(viewContext)
        {
            Tag = EditorConstants.DEFAULT_EDITOR_TAG;
        }

        public List<string> StyleSheets { get; set; } = new List<string>();
        
        public Func<object, object> ValueHandler { get; set; }

        public Action ValueAction { get; set; }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = GenerateTag(writer);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        protected TagBuilder GenerateTag(TextWriter writer)
        {
            var tag = Generator.GenerateTag(Tag, ViewContext, Id, Name, HtmlAttributes);
            var inlineEditModeEnabled = Tag != EditorConstants.DEFAULT_EDITOR_TAG;

            if (inlineEditModeEnabled)
            {
                tag.MergeAttribute("contentEditable", "true");
            }
            else
            {
                tag.MergeAttribute("cols", EditorConstants.DEFAULT_TEXTAREA_COLS_COUNT.ToString());
                tag.MergeAttribute("rows", EditorConstants.DEFAULT_TEXTAREA_ROWS_COUNT.ToString());
            }

            tag.TagRenderMode = TagRenderMode.StartTag;
            tag.WriteTo(writer, HtmlEncoder);

            var value = this.GetValue(Value);

            if (value.HasValue())
            {
                if (inlineEditModeEnabled)
                {
                    writer.Write(value);
                }
                else
                {
                    writer.Write(HtmlEncoder.Encode(value));
                }
            }
            else if (ValueAction != null)
            {
                ValueAction();
            }
            else if (ValueHandler != null)
            {
                if (inlineEditModeEnabled)
                {
                    writer.WriteContent(ValueHandler, HtmlEncoder);
                }
                else
                {
                    writer.WriteContent(ValueHandler, HtmlEncoder, htmlEncode: true);
                }
            }

            tag.TagRenderMode = TagRenderMode.EndTag;
            
            return tag;
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            // TODO: Manually serialized settings go here

            if (StyleSheets.Count > 0)
            {
                settings["stylesheets"] = StyleSheets;
            }

            writer.Write(Initializer.Initialize(Selector, "Editor", settings));
        }
    }
}

