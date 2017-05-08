namespace Kendo.Mvc.UI
{
	using System.Collections.Generic;
	using Kendo.Mvc.Extensions;	

	abstract public class GridCustomCommandBase : GridActionCommandBase
	{
		protected string CssClass()
		{
			var classes = new List<string>();

			if (Name.HasValue())
			{
				classes.Add("k-grid-" + Name);
			}

			return string.Join(" ", classes.ToArray());
		}

		public override string Name { get; set; }
	}
}
