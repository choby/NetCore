using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<EditorTool>
    /// </summary>
    public partial class EditorToolFactory

    {
        public EditorToolFactory(List<EditorTool> container)
        {
            Container = container;
        }

        protected List<EditorTool> Container
        {
            get;
            private set;
        }

        // Place custom settings here

        [Obsolete("The FontColor tool is deprecated. Please use the ForeColor tool instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public EditorToolFactory FontColor()
        {
            AddTool("foreColor");
            return this;
        }

        [Obsolete("The FontColor tool is deprecated. Please use the ForeColor tool instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public EditorToolFactory FontColor(Action<EditorToolBuilder> configurator)
        {
            AddTool("foreColor", configurator);
            return this;
        }

        /// <summary>
        /// Adds a custom button tool.
        /// </summary>
        /// <param name="configurator"></param>
        /// <returns></returns>
        public EditorToolFactory CustomButton(Action<EditorToolBuilder> configurator)
        {
            AddTool(null, configurator);

            return this;
        }

        /// <summary>
        /// Adds a custom template tool.
        /// </summary>
        /// <param name="configurator"></param>
        /// <returns></returns>
        public EditorToolFactory CustomTemplate(Action<EditorToolBuilder> configurator)
        {
            AddTool(null, configurator);

            return this;
        }
    }
}
