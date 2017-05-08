namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual BarcodeBuilder Barcode()
        {
            return new BarcodeBuilder(new Barcode(HtmlHelper.ViewContext));
        }
    }
}