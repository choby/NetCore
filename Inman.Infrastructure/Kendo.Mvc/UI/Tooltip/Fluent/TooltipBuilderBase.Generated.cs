using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Tooltip
    /// </summary>
    public partial class TooltipBuilderBase<TBuilder>   
    {
        /// <summary>
        /// Specifies if the Tooltip will be hidden when mouse leaves the target element. If set to false a close button will be shown within Tooltip. If set to false, showAfter is specified and the showOn is set to "mouseenter" the Tooltip will be displayed after the given timeout even if the element is no longer hovered.
        /// </summary>
        /// <param name="value">The value for AutoHide</param>
        public TBuilder AutoHide(bool value)
        {
            Container.AutoHide = value;
            return this as TBuilder;
        }

        /// <summary>
        /// Specifies if the Tooltip callout will be displayed.
        /// </summary>
        /// <param name="value">The value for Callout</param>
        public TBuilder Callout(bool value)
        {
            Container.Callout = value;
            return this as TBuilder;
        }

        /// <summary>
        /// Specifies a selector for elements, within the container, for which the Tooltip will be displayed.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        public TBuilder Filter(string value)
        {
            Container.Filter = value;
            return this as TBuilder;
        }

        /// <summary>
        /// Explicitly states whether content iframe should be created.
        /// </summary>
        /// <param name="value">The value for Iframe</param>
        public TBuilder Iframe(bool value)
        {
            Container.Iframe = value;
            return this as TBuilder;
        }

        /// <summary>
        /// The height (in pixels) of the Tooltip.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public TBuilder Height(double value)
        {
            Container.Height = value;
            return this as TBuilder;
        }

        /// <summary>
        /// The width (in pixels) of the Tooltip.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public TBuilder Width(double value)
        {
            Container.Width = value;
            return this as TBuilder;
        }

        /// <summary>
        /// Specify the delay in milliseconds before the Tooltip is shown. This option is ignored if showOn is set to "click" or "focus".
        /// </summary>
        /// <param name="value">The value for ShowAfter</param>
        public TBuilder ShowAfter(double value)
        {
            Container.ShowAfter = value;
            return this as TBuilder;
        }

        /// <summary>
        /// Represents the tooltip position.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public TBuilder Position(TooltipPosition value)
        {
            Container.Position = value;
            return this as TBuilder;
        }

        /// <summary>
        /// Represents the tooltip position.
        /// </summary>
        /// <param name="value">The value for ShowOn</param>
        public TBuilder ShowOn(TooltipShowOnEvent value)
        {
            Container.ShowOn = value;
            return this as TBuilder;
        }
        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Tooltip()
        ///       .Name("Tooltip")
        ///       .Events(events => events
        ///           .ContentLoad("onContentLoad")
        ///       )
        /// )
        /// </code>
        /// </example>
        public TBuilder Events(Action<TooltipEventBuilder> configurator)
        {
            configurator(new TooltipEventBuilder(Container.Events));
            return this as TBuilder;
        }        
    }
}

