using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI EditorMessagesSettings class
    /// </summary>
    public partial class EditorMessagesSettings 
    {
        public string AccessibilityTab { get; set; }

        public string AddColumnLeft { get; set; }

        public string AddColumnRight { get; set; }

        public string AddRowAbove { get; set; }

        public string AddRowBelow { get; set; }

        public string AlignCenter { get; set; }

        public string AlignCenterBottom { get; set; }

        public string AlignCenterMiddle { get; set; }

        public string AlignCenterTop { get; set; }

        public string AlignLeft { get; set; }

        public string AlignLeftBottom { get; set; }

        public string AlignLeftMiddle { get; set; }

        public string AlignLeftTop { get; set; }

        public string AlignRemove { get; set; }

        public string AlignRight { get; set; }

        public string AlignRightBottom { get; set; }

        public string AlignRightMiddle { get; set; }

        public string AlignRightTop { get; set; }

        public string Alignment { get; set; }

        public string AssociateCellsWithHeaders { get; set; }

        public string BackColor { get; set; }

        public string Background { get; set; }

        public string Bold { get; set; }

        public string Border { get; set; }

        public string Style { get; set; }

        public string Caption { get; set; }

        public string CellMargin { get; set; }

        public string CellPadding { get; set; }

        public string CellSpacing { get; set; }

        public string CellTab { get; set; }

        public string CleanFormatting { get; set; }

        public string CollapseBorders { get; set; }

        public string Columns { get; set; }

        public string CreateLink { get; set; }

        public string CreateTable { get; set; }

        public string CreateTableHint { get; set; }

        public string CssClass { get; set; }

        public string DeleteColumn { get; set; }

        public string DeleteRow { get; set; }

        public string DialogCancel { get; set; }

        public string DialogInsert { get; set; }

        public string DialogOk { get; set; }

        public string DialogUpdate { get; set; }

        public string EditAreaTitle { get; set; }

        public string FileTitle { get; set; }

        public string FileWebAddress { get; set; }

        public string FontName { get; set; }

        public string FontNameInherit { get; set; }

        public string FontSize { get; set; }

        public string FontSizeInherit { get; set; }

        public string ForeColor { get; set; }

        public string FormatBlock { get; set; }

        public string Formatting { get; set; }

        public string Height { get; set; }

        public string Id { get; set; }

        public string ImageAltText { get; set; }

        public string ImageHeight { get; set; }

        public string ImageWebAddress { get; set; }

        public string ImageWidth { get; set; }

        public string Indent { get; set; }

        public string InsertFile { get; set; }

        public string InsertHtml { get; set; }

        public string InsertImage { get; set; }

        public string InsertOrderedList { get; set; }

        public string InsertUnorderedList { get; set; }

        public string Italic { get; set; }

        public string JustifyCenter { get; set; }

        public string JustifyFull { get; set; }

        public string JustifyLeft { get; set; }

        public string JustifyRight { get; set; }

        public string LinkOpenInNewWindow { get; set; }

        public string LinkText { get; set; }

        public string LinkToolTip { get; set; }

        public string LinkWebAddress { get; set; }

        public string Outdent { get; set; }

        public string Print { get; set; }

        public string Rows { get; set; }

        public string SelectAllCells { get; set; }

        public string Strikethrough { get; set; }

        public string Subscript { get; set; }

        public string Summary { get; set; }

        public string Superscript { get; set; }

        public string TableTab { get; set; }

        public string TableWizard { get; set; }

        public string Underline { get; set; }

        public string Unlink { get; set; }

        public string ViewHtml { get; set; }

        public string Width { get; set; }

        public string WrapText { get; set; }


        public Editor Editor { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AccessibilityTab?.HasValue() == true)
            {
                settings["accessibilityTab"] = AccessibilityTab;
            }

            if (AddColumnLeft?.HasValue() == true)
            {
                settings["addColumnLeft"] = AddColumnLeft;
            }

            if (AddColumnRight?.HasValue() == true)
            {
                settings["addColumnRight"] = AddColumnRight;
            }

            if (AddRowAbove?.HasValue() == true)
            {
                settings["addRowAbove"] = AddRowAbove;
            }

            if (AddRowBelow?.HasValue() == true)
            {
                settings["addRowBelow"] = AddRowBelow;
            }

            if (AlignCenter?.HasValue() == true)
            {
                settings["alignCenter"] = AlignCenter;
            }

            if (AlignCenterBottom?.HasValue() == true)
            {
                settings["alignCenterBottom"] = AlignCenterBottom;
            }

            if (AlignCenterMiddle?.HasValue() == true)
            {
                settings["alignCenterMiddle"] = AlignCenterMiddle;
            }

            if (AlignCenterTop?.HasValue() == true)
            {
                settings["alignCenterTop"] = AlignCenterTop;
            }

            if (AlignLeft?.HasValue() == true)
            {
                settings["alignLeft"] = AlignLeft;
            }

            if (AlignLeftBottom?.HasValue() == true)
            {
                settings["alignLeftBottom"] = AlignLeftBottom;
            }

            if (AlignLeftMiddle?.HasValue() == true)
            {
                settings["alignLeftMiddle"] = AlignLeftMiddle;
            }

            if (AlignLeftTop?.HasValue() == true)
            {
                settings["alignLeftTop"] = AlignLeftTop;
            }

            if (AlignRemove?.HasValue() == true)
            {
                settings["alignRemove"] = AlignRemove;
            }

            if (AlignRight?.HasValue() == true)
            {
                settings["alignRight"] = AlignRight;
            }

            if (AlignRightBottom?.HasValue() == true)
            {
                settings["alignRightBottom"] = AlignRightBottom;
            }

            if (AlignRightMiddle?.HasValue() == true)
            {
                settings["alignRightMiddle"] = AlignRightMiddle;
            }

            if (AlignRightTop?.HasValue() == true)
            {
                settings["alignRightTop"] = AlignRightTop;
            }

            if (Alignment?.HasValue() == true)
            {
                settings["alignment"] = Alignment;
            }

            if (AssociateCellsWithHeaders?.HasValue() == true)
            {
                settings["associateCellsWithHeaders"] = AssociateCellsWithHeaders;
            }

            if (BackColor?.HasValue() == true)
            {
                settings["backColor"] = BackColor;
            }

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            if (Bold?.HasValue() == true)
            {
                settings["bold"] = Bold;
            }

            if (Border?.HasValue() == true)
            {
                settings["border"] = Border;
            }

            if (Style?.HasValue() == true)
            {
                settings["style"] = Style;
            }

            if (Caption?.HasValue() == true)
            {
                settings["caption"] = Caption;
            }

            if (CellMargin?.HasValue() == true)
            {
                settings["cellMargin"] = CellMargin;
            }

            if (CellPadding?.HasValue() == true)
            {
                settings["cellPadding"] = CellPadding;
            }

            if (CellSpacing?.HasValue() == true)
            {
                settings["cellSpacing"] = CellSpacing;
            }

            if (CellTab?.HasValue() == true)
            {
                settings["cellTab"] = CellTab;
            }

            if (CleanFormatting?.HasValue() == true)
            {
                settings["cleanFormatting"] = CleanFormatting;
            }

            if (CollapseBorders?.HasValue() == true)
            {
                settings["collapseBorders"] = CollapseBorders;
            }

            if (Columns?.HasValue() == true)
            {
                settings["columns"] = Columns;
            }

            if (CreateLink?.HasValue() == true)
            {
                settings["createLink"] = CreateLink;
            }

            if (CreateTable?.HasValue() == true)
            {
                settings["createTable"] = CreateTable;
            }

            if (CreateTableHint?.HasValue() == true)
            {
                settings["createTableHint"] = CreateTableHint;
            }

            if (CssClass?.HasValue() == true)
            {
                settings["cssClass"] = CssClass;
            }

            if (DeleteColumn?.HasValue() == true)
            {
                settings["deleteColumn"] = DeleteColumn;
            }

            if (DeleteRow?.HasValue() == true)
            {
                settings["deleteRow"] = DeleteRow;
            }

            if (DialogCancel?.HasValue() == true)
            {
                settings["dialogCancel"] = DialogCancel;
            }

            if (DialogInsert?.HasValue() == true)
            {
                settings["dialogInsert"] = DialogInsert;
            }

            if (DialogOk?.HasValue() == true)
            {
                settings["dialogOk"] = DialogOk;
            }

            if (DialogUpdate?.HasValue() == true)
            {
                settings["dialogUpdate"] = DialogUpdate;
            }

            if (EditAreaTitle?.HasValue() == true)
            {
                settings["editAreaTitle"] = EditAreaTitle;
            }

            if (FileTitle?.HasValue() == true)
            {
                settings["fileTitle"] = FileTitle;
            }

            if (FileWebAddress?.HasValue() == true)
            {
                settings["fileWebAddress"] = FileWebAddress;
            }

            if (FontName?.HasValue() == true)
            {
                settings["fontName"] = FontName;
            }

            if (FontNameInherit?.HasValue() == true)
            {
                settings["fontNameInherit"] = FontNameInherit;
            }

            if (FontSize?.HasValue() == true)
            {
                settings["fontSize"] = FontSize;
            }

            if (FontSizeInherit?.HasValue() == true)
            {
                settings["fontSizeInherit"] = FontSizeInherit;
            }

            if (ForeColor?.HasValue() == true)
            {
                settings["foreColor"] = ForeColor;
            }

            if (FormatBlock?.HasValue() == true)
            {
                settings["formatBlock"] = FormatBlock;
            }

            if (Formatting?.HasValue() == true)
            {
                settings["formatting"] = Formatting;
            }

            if (Height?.HasValue() == true)
            {
                settings["height"] = Height;
            }

            if (Id?.HasValue() == true)
            {
                settings["id"] = Id;
            }

            if (ImageAltText?.HasValue() == true)
            {
                settings["imageAltText"] = ImageAltText;
            }

            if (ImageHeight?.HasValue() == true)
            {
                settings["imageHeight"] = ImageHeight;
            }

            if (ImageWebAddress?.HasValue() == true)
            {
                settings["imageWebAddress"] = ImageWebAddress;
            }

            if (ImageWidth?.HasValue() == true)
            {
                settings["imageWidth"] = ImageWidth;
            }

            if (Indent?.HasValue() == true)
            {
                settings["indent"] = Indent;
            }

            if (InsertFile?.HasValue() == true)
            {
                settings["insertFile"] = InsertFile;
            }

            if (InsertHtml?.HasValue() == true)
            {
                settings["insertHtml"] = InsertHtml;
            }

            if (InsertImage?.HasValue() == true)
            {
                settings["insertImage"] = InsertImage;
            }

            if (InsertOrderedList?.HasValue() == true)
            {
                settings["insertOrderedList"] = InsertOrderedList;
            }

            if (InsertUnorderedList?.HasValue() == true)
            {
                settings["insertUnorderedList"] = InsertUnorderedList;
            }

            if (Italic?.HasValue() == true)
            {
                settings["italic"] = Italic;
            }

            if (JustifyCenter?.HasValue() == true)
            {
                settings["justifyCenter"] = JustifyCenter;
            }

            if (JustifyFull?.HasValue() == true)
            {
                settings["justifyFull"] = JustifyFull;
            }

            if (JustifyLeft?.HasValue() == true)
            {
                settings["justifyLeft"] = JustifyLeft;
            }

            if (JustifyRight?.HasValue() == true)
            {
                settings["justifyRight"] = JustifyRight;
            }

            if (LinkOpenInNewWindow?.HasValue() == true)
            {
                settings["linkOpenInNewWindow"] = LinkOpenInNewWindow;
            }

            if (LinkText?.HasValue() == true)
            {
                settings["linkText"] = LinkText;
            }

            if (LinkToolTip?.HasValue() == true)
            {
                settings["linkToolTip"] = LinkToolTip;
            }

            if (LinkWebAddress?.HasValue() == true)
            {
                settings["linkWebAddress"] = LinkWebAddress;
            }

            if (Outdent?.HasValue() == true)
            {
                settings["outdent"] = Outdent;
            }

            if (Print?.HasValue() == true)
            {
                settings["print"] = Print;
            }

            if (Rows?.HasValue() == true)
            {
                settings["rows"] = Rows;
            }

            if (SelectAllCells?.HasValue() == true)
            {
                settings["selectAllCells"] = SelectAllCells;
            }

            if (Strikethrough?.HasValue() == true)
            {
                settings["strikethrough"] = Strikethrough;
            }

            if (Subscript?.HasValue() == true)
            {
                settings["subscript"] = Subscript;
            }

            if (Summary?.HasValue() == true)
            {
                settings["summary"] = Summary;
            }

            if (Superscript?.HasValue() == true)
            {
                settings["superscript"] = Superscript;
            }

            if (TableTab?.HasValue() == true)
            {
                settings["tableTab"] = TableTab;
            }

            if (TableWizard?.HasValue() == true)
            {
                settings["tableWizard"] = TableWizard;
            }

            if (Underline?.HasValue() == true)
            {
                settings["underline"] = Underline;
            }

            if (Unlink?.HasValue() == true)
            {
                settings["unlink"] = Unlink;
            }

            if (ViewHtml?.HasValue() == true)
            {
                settings["viewHtml"] = ViewHtml;
            }

            if (Width?.HasValue() == true)
            {
                settings["width"] = Width;
            }

            if (WrapText?.HasValue() == true)
            {
                settings["wrapText"] = WrapText;
            }

            return settings;
        }
    }
}
