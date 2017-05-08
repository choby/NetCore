namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		public virtual FlatColorPickerBuilder FlatColorPicker()
		{
			return new FlatColorPickerBuilder(new FlatColorPicker(HtmlHelper.ViewContext));
		}
	}
}