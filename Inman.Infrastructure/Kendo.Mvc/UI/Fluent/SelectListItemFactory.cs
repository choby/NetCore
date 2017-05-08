namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using Infrastructure;
    using Microsoft.AspNetCore.Mvc.Rendering;
    /// <summary>
    /// Creates items for the <see cref="DropDownListItem" />.
    /// </summary>
    public class SelectListItemFactory : IHideObjectMembers
    {
        private readonly IList<SelectListItem> container;

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectListItemFactory"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public SelectListItemFactory(IList<SelectListItem> container)
        {
            this.container = container;
        }

        /// <summary>
        /// Defines a item.
        /// </summary>
        /// <returns></returns>
        public SelectListItemBuilder Add()
        {
            SelectListItem item = new SelectListItem();

            container.Add(item);

            return new SelectListItemBuilder(item);
        }
    }
}
