namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		public virtual MapBuilder Map()
		{
			return new MapBuilder(new Map(HtmlHelper.ViewContext));
		}
	}
}