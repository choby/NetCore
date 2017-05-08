using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Map
    /// </summary>
    public partial class MapLayerFactory
        
    {

        public Map Map { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual MapLayerBuilder Add()
        {
            var item = new MapLayer();
            item.Map = Map;
            Container.Add(item);

            return new MapLayerBuilder(item);
        }
    }
}
