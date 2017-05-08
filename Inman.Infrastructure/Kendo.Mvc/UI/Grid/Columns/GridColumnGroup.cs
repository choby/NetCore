using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
	public interface IGridColumnGroup : IGridColumn
    {
        IEnumerable<IGridColumn> Columns { get; } 
    }

	public class GridColumnGroup<T> : GridColumnBase<T>, IGridColumnGroup, IGridColumnContainer<T> where T : class
	{
		public GridColumnGroup(Grid<T> grid) : base(grid)
		{
			Columns = new List<GridColumnBase<T>>();
		}

		protected override void Serialize(IDictionary<string, object> json)
		{
			base.Serialize(json);

			var columns = VisibleColumns.OfType<JsonObject>().Select(c => c.ToJson());

			if (columns.Any())
			{
				json["columns"] = columns;
			}
		}

		public override bool Visible
		{
			get
			{
				return base.Visible && Columns.FlatColumns().Where(c => c.Visible).Any();
			}
			set
			{
				base.Visible = value;
			}
		}

		/// <summary>
		/// Gets the columns in the group
		/// </summary>
		public IList<GridColumnBase<T>> Columns
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the columns in the group
		/// </summary>
		public IEnumerable<IGridColumn> VisibleColumns
		{
			get
			{
				return Columns.Where(c => c.Visible);
			}
		}


		IEnumerable<IGridColumn> IGridColumnGroup.Columns
		{
			get
			{
				return Columns.Cast<IGridColumn>();
			}
		}
	}
}
