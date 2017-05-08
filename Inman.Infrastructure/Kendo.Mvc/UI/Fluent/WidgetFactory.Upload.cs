namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
		public virtual UploadBuilder Upload()
		{
			return new UploadBuilder(new Upload(HtmlHelper.ViewContext));
		}
    }
}