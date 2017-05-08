using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorToolItem
    /// </summary>
    public partial class EditorToolItemBuilder
        
    {
        /// <summary>
        /// The string that the popup item will show.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public EditorToolItemBuilder Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// The value that will be applied by the tool when this item is selected.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public EditorToolItemBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Only applicable for the formatting tool. Specifies the context in which the option will be available.
        /// </summary>
        /// <param name="value">The value for Context</param>
        public EditorToolItemBuilder Context(string value)
        {
            Container.Context = value;
            return this;
        }

    }
}
