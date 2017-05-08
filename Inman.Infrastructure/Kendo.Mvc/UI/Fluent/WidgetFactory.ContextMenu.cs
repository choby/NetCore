namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual ContextMenuBuilder ContextMenu()
        {
            return new ContextMenuBuilder(new ContextMenu(HtmlHelper.ViewContext));
        }
    }
}