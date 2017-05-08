using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="CrudOperation"/> options.
    /// </summary>
    public class CrudOperationBuilder: CrudOperationBuilderBase<CrudOperationBuilder>, IHideObjectMembers
    {
        public CrudOperationBuilder(CrudOperation operation, ViewContext viewContext, IUrlGenerator urlGenerator)
            : base(operation, viewContext, urlGenerator)
        {
        }
    }
}
