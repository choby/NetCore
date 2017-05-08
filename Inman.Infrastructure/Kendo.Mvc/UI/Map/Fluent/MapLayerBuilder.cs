using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MapLayer
    /// </summary>
    public partial class MapLayerBuilder
        
    {
        public MapLayerBuilder(MapLayer container)
        {
            Container = container;
        }

        protected MapLayer Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Configures the data source of the map layer.
        /// </summary>
        /// <param name="configurator">The configuration of the data source.</param>
        /// <returns></returns>
        public MapLayerBuilder DataSource(Action<MapLayerDataSourceBuilder> configurator)
        {
            Container.DataSource = new DataSource(Container.Map.ModelMetadataProvider);
            configurator(new MapLayerDataSourceBuilder(Container.DataSource, Container.Map.ViewContext, Container.Map.UrlGenerator));

            return this;
        }

        /// <summary>
        /// The marker shape name. The "pin" and "pinTarget" shapes are predefined.
        /// </summary>
        /// <param name="value">The name of the shape.</param>
        public MapLayerBuilder Shape(string name)
        {
            Container.ShapeName = name;

            return this;
        }

        /// <summary>
        /// The bubble layer symbol type. The "circle" and "square" symbols are predefined.
        /// </summary>
        /// <param name="value">The value that configures the symbol.</param>
        public MapLayerBuilder Symbol(string symbol)
        {
            Container.SymbolName = symbol;

            return this;
        }

        /// <summary>
        /// A client-side function to invoke that will draw the symbol.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will draw the symbol.</param>
        public MapLayerBuilder SymbolHandler(string handler)
        {
            Container.SymbolHandler = new ClientHandlerDescriptor { HandlerName = handler };

            return this;
        }

        /// <summary>
        /// The tooltip options for this marker.
        /// </summary>
        /// <param name="configurator">The action that configures the tooltip.</param>
        public MapLayerBuilder Tooltip(Action<MapMarkerTooltipBuilder> configurator)
        {
            configurator(new MapMarkerTooltipBuilder(Container.Tooltip));
            return this;
        }
    }
}
