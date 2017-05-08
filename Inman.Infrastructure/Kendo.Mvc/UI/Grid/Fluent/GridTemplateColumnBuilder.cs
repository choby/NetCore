namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring template columns
    /// </summary>
    public class GridTemplateColumnBuilder<T> : GridColumnBuilderBase<GridTemplateColumn<T>, GridTemplateColumnBuilder<T>>
        where T : class
    {
        public GridTemplateColumnBuilder(GridTemplateColumn<T> column) : base(column)
        {
        }
    }
}