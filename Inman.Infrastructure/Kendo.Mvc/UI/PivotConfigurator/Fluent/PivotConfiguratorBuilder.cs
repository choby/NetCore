using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI PivotConfigurator
    /// </summary>
    public partial class PivotConfiguratorBuilder: WidgetBuilderBase<PivotConfigurator, PivotConfiguratorBuilder>
        
    {
        public PivotConfiguratorBuilder(PivotConfigurator component) : base(component)
        {
        }

        /// <summary>
        /// Sets the messages of the pivotConfigurator.
        /// </summary>
        /// <param name="addViewAction">The lambda which configures the pivotConfigurator messages</param>
        public PivotConfiguratorBuilder Messages(Action<PivotConfiguratorMessagesBuilder> addViewAction)
        {
            PivotConfiguratorMessagesBuilder builder = new PivotConfiguratorMessagesBuilder(Component.Messages);

            addViewAction(builder);

            return this;
        }
    }
}

