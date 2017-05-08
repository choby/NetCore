using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridGroupableSettings
    /// </summary>
    public partial class GridGroupableSettingsBuilder<T>
        
    {
        public GridGroupableSettingsBuilder(GridGroupableSettings<T> container)
        {
            Container = container;
        }

        protected GridGroupableSettings<T> Container
        {
            get;
            private set;
        }

		/// <summary>
		/// Configures messages.
		/// </summary>        
		/// <returns></returns>
		public GridGroupableSettingsBuilder<T> Messages(Action<GridGroupableMessagesBuilder> configurator)
		{
			configurator(new GridGroupableMessagesBuilder(Container.Messages));

			return this;
		}
	}
}
