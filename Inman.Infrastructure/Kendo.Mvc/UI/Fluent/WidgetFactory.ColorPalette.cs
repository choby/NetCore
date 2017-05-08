namespace Kendo.Mvc.UI.Fluent
{
	public partial class WidgetFactory<TModel>
	{
		public virtual ColorPaletteBuilder ColorPalette()
		{
			return new ColorPaletteBuilder(new ColorPalette(HtmlHelper.ViewContext));
		}
	}
}