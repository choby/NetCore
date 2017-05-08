using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Map for ASP.NET MVC layer data source.
    /// </summary>
    public class MapLayerDataSourceBuilder : ReadOnlyAjaxDataSourceBuilder<object>
    {
        public MapLayerDataSourceBuilder(DataSource dataSource, ViewContext viewContext, IUrlGenerator urlGenerator)
            : base(dataSource, viewContext, urlGenerator)
        {
            dataSource.Schema.Data = "";
            dataSource.Schema.Total = "";
            dataSource.Schema.Errors = "";

            dataSource.Type = DataSourceType.Ajax;
            dataSource.Transport.Read.ActionName = "POST";
        }

        public GeoJsonDataSourceBuilder GeoJson()
        {
            dataSource.Type = DataSourceType.GeoJson;
            dataSource.Transport.Read.ActionName = "";
            return new GeoJsonDataSourceBuilder(dataSource, viewContext, urlGenerator);
        }
    }
}

