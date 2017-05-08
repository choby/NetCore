namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		public virtual ProgressBarBuilder ProgressBar()
		{
			return new ProgressBarBuilder(new ProgressBar(HtmlHelper.ViewContext));
		}
	}
}