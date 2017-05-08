namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		public virtual ButtonBuilder Button()
		{
			return new ButtonBuilder(new Button(HtmlHelper.ViewContext));
		}
	}
}