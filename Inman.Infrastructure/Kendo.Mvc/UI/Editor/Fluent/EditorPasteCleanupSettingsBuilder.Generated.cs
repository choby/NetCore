using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorPasteCleanupSettings
    /// </summary>
    public partial class EditorPasteCleanupSettingsBuilder
        
    {
        /// <summary>
        /// All HTML tags are stripped leaving only the text in the content.
        /// </summary>
        /// <param name="value">The value for All</param>
        public EditorPasteCleanupSettingsBuilder All(bool value)
        {
            Container.All = value;
            return this;
        }

        /// <summary>
        /// All HTML tags are stripped leaving only the text in the content.
        /// </summary>
        public EditorPasteCleanupSettingsBuilder All()
        {
            Container.All = true;
            return this;
        }

        /// <summary>
        /// Remove style and class attributes from the pasting content.
        /// </summary>
        /// <param name="value">The value for Css</param>
        public EditorPasteCleanupSettingsBuilder Css(bool value)
        {
            Container.Css = value;
            return this;
        }

        /// <summary>
        /// Remove style and class attributes from the pasting content.
        /// </summary>
        public EditorPasteCleanupSettingsBuilder Css()
        {
            Container.Css = true;
            return this;
        }

        /// <summary>
        /// Use a callback function to integrate a custom implementation for cleaning up the paste content. Make sure the callback function always returns the result.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public EditorPasteCleanupSettingsBuilder Custom(string handler)
        {
            Container.Custom = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Use a callback function to integrate a custom implementation for cleaning up the paste content. Make sure the callback function always returns the result.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public EditorPasteCleanupSettingsBuilder Custom(Func<object, object> handler)
        {
            Container.Custom = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// Strip all HTML tags but keep new lines in the pasted content.
        /// </summary>
        /// <param name="value">The value for KeepNewLines</param>
        public EditorPasteCleanupSettingsBuilder KeepNewLines(bool value)
        {
            Container.KeepNewLines = value;
            return this;
        }

        /// <summary>
        /// Strip all HTML tags but keep new lines in the pasted content.
        /// </summary>
        public EditorPasteCleanupSettingsBuilder KeepNewLines()
        {
            Container.KeepNewLines = true;
            return this;
        }

        /// <summary>
        /// Remove all special formatting from MS Word content like font-name, font-size and MS Word specific tags.
        /// </summary>
        /// <param name="value">The value for MsAllFormatting</param>
        public EditorPasteCleanupSettingsBuilder MsAllFormatting(bool value)
        {
            Container.MsAllFormatting = value;
            return this;
        }

        /// <summary>
        /// Remove all special formatting from MS Word content like font-name, font-size and MS Word specific tags.
        /// </summary>
        public EditorPasteCleanupSettingsBuilder MsAllFormatting()
        {
            Container.MsAllFormatting = true;
            return this;
        }

        /// <summary>
        /// Converts MS Word pasted content into HTML lists.
        /// </summary>
        /// <param name="value">The value for MsConvertLists</param>
        public EditorPasteCleanupSettingsBuilder MsConvertLists(bool value)
        {
            Container.MsConvertLists = value;
            return this;
        }

        /// <summary>
        /// Removes all MS Word specific tags and cleans up the extra metadata.
        /// </summary>
        /// <param name="value">The value for MsTags</param>
        public EditorPasteCleanupSettingsBuilder MsTags(bool value)
        {
            Container.MsTags = value;
            return this;
        }

        /// <summary>
        /// Prevent any cleaning up of the content.
        /// </summary>
        /// <param name="value">The value for None</param>
        public EditorPasteCleanupSettingsBuilder None(bool value)
        {
            Container.None = value;
            return this;
        }

        /// <summary>
        /// Prevent any cleaning up of the content.
        /// </summary>
        public EditorPasteCleanupSettingsBuilder None()
        {
            Container.None = true;
            return this;
        }

        /// <summary>
        /// Remove all span elements from the content, ensuring much of the inline formatting is removed.
        /// </summary>
        /// <param name="value">The value for Span</param>
        public EditorPasteCleanupSettingsBuilder Span(bool value)
        {
            Container.Span = value;
            return this;
        }

        /// <summary>
        /// Remove all span elements from the content, ensuring much of the inline formatting is removed.
        /// </summary>
        public EditorPasteCleanupSettingsBuilder Span()
        {
            Container.Span = true;
            return this;
        }

    }
}
