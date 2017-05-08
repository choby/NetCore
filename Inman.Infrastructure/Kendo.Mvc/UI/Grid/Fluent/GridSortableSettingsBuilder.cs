using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridSortableSettings
    /// </summary>
    public partial class GridSortableSettingsBuilder<T>
        
    {
        public GridSortableSettingsBuilder(GridSortableSettings<T> container)
        {
            Container = container;
        }

        protected GridSortableSettings<T> Container
        {
            get;
            private set;
        }

		// <summary>
		/// Enables or disables sorting.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().Grid(Model)
		///             .Name("Grid")
		///             .Sorting(sorting => sorting.Enabled((bool)ViewData["enableSorting"]))
		///  )
		/// </code>
		/// </example>
		/// <remarks>
		/// The Enabled method is useful when you need to enable sorting based on certain conditions.
		/// </remarks>
		public virtual GridSortableSettingsBuilder<T> Enabled(bool value)
		{
			Container.Enabled = value;

			return this;
		}
	}
}
