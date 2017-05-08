using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
		/// <summary>
		/// Creates a <see cref="TreeList"/>
		/// </summary>
		/// <example>
		/// <code lang="CS">
		/// @(Html.Kendo().TreeList()
		///             .Name("TreeList")
		/// )
		/// </code>
		/// </example>
		public virtual TreeListBuilder<T> TreeList<T>() where T : class
		{
			return new TreeListBuilder<T>(new TreeList<T>(HtmlHelper.ViewContext));
		}
	}
}