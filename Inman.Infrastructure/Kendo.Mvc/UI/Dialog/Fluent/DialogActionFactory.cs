using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<DialogAction>
    /// </summary>
    public partial class DialogActionFactory
        
    {
        public DialogActionFactory(List<DialogAction> container)
        {
            Container = container;
        }

        protected List<DialogAction> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
