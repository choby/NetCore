using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DialogAction
    /// </summary>
    public partial class DialogActionBuilder
        
    {
        public DialogActionBuilder(DialogAction container)
        {
            Container = container;
        }

        protected DialogAction Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
