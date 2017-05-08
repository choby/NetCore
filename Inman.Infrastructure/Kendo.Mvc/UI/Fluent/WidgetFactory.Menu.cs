namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual MenuBuilder Menu()
        {
            return new MenuBuilder(new Menu(HtmlHelper.ViewContext));
        }
    }
}