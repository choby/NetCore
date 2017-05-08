namespace Kendo.Mvc.UI.Fluent
{
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class ReadOnlyCustomDataSourceTransportBuilder : CustomDataSourceTransportBuilderBase<ReadOnlyCustomDataSourceTransportBuilder>, IHideObjectMembers
    {
        public ReadOnlyCustomDataSourceTransportBuilder(Transport transport, ViewContext viewContext, IUrlGenerator urlGenerator)
            : base(transport, viewContext, urlGenerator)
        { 
        }
    }
}
