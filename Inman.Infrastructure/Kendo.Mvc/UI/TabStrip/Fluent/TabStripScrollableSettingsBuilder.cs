using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TabStripScrollableSettings
    /// </summary>
    public partial class TabStripScrollableSettingsBuilder
        
    {
        public TabStripScrollableSettingsBuilder(TabStripScrollableSettings container)
        {
            Container = container;
        }

        protected TabStripScrollableSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Enables or disables scrolling. By default scrolling is enabled.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().TabStrip()
        ///             .Name("TabStrip")
        ///             .Scrollable(s => s.Enabled(false))
        /// %&gt;
        /// </code>
        /// </example>
        /// <remarks>
        /// The Enabled method is useful when you need to enable scrolling based on certain conditions.
        /// </remarks>
        public virtual TabStripScrollableSettingsBuilder Enabled(bool value)
        {
            Container.Enabled = value;

            return this;
        }
    }
}
