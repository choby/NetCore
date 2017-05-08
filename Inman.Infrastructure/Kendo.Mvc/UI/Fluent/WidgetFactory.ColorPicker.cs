namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		public virtual ColorPickerBuilder ColorPicker()
		{
			return new ColorPickerBuilder(new ColorPicker(HtmlHelper.ViewContext));
		}
	}
}