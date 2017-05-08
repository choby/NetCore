using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayerDefaultsBubbleSettings
    /// </summary>
    public partial class MapLayerDefaultsBubbleSettingsBuilder
        
    {
        public MapLayerDefaultsBubbleSettingsBuilder(MapLayerDefaultsBubbleSettings container)
        {
            Container = container;
        }

        protected MapLayerDefaultsBubbleSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The bubble layer symbol type. The "circle" and "square" symbols are predefined.
        /// </summary>
        /// <param name="value">The value that configures the symbol.</param>
        public MapLayerDefaultsBubbleSettingsBuilder Symbol(string symbol)
        {
            Container.SymbolName = symbol;

            return this;
        }

        /// <summary>
        /// A client-side function to invoke that will draw the symbol.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will draw the symbol.</param>
        public MapLayerDefaultsBubbleSettingsBuilder SymbolHandler(string handler)
        {
            Container.SymbolHandler = new ClientHandlerDescriptor { HandlerName = handler };

            return this;
        }
    }
}
