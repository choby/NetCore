using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SplitterPane
    /// </summary>
    public partial class SplitterPaneBuilder
        
    {
        /// <summary>
        /// Specifies whether a pane is initially collapsed (true) or expanded (true).
        /// </summary>
        /// <param name="value">The value for Collapsed</param>
        public SplitterPaneBuilder Collapsed(bool value)
        {
            Container.Collapsed = value;
            return this;
        }

        /// <summary>
        /// Specifies the size of a collapsed pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%"). This value must not exceed panes.max or be less then panes.min.
        /// </summary>
        /// <param name="value">The value for CollapsedSize</param>
        public SplitterPaneBuilder CollapsedSize(string value)
        {
            Container.CollapsedSize = value;
            return this;
        }

        /// <summary>
        /// Specifies whether a pane is collapsible (true) or not collapsible (false).
        /// </summary>
        /// <param name="value">The value for Collapsible</param>
        public SplitterPaneBuilder Collapsible(bool value)
        {
            Container.Collapsible = value;
            return this;
        }

        /// <summary>
        /// Specifies whether a pane is resizable (true) or not resizable (false).
        /// </summary>
        /// <param name="value">The value for Resizable</param>
        public SplitterPaneBuilder Resizable(bool value)
        {
            Container.Resizable = value;
            return this;
        }

        /// <summary>
        /// Specifies whether a pane is scrollable (true) or not scrollable (false).
        /// </summary>
        /// <param name="value">The value for Scrollable</param>
        public SplitterPaneBuilder Scrollable(bool value)
        {
            Container.Scrollable = value;
            return this;
        }

        /// <summary>
        /// Specifies the size of a pane defined as pixels (i.e. "200px") or as a percentage (i.e. "50%"). This value must not exceed panes.max or be less then panes.min.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public SplitterPaneBuilder Size(string value)
        {
            Container.Size = value;
            return this;
        }

    }
}
