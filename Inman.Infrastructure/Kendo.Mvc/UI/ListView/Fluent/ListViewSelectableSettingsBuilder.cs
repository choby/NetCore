using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ListViewSelectableSettings
    /// </summary>
    public partial class ListViewSelectableSettingsBuilder<T>
        where T : class 
    {
        public ListViewSelectableSettingsBuilder(ListViewSelectableSettings<T> container)
        {
            Container = container;
        }

        protected ListViewSelectableSettings<T> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Enables or disables selection.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ListView(Model)
        ///             .Name("ListView")
        ///             .Selectable(selection => selection.Enabled((bool)ViewData["enableSelection"]))
        /// %&gt;
        /// </code>
        /// </example>        
        public ListViewSelectableSettingsBuilder<T> Enabled(bool value)
        {
            Container.Enabled = value;
            if (!Container.Mode.HasValue)
            {
                Container.Mode = ListViewSelectionMode.Single;
            }
            return this;
        }
    }
}
