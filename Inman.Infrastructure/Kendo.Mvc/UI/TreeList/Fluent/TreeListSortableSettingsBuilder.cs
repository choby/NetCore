using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListSortableSettings
    /// </summary>
    public partial class TreeListSortableSettingsBuilder<T>
        
    {
        public TreeListSortableSettingsBuilder(TreeListSortableSettings<T> container)
        {
            Container = container;
        }

        protected TreeListSortableSettings<T> Container
        {
            get;
            private set;
        }

		/// <summary>
		/// The sorting mode. If set to "single" the user can sort by one column. If set to "multiple" the user can sort by multiple columns.
		/// </summary>
		/// <param name="value">The value for Mode</param>
		public TreeListSortableSettingsBuilder<T> Mode(string value)
		{
			Container.Mode = value == "single" ? TreeListSortMode.SingleColumn : TreeListSortMode.MultipleColumn;
			return this;
		}
	}
}
