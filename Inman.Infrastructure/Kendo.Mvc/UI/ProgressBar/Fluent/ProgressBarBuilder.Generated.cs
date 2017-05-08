using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ProgressBar
    /// </summary>
    public partial class ProgressBarBuilder
        
    {
        /// <summary>
        /// Configures the progress animation. Currently only the duration of the animation could be set.
        /// </summary>
        /// <param name="configurator">The configurator for the animation setting.</param>
        public ProgressBarBuilder Animation(Action<ProgressBarAnimationSettingsBuilder> configurator)
        {

            Container.Animation.ProgressBar = Container;
            configurator(new ProgressBarAnimationSettingsBuilder(Container.Animation));

            return this;
        }

        /// <summary>
        /// Specifies the number of chunks.
        /// </summary>
        /// <param name="value">The value for ChunkCount</param>
        public ProgressBarBuilder ChunkCount(double value)
        {
            Container.ChunkCount = value;
            return this;
        }

        /// <summary>
        /// If set to false the widget will be disabled. It will still allow changing the value. The widget is enabled by default.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public ProgressBarBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// The maximum value of the ProgressBar.
        /// </summary>
        /// <param name="value">The value for Max</param>
        public ProgressBarBuilder Max(double value)
        {
            Container.Max = value;
            return this;
        }

        /// <summary>
        /// The minimum value of the ProgressBar.
        /// </summary>
        /// <param name="value">The value for Min</param>
        public ProgressBarBuilder Min(double value)
        {
            Container.Min = value;
            return this;
        }

        /// <summary>
        /// Specifies if the progress direction will be reversed.
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public ProgressBarBuilder Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// Specifies if the progress direction will be reversed.
        /// </summary>
        public ProgressBarBuilder Reverse()
        {
            Container.Reverse = true;
            return this;
        }

        /// <summary>
        /// Specifies if the progress status will be shown.
        /// </summary>
        /// <param name="value">The value for ShowStatus</param>
        public ProgressBarBuilder ShowStatus(bool value)
        {
            Container.ShowStatus = value;
            return this;
        }

        /// <summary>
        /// Defines the orientation of the ProgressBar.
        /// </summary>
        /// <param name="value">The value for Orientation</param>
        public ProgressBarBuilder Orientation(ProgressBarOrientation value)
        {
            Container.Orientation = value;
            return this;
        }

        /// <summary>
        /// Represents the supported progress types
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ProgressBarBuilder Type(ProgressBarType value)
        {
            Container.Type = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().ProgressBar()
        ///       .Name("ProgressBar")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ProgressBarBuilder Events(Action<ProgressBarEventBuilder> configurator)
        {
            configurator(new ProgressBarEventBuilder(Container.Events));
            return this;
        }
        
    }
}

