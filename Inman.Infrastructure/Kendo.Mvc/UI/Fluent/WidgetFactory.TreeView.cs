using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a <see cref="TreeView"/>
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().TreeView()
        ///             .Name("TreeView")
        /// )
        /// </code>
        /// </example>
        public virtual TreeViewBuilder TreeView()
        {
            return new TreeViewBuilder(new TreeView(HtmlHelper.ViewContext));
        }
    }
}