namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual SortableBuilder Sortable()
        {
            return new SortableBuilder(new Sortable(HtmlHelper.ViewContext));
        }
    }
}