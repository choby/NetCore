namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual RadialGaugeBuilder RadialGauge()
        {
            return new RadialGaugeBuilder(new RadialGauge(HtmlHelper.ViewContext));
        }
    }
}