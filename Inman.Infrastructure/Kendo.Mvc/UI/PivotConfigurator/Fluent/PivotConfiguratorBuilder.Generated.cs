using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI PivotConfigurator
    /// </summary>
    public partial class PivotConfiguratorBuilder
        
    {
        /// <summary>
        /// If set to true the user will be able to filter by using the field menu.
        /// </summary>
        /// <param name="value">The value for Filterable</param>
        public PivotConfiguratorBuilder Filterable(bool value)
        {
            Container.Filterable = value;
            return this;
        }

        /// <summary>
        /// If set to true the user will be able to filter by using the field menu.
        /// </summary>
        public PivotConfiguratorBuilder Filterable()
        {
            Container.Filterable = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort the widget by clicking the dimension fields. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the sortable setting.</param>
        public PivotConfiguratorBuilder Sortable(Action<PivotConfiguratorSortableSettingsBuilder> configurator)
        {
            Container.Sortable.Enabled = true;

            Container.Sortable.PivotConfigurator = Container;
            configurator(new PivotConfiguratorSortableSettingsBuilder(Container.Sortable));

            return this;
        }

        /// <summary>
        /// If set to true the user could sort the widget by clicking the dimension fields. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        public PivotConfiguratorBuilder Sortable()
        {
            Container.Sortable.Enabled = true;
            return this;
        }

        /// <summary>
        /// If set to true the user could sort the widget by clicking the dimension fields. By default sorting is disabled.Can be set to a JavaScript object which represents the sorting configuration.
        /// </summary>
        /// <param name="enabled">Enables or disables the sortable option.</param>
        public PivotConfiguratorBuilder Sortable(bool enabled)
        {
            Container.Sortable.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The height of the PivotConfigurator. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public PivotConfiguratorBuilder Height(double value)
        {
            Container.Height = value;
            return this;
        }


        
    }
}

