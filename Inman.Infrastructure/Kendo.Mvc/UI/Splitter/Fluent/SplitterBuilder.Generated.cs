using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Splitter
    /// </summary>
    public partial class SplitterBuilder
        
    {
        /// <summary>
        /// Defines the panes of the splitter
        /// </summary>
        /// <param name="configurator">The configurator for the panes setting.</param>
        public SplitterBuilder Panes(Action<SplitterPaneFactory> configurator)
        {

            configurator(new SplitterPaneFactory(Container.Panes)
            {
                Splitter = Container
            });

            return this;
        }

        /// <summary>
        /// Specifies the orientation in which the splitter panes will be ordered
        /// </summary>
        /// <param name="value">The value for Orientation</param>
        public SplitterBuilder Orientation(SplitterOrientation value)
        {
            Container.Orientation = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Splitter()
        ///       .Name("Splitter")
        ///       .Events(events => events
        ///           .Collapse("onCollapse")
        ///       )
        /// )
        /// </code>
        /// </example>
        public SplitterBuilder Events(Action<SplitterEventBuilder> configurator)
        {
            configurator(new SplitterEventBuilder(Container.Events));
            return this;
        }
        
    }
}

