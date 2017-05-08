namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual LinearGaugeBuilder LinearGauge()
        {
            return new LinearGaugeBuilder(new LinearGauge(HtmlHelper.ViewContext));
        }
    }
}