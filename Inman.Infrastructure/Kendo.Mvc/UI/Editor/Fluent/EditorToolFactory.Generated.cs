using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Editor.
    /// </summary>
    public partial class EditorToolFactory
    {
        public Editor Editor { get; set; }

        /// <summary>
        /// Adds "Bold" tool.
        /// </summary>
        public virtual EditorToolFactory Bold()
        {
            AddTool("bold");
            return this;
        }

        /// <summary>
        /// Adds "CleanFormatting" tool.
        /// </summary>
        public virtual EditorToolFactory CleanFormatting()
        {
            AddTool("cleanFormatting");
            return this;
        }

        /// <summary>
        /// Adds "CreateLink" tool.
        /// </summary>
        public virtual EditorToolFactory CreateLink()
        {
            AddTool("createLink");
            return this;
        }

        /// <summary>
        /// Adds "Indent" tool.
        /// </summary>
        public virtual EditorToolFactory Indent()
        {
            AddTool("indent");
            return this;
        }

        /// <summary>
        /// Adds "InsertFile" tool.
        /// </summary>
        public virtual EditorToolFactory InsertFile()
        {
            AddTool("insertFile");
            return this;
        }

        /// <summary>
        /// Adds "InsertImage" tool.
        /// </summary>
        public virtual EditorToolFactory InsertImage()
        {
            AddTool("insertImage");
            return this;
        }

        /// <summary>
        /// Adds "InsertOrderedList" tool.
        /// </summary>
        public virtual EditorToolFactory InsertOrderedList()
        {
            AddTool("insertOrderedList");
            return this;
        }

        /// <summary>
        /// Adds "InsertUnorderedList" tool.
        /// </summary>
        public virtual EditorToolFactory InsertUnorderedList()
        {
            AddTool("insertUnorderedList");
            return this;
        }

        /// <summary>
        /// Adds "Italic" tool.
        /// </summary>
        public virtual EditorToolFactory Italic()
        {
            AddTool("italic");
            return this;
        }

        /// <summary>
        /// Adds "JustifyCenter" tool.
        /// </summary>
        public virtual EditorToolFactory JustifyCenter()
        {
            AddTool("justifyCenter");
            return this;
        }

        /// <summary>
        /// Adds "JustifyFull" tool.
        /// </summary>
        public virtual EditorToolFactory JustifyFull()
        {
            AddTool("justifyFull");
            return this;
        }

        /// <summary>
        /// Adds "JustifyLeft" tool.
        /// </summary>
        public virtual EditorToolFactory JustifyLeft()
        {
            AddTool("justifyLeft");
            return this;
        }

        /// <summary>
        /// Adds "JustifyRight" tool.
        /// </summary>
        public virtual EditorToolFactory JustifyRight()
        {
            AddTool("justifyRight");
            return this;
        }

        /// <summary>
        /// Adds "Outdent" tool.
        /// </summary>
        public virtual EditorToolFactory Outdent()
        {
            AddTool("outdent");
            return this;
        }

        /// <summary>
        /// Adds "Pdf" tool.
        /// </summary>
        public virtual EditorToolFactory Pdf()
        {
            AddTool("pdf");
            return this;
        }

        /// <summary>
        /// Adds "Print" tool.
        /// </summary>
        public virtual EditorToolFactory Print()
        {
            AddTool("print");
            return this;
        }

        /// <summary>
        /// Adds "Separator" tool.
        /// </summary>
        public virtual EditorToolFactory Separator()
        {
            AddTool("separator");
            return this;
        }

        /// <summary>
        /// Adds "Strikethrough" tool.
        /// </summary>
        public virtual EditorToolFactory Strikethrough()
        {
            AddTool("strikethrough");
            return this;
        }

        /// <summary>
        /// Adds "SubScript" tool.
        /// </summary>
        public virtual EditorToolFactory SubScript()
        {
            AddTool("subscript");
            return this;
        }

        /// <summary>
        /// Adds "SuperScript" tool.
        /// </summary>
        public virtual EditorToolFactory SuperScript()
        {
            AddTool("superscript");
            return this;
        }

        /// <summary>
        /// Adds "Underline" tool.
        /// </summary>
        public virtual EditorToolFactory Underline()
        {
            AddTool("underline");
            return this;
        }

        /// <summary>
        /// Adds "Unlink" tool.
        /// </summary>
        public virtual EditorToolFactory Unlink()
        {
            AddTool("unlink");
            return this;
        }

        /// <summary>
        /// Adds "ViewHtml" tool.
        /// </summary>
        public virtual EditorToolFactory ViewHtml()
        {
            AddTool("viewHtml");
            return this;
        }

        /// <summary>
        /// Adds "BackColor" tool.
        /// </summary>
        public virtual EditorToolFactory BackColor()
        {
            AddTool("backColor");
            return this;
        }

        public EditorToolFactory BackColor(Action<EditorToolBuilder> configurator)
        {
            AddTool("backColor", configurator);
            return this;
        }

        /// <summary>
        /// Adds "ForeColor" tool.
        /// </summary>
        public virtual EditorToolFactory ForeColor()
        {
            AddTool("foreColor");
            return this;
        }

        public EditorToolFactory ForeColor(Action<EditorToolBuilder> configurator)
        {
            AddTool("foreColor", configurator);
            return this;
        }

        /// <summary>
        /// Adds "FontName" tool.
        /// </summary>
        public virtual EditorToolFactory FontName()
        {
            AddDropDownTool("fontName", new List<EditorToolItem>());
            return this;
        }

        /// <summary>
        /// Adds "FontName" tool.
        /// </summary>
        public virtual EditorToolFactory FontName(Action<EditorToolItemFactory> configurator)
        {
            AddDropDownTool("fontName", CreateDropDownToolItems(configurator));
            return this;
        }

        /// <summary>
        /// Adds "FontSize" tool.
        /// </summary>
        public virtual EditorToolFactory FontSize()
        {
            AddDropDownTool("fontSize", new List<EditorToolItem>());
            return this;
        }

        /// <summary>
        /// Adds "FontSize" tool.
        /// </summary>
        public virtual EditorToolFactory FontSize(Action<EditorToolItemFactory> configurator)
        {
            AddDropDownTool("fontSize", CreateDropDownToolItems(configurator));
            return this;
        }

        /// <summary>
        /// Adds "Formatting" tool.
        /// </summary>
        public virtual EditorToolFactory Formatting()
        {
            AddDropDownTool("formatting", new List<EditorToolItem>());
            return this;
        }

        /// <summary>
        /// Adds "Formatting" tool.
        /// </summary>
        public virtual EditorToolFactory Formatting(Action<EditorToolItemFactory> configurator)
        {
            AddDropDownTool("formatting", CreateDropDownToolItems(configurator));
            return this;
        }

        /// <summary>
        /// Adds "Snippets" tool.
        /// </summary>
        public virtual EditorToolFactory Snippets()
        {
            AddDropDownTool("insertHtml", new List<EditorToolItem>());
            return this;
        }

        /// <summary>
        /// Adds "Snippets" tool.
        /// </summary>
        public virtual EditorToolFactory Snippets(Action<EditorToolItemFactory> configurator)
        {
            AddDropDownTool("insertHtml", CreateDropDownToolItems(configurator));
            return this;
        }

        public EditorToolFactory TableEditing()
        {
            AddTool("addColumnLeft");
            AddTool("addColumnRight");
            AddTool("addRowAbove");
            AddTool("addRowBelow");
            AddTool("createTable");
            AddTool("deleteColumn");
            AddTool("deleteRow");
            return this;
        }

        /// <summary>
        /// Adds a tool to the editor.
        /// </summary>
        private void AddTool(string name)
        {
            var item = new EditorTool()
            {
                Editor = Editor,
                Name = name
            };
            Container.Add(item);
        }

        private void AddTool(string name, Action<EditorToolBuilder> configurator)
        {
            var item = new EditorTool()
            {
                Editor = Editor,
                Name = name
            };

            configurator(new EditorToolBuilder(item));

            Container.Add(item);
        }

        /// <summary>
        /// Adds a tool to the editor.
        /// </summary>
        private void AddDropDownTool(string name, List<EditorToolItem> items)
        {
            var item = new EditorTool()
            {
                Editor = Editor,
                Name = name,
                Items = items
            };
            Container.Add(item);
        }

        private List<EditorToolItem> CreateDropDownToolItems(Action<EditorToolItemFactory> configurator)
        {
            var items = new List<EditorToolItem>();
            configurator(new EditorToolItemFactory(items)
            {
                Editor = Editor
            });
            return items;
        }

        /// <summary>
        /// Remove all tools.
        /// </summary>
        public virtual EditorToolFactory Clear()
        {
            Container.Clear();
            return this;
        }
    }
}
