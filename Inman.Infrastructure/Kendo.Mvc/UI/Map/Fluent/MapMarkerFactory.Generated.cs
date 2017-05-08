using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for adding items to Kendo UI Map
    /// </summary>
    public partial class MapMarkerFactory
        
    {

        public Map Map { get; set; }

        /// <summary>
        /// Adds an item to the collection
        /// </summary>
        public virtual MapMarkerBuilder Add()
        {
            var item = new MapMarker();
            item.Map = Map;
            Container.Add(item);

            return new MapMarkerBuilder(item);
        }
    }
}
