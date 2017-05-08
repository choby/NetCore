using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<SplitterPane>
    /// </summary>
    public partial class SplitterPaneFactory
        
    {
        public SplitterPaneFactory(List<SplitterPane> container)
        {
            Container = container;
        }

        protected List<SplitterPane> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
