namespace Kendo.Mvc.UI
{
	public class GridTemplateColumn<T> : GridColumnBase<T> where T : class
	{
		public GridTemplateColumn(Grid<T> grid) : base(grid)
		{
		}
	}
}