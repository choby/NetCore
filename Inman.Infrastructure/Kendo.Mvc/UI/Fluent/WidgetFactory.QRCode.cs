namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual QRCodeBuilder QRCode()
        {
            return new QRCodeBuilder(new QRCode(HtmlHelper.ViewContext));
        }
    }
}