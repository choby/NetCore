using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorMessagesSettings
    /// </summary>
    public partial class EditorMessagesSettingsBuilder
        
    {
        /// <summary>
        /// The title of the Accessibility in the Table Wizard dialog.
        /// </summary>
        /// <param name="value">The value for AccessibilityTab</param>
        public EditorMessagesSettingsBuilder AccessibilityTab(string value)
        {
            Container.AccessibilityTab = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that adds table columns on the left of the selection.
        /// </summary>
        /// <param name="value">The value for AddColumnLeft</param>
        public EditorMessagesSettingsBuilder AddColumnLeft(string value)
        {
            Container.AddColumnLeft = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that adds table columns on the right of the selection.
        /// </summary>
        /// <param name="value">The value for AddColumnRight</param>
        public EditorMessagesSettingsBuilder AddColumnRight(string value)
        {
            Container.AddColumnRight = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that adds table rows above the selection.
        /// </summary>
        /// <param name="value">The value for AddRowAbove</param>
        public EditorMessagesSettingsBuilder AddRowAbove(string value)
        {
            Container.AddRowAbove = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that adds table rows below the selection.
        /// </summary>
        /// <param name="value">The value for AddRowBelow</param>
        public EditorMessagesSettingsBuilder AddRowBelow(string value)
        {
            Container.AddRowBelow = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignCenter</param>
        public EditorMessagesSettingsBuilder AlignCenter(string value)
        {
            Container.AlignCenter = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignCenterBottom</param>
        public EditorMessagesSettingsBuilder AlignCenterBottom(string value)
        {
            Container.AlignCenterBottom = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignCenterMiddle</param>
        public EditorMessagesSettingsBuilder AlignCenterMiddle(string value)
        {
            Container.AlignCenterMiddle = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignCenterTop</param>
        public EditorMessagesSettingsBuilder AlignCenterTop(string value)
        {
            Container.AlignCenterTop = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignLeft</param>
        public EditorMessagesSettingsBuilder AlignLeft(string value)
        {
            Container.AlignLeft = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignLeftBottom</param>
        public EditorMessagesSettingsBuilder AlignLeftBottom(string value)
        {
            Container.AlignLeftBottom = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignLeftMiddle</param>
        public EditorMessagesSettingsBuilder AlignLeftMiddle(string value)
        {
            Container.AlignLeftMiddle = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignLeftTop</param>
        public EditorMessagesSettingsBuilder AlignLeftTop(string value)
        {
            Container.AlignLeftTop = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that removes the cell text's alignment.
        /// </summary>
        /// <param name="value">The value for AlignRemove</param>
        public EditorMessagesSettingsBuilder AlignRemove(string value)
        {
            Container.AlignRemove = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignRight</param>
        public EditorMessagesSettingsBuilder AlignRight(string value)
        {
            Container.AlignRight = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignRightBottom</param>
        public EditorMessagesSettingsBuilder AlignRightBottom(string value)
        {
            Container.AlignRightBottom = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignRightMiddle</param>
        public EditorMessagesSettingsBuilder AlignRightMiddle(string value)
        {
            Container.AlignRightMiddle = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for AlignRightTop</param>
        public EditorMessagesSettingsBuilder AlignRightTop(string value)
        {
            Container.AlignRightTop = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns the cell text.
        /// </summary>
        /// <param name="value">The value for Alignment</param>
        public EditorMessagesSettingsBuilder Alignment(string value)
        {
            Container.Alignment = value;
            return this;
        }

        /// <summary>
        /// The title of the Associate cells with headers tool.
        /// </summary>
        /// <param name="value">The value for AssociateCellsWithHeaders</param>
        public EditorMessagesSettingsBuilder AssociateCellsWithHeaders(string value)
        {
            Container.AssociateCellsWithHeaders = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that changes the text background color.
        /// </summary>
        /// <param name="value">The value for BackColor</param>
        public EditorMessagesSettingsBuilder BackColor(string value)
        {
            Container.BackColor = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that changes the text background of the tables/cells.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public EditorMessagesSettingsBuilder Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that makes text bold.
        /// </summary>
        /// <param name="value">The value for Bold</param>
        public EditorMessagesSettingsBuilder Bold(string value)
        {
            Container.Bold = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that changes the border of tables.
        /// </summary>
        /// <param name="value">The value for Border</param>
        public EditorMessagesSettingsBuilder Border(string value)
        {
            Container.Border = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that applies styling to elements. Deprecated.
        /// </summary>
        /// <param name="value">The value for Style</param>
        public EditorMessagesSettingsBuilder Style(string value)
        {
            Container.Style = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that adds caption to tables.
        /// </summary>
        /// <param name="value">The value for Caption</param>
        public EditorMessagesSettingsBuilder Caption(string value)
        {
            Container.Caption = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that applies margin to table cells.
        /// </summary>
        /// <param name="value">The value for CellMargin</param>
        public EditorMessagesSettingsBuilder CellMargin(string value)
        {
            Container.CellMargin = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that applies padding to table cells.
        /// </summary>
        /// <param name="value">The value for CellPadding</param>
        public EditorMessagesSettingsBuilder CellPadding(string value)
        {
            Container.CellPadding = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that applies spacing to table cells.
        /// </summary>
        /// <param name="value">The value for CellSpacing</param>
        public EditorMessagesSettingsBuilder CellSpacing(string value)
        {
            Container.CellSpacing = value;
            return this;
        }

        /// <summary>
        /// The title of the Cell tab in Table Wizard dialog.
        /// </summary>
        /// <param name="value">The value for CellTab</param>
        public EditorMessagesSettingsBuilder CellTab(string value)
        {
            Container.CellTab = value;
            return this;
        }

        /// <summary>
        /// The title of the Clean Formatting tool.
        /// </summary>
        /// <param name="value">The value for CleanFormatting</param>
        public EditorMessagesSettingsBuilder CleanFormatting(string value)
        {
            Container.CleanFormatting = value;
            return this;
        }

        /// <summary>
        /// The title of the Collapse borders option in Table Wizard.
        /// </summary>
        /// <param name="value">The value for CollapseBorders</param>
        public EditorMessagesSettingsBuilder CollapseBorders(string value)
        {
            Container.CollapseBorders = value;
            return this;
        }

        /// <summary>
        /// The title of the Columns tool in Table Wizard.
        /// </summary>
        /// <param name="value">The value for Columns</param>
        public EditorMessagesSettingsBuilder Columns(string value)
        {
            Container.Columns = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that creates hyperlinks.
        /// </summary>
        /// <param name="value">The value for CreateLink</param>
        public EditorMessagesSettingsBuilder CreateLink(string value)
        {
            Container.CreateLink = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that inserts tables.
        /// </summary>
        /// <param name="value">The value for CreateTable</param>
        public EditorMessagesSettingsBuilder CreateTable(string value)
        {
            Container.CreateTable = value;
            return this;
        }

        /// <summary>
        /// The status text of the tool that inserts tables, which indicates the dimensions of the inserted table.
        /// </summary>
        /// <param name="value">The value for CreateTableHint</param>
        public EditorMessagesSettingsBuilder CreateTableHint(string value)
        {
            Container.CreateTableHint = value;
            return this;
        }

        /// <summary>
        /// The title of the CSS Class dropdown tool.
        /// </summary>
        /// <param name="value">The value for CssClass</param>
        public EditorMessagesSettingsBuilder CssClass(string value)
        {
            Container.CssClass = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that deletes selected table columns.
        /// </summary>
        /// <param name="value">The value for DeleteColumn</param>
        public EditorMessagesSettingsBuilder DeleteColumn(string value)
        {
            Container.DeleteColumn = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that deletes selected table rows.
        /// </summary>
        /// <param name="value">The value for DeleteRow</param>
        public EditorMessagesSettingsBuilder DeleteRow(string value)
        {
            Container.DeleteRow = value;
            return this;
        }

        /// <summary>
        /// The label of the cancel button in all editor dialogs.
        /// </summary>
        /// <param name="value">The value for DialogCancel</param>
        public EditorMessagesSettingsBuilder DialogCancel(string value)
        {
            Container.DialogCancel = value;
            return this;
        }

        /// <summary>
        /// The label of the insert button in all editor dialogs.
        /// </summary>
        /// <param name="value">The value for DialogInsert</param>
        public EditorMessagesSettingsBuilder DialogInsert(string value)
        {
            Container.DialogInsert = value;
            return this;
        }

        /// <summary>
        /// The title of the OK buttons in editor's dialogs.
        /// </summary>
        /// <param name="value">The value for DialogOk</param>
        public EditorMessagesSettingsBuilder DialogOk(string value)
        {
            Container.DialogOk = value;
            return this;
        }

        /// <summary>
        /// The label of the update button in all editor dialogs.
        /// </summary>
        /// <param name="value">The value for DialogUpdate</param>
        public EditorMessagesSettingsBuilder DialogUpdate(string value)
        {
            Container.DialogUpdate = value;
            return this;
        }

        /// <summary>
        /// The title of the iframe editing area when a sandboxed editor is used. Used as a hint for screen readers.
        /// </summary>
        /// <param name="value">The value for EditAreaTitle</param>
        public EditorMessagesSettingsBuilder EditAreaTitle(string value)
        {
            Container.EditAreaTitle = value;
            return this;
        }

        /// <summary>
        /// The caption for the file title in the insertFile dialog.
        /// </summary>
        /// <param name="value">The value for FileTitle</param>
        public EditorMessagesSettingsBuilder FileTitle(string value)
        {
            Container.FileTitle = value;
            return this;
        }

        /// <summary>
        /// The caption for the file URL in the insertFile dialog.
        /// </summary>
        /// <param name="value">The value for FileWebAddress</param>
        public EditorMessagesSettingsBuilder FileWebAddress(string value)
        {
            Container.FileWebAddress = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that changes the text font.
        /// </summary>
        /// <param name="value">The value for FontName</param>
        public EditorMessagesSettingsBuilder FontName(string value)
        {
            Container.FontName = value;
            return this;
        }

        /// <summary>
        /// The text that is shown when the text font will be inherited from the surrounding page.
        /// </summary>
        /// <param name="value">The value for FontNameInherit</param>
        public EditorMessagesSettingsBuilder FontNameInherit(string value)
        {
            Container.FontNameInherit = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that changes the text size.
        /// </summary>
        /// <param name="value">The value for FontSize</param>
        public EditorMessagesSettingsBuilder FontSize(string value)
        {
            Container.FontSize = value;
            return this;
        }

        /// <summary>
        /// The text that is shown when the text size will be inherited from the surrounding page.
        /// </summary>
        /// <param name="value">The value for FontSizeInherit</param>
        public EditorMessagesSettingsBuilder FontSizeInherit(string value)
        {
            Container.FontSizeInherit = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that changes the text color.
        /// </summary>
        /// <param name="value">The value for ForeColor</param>
        public EditorMessagesSettingsBuilder ForeColor(string value)
        {
            Container.ForeColor = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that lets users choose block formats. Deprecated.
        /// </summary>
        /// <param name="value">The value for FormatBlock</param>
        public EditorMessagesSettingsBuilder FormatBlock(string value)
        {
            Container.FormatBlock = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that lets users choose block formats.
        /// </summary>
        /// <param name="value">The value for Formatting</param>
        public EditorMessagesSettingsBuilder Formatting(string value)
        {
            Container.Formatting = value;
            return this;
        }

        /// <summary>
        /// The title of the height fields.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public EditorMessagesSettingsBuilder Height(string value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The title of the id fields.
        /// </summary>
        /// <param name="value">The value for Id</param>
        public EditorMessagesSettingsBuilder Id(string value)
        {
            Container.Id = value;
            return this;
        }

        /// <summary>
        /// The caption for the image alternate text in the insertImage dialog.
        /// </summary>
        /// <param name="value">The value for ImageAltText</param>
        public EditorMessagesSettingsBuilder ImageAltText(string value)
        {
            Container.ImageAltText = value;
            return this;
        }

        /// <summary>
        /// The caption for the image height in the insertImage dialog.
        /// </summary>
        /// <param name="value">The value for ImageHeight</param>
        public EditorMessagesSettingsBuilder ImageHeight(string value)
        {
            Container.ImageHeight = value;
            return this;
        }

        /// <summary>
        /// The caption for the image URL in the insertImage dialog.
        /// </summary>
        /// <param name="value">The value for ImageWebAddress</param>
        public EditorMessagesSettingsBuilder ImageWebAddress(string value)
        {
            Container.ImageWebAddress = value;
            return this;
        }

        /// <summary>
        /// The caption for the image width in the insertImage dialog.
        /// </summary>
        /// <param name="value">The value for ImageWidth</param>
        public EditorMessagesSettingsBuilder ImageWidth(string value)
        {
            Container.ImageWidth = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that indents the content.
        /// </summary>
        /// <param name="value">The value for Indent</param>
        public EditorMessagesSettingsBuilder Indent(string value)
        {
            Container.Indent = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that inserts links to files.
        /// </summary>
        /// <param name="value">The value for InsertFile</param>
        public EditorMessagesSettingsBuilder InsertFile(string value)
        {
            Container.InsertFile = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that inserts HTML snippets.
        /// </summary>
        /// <param name="value">The value for InsertHtml</param>
        public EditorMessagesSettingsBuilder InsertHtml(string value)
        {
            Container.InsertHtml = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that inserts images.
        /// </summary>
        /// <param name="value">The value for InsertImage</param>
        public EditorMessagesSettingsBuilder InsertImage(string value)
        {
            Container.InsertImage = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that inserts an ordered list.
        /// </summary>
        /// <param name="value">The value for InsertOrderedList</param>
        public EditorMessagesSettingsBuilder InsertOrderedList(string value)
        {
            Container.InsertOrderedList = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that inserts an unordered list.
        /// </summary>
        /// <param name="value">The value for InsertUnorderedList</param>
        public EditorMessagesSettingsBuilder InsertUnorderedList(string value)
        {
            Container.InsertUnorderedList = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that makes text italicized.
        /// </summary>
        /// <param name="value">The value for Italic</param>
        public EditorMessagesSettingsBuilder Italic(string value)
        {
            Container.Italic = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns text in the center.
        /// </summary>
        /// <param name="value">The value for JustifyCenter</param>
        public EditorMessagesSettingsBuilder JustifyCenter(string value)
        {
            Container.JustifyCenter = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that justifies text both left and right.
        /// </summary>
        /// <param name="value">The value for JustifyFull</param>
        public EditorMessagesSettingsBuilder JustifyFull(string value)
        {
            Container.JustifyFull = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns text on the left.
        /// </summary>
        /// <param name="value">The value for JustifyLeft</param>
        public EditorMessagesSettingsBuilder JustifyLeft(string value)
        {
            Container.JustifyLeft = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that aligns text on the right.
        /// </summary>
        /// <param name="value">The value for JustifyRight</param>
        public EditorMessagesSettingsBuilder JustifyRight(string value)
        {
            Container.JustifyRight = value;
            return this;
        }

        /// <summary>
        /// The caption for the checkbox for opening the link in a new window in the createLink dialog.
        /// </summary>
        /// <param name="value">The value for LinkOpenInNewWindow</param>
        public EditorMessagesSettingsBuilder LinkOpenInNewWindow(string value)
        {
            Container.LinkOpenInNewWindow = value;
            return this;
        }

        /// <summary>
        /// The caption for the link text in the createLink dialog.
        /// </summary>
        /// <param name="value">The value for LinkText</param>
        public EditorMessagesSettingsBuilder LinkText(string value)
        {
            Container.LinkText = value;
            return this;
        }

        /// <summary>
        /// The caption for the link Tooltip in the createLink dialog.
        /// </summary>
        /// <param name="value">The value for LinkToolTip</param>
        public EditorMessagesSettingsBuilder LinkToolTip(string value)
        {
            Container.LinkToolTip = value;
            return this;
        }

        /// <summary>
        /// The caption for the URL in the createLink dialog.
        /// </summary>
        /// <param name="value">The value for LinkWebAddress</param>
        public EditorMessagesSettingsBuilder LinkWebAddress(string value)
        {
            Container.LinkWebAddress = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that outdents the content.
        /// </summary>
        /// <param name="value">The value for Outdent</param>
        public EditorMessagesSettingsBuilder Outdent(string value)
        {
            Container.Outdent = value;
            return this;
        }

        /// <summary>
        /// The title of the Print tool.
        /// </summary>
        /// <param name="value">The value for Print</param>
        public EditorMessagesSettingsBuilder Print(string value)
        {
            Container.Print = value;
            return this;
        }

        /// <summary>
        /// The title of the Rows field in Table Wizard.
        /// </summary>
        /// <param name="value">The value for Rows</param>
        public EditorMessagesSettingsBuilder Rows(string value)
        {
            Container.Rows = value;
            return this;
        }

        /// <summary>
        /// The title of the Select All Cells tool.
        /// </summary>
        /// <param name="value">The value for SelectAllCells</param>
        public EditorMessagesSettingsBuilder SelectAllCells(string value)
        {
            Container.SelectAllCells = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that strikes through text.
        /// </summary>
        /// <param name="value">The value for Strikethrough</param>
        public EditorMessagesSettingsBuilder Strikethrough(string value)
        {
            Container.Strikethrough = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that makes text subscript.
        /// </summary>
        /// <param name="value">The value for Subscript</param>
        public EditorMessagesSettingsBuilder Subscript(string value)
        {
            Container.Subscript = value;
            return this;
        }

        /// <summary>
        /// The title of the Summary field in Table Wizard.
        /// </summary>
        /// <param name="value">The value for Summary</param>
        public EditorMessagesSettingsBuilder Summary(string value)
        {
            Container.Summary = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that makes text superscript.
        /// </summary>
        /// <param name="value">The value for Superscript</param>
        public EditorMessagesSettingsBuilder Superscript(string value)
        {
            Container.Superscript = value;
            return this;
        }

        /// <summary>
        /// The title of the Table tab in Table Wizard.
        /// </summary>
        /// <param name="value">The value for TableTab</param>
        public EditorMessagesSettingsBuilder TableTab(string value)
        {
            Container.TableTab = value;
            return this;
        }

        /// <summary>
        /// The title of the Table Wizard tool.
        /// </summary>
        /// <param name="value">The value for TableWizard</param>
        public EditorMessagesSettingsBuilder TableWizard(string value)
        {
            Container.TableWizard = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that underlines text.
        /// </summary>
        /// <param name="value">The value for Underline</param>
        public EditorMessagesSettingsBuilder Underline(string value)
        {
            Container.Underline = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that removes hyperlinks.
        /// </summary>
        /// <param name="value">The value for Unlink</param>
        public EditorMessagesSettingsBuilder Unlink(string value)
        {
            Container.Unlink = value;
            return this;
        }

        /// <summary>
        /// The title of the tool that shows the editor value as HTML.
        /// </summary>
        /// <param name="value">The value for ViewHtml</param>
        public EditorMessagesSettingsBuilder ViewHtml(string value)
        {
            Container.ViewHtml = value;
            return this;
        }

        /// <summary>
        /// The title of the Width fields.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public EditorMessagesSettingsBuilder Width(string value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// The title of the Wrap Text option in Table Wizard.
        /// </summary>
        /// <param name="value">The value for WrapText</param>
        public EditorMessagesSettingsBuilder WrapText(string value)
        {
            Container.WrapText = value;
            return this;
        }

    }
}
