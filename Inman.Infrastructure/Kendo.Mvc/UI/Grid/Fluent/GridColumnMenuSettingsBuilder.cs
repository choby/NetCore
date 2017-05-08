using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridColumnMenuSettings
    /// </summary>
    public partial class GridColumnMenuSettingsBuilder<T>
        
    {
        public GridColumnMenuSettingsBuilder(GridColumnMenuSettings<T> container)
        {
            Container = container;
        }

        protected GridColumnMenuSettings<T> Container
        {
            get;
            private set;
        }

		/// <summary>
		/// Enables you to define custom messages in grid column menu.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().Grid(Model)
		///             .Name("Grid")
		///             .ColumnMenu(menu => menu.Messages(msg => msg.Filter("Custom filter message")))
		///	 )
		/// </code>
		/// </example>
		public GridColumnMenuSettingsBuilder<T> Messages(Action<GridColumnMenuMessagesBuilder> configurator)
		{
			configurator(new GridColumnMenuMessagesBuilder(Container.Messages));

			return this;
		}

		/// <summary>
		/// Enables/disables header column menu.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().Grid(Model)
		///             .Name("Grid")
		///             .ColumnMenu(menu => menu.Enabled((bool)ViewData["enableColumnMenu"]))
		///  )
		/// </code>
		/// </example>
		/// <remarks>
		/// The Enabled method is useful when you need to enable column menu based on certain conditions.
		/// </remarks>
		public GridColumnMenuSettingsBuilder<T> Enabled(bool value)
		{
			Container.Enabled = value;

			return this;
		}
	}
}
