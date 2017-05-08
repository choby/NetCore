using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ToolBar
    /// </summary>
    public partial class ToolBarBuilder
        
    {
        /// <summary>
        /// If resizable is set to true the widget will detect changes in the viewport width and hides the overflowing controls in the command overflow popup.
        /// </summary>
        /// <param name="value">The value for Resizable</param>
        public ToolBarBuilder Resizable(bool value)
        {
            Container.Resizable = value;
            return this;
        }

        /// <summary>
        /// A JavaScript array that contains the ToolBar's commands configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the items setting.</param>
        public ToolBarBuilder Items(Action<ToolBarItemFactory> configurator)
        {

            configurator(new ToolBarItemFactory(Container.Items)
            {
                ToolBar = Container
            });

            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().ToolBar()
        ///       .Name("ToolBar")
        ///       .Events(events => events
        ///           .Click("onClick")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ToolBarBuilder Events(Action<ToolBarEventBuilder> configurator)
        {
            configurator(new ToolBarEventBuilder(Container.Events));
            return this;
        }
        
    }
}

