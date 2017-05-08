namespace Kendo.Mvc.UI
{
	using System;
	using System.Collections.Generic;
	using Microsoft.AspNetCore.Mvc.Rendering;

	public interface IGridForeignKeyColumn : IGridBoundColumn
    {
        SelectList Data
        {
            get;
            set;
        }

        Action<IDictionary<string, object>, object> SerializeSelectList
        {
            get;
        }
    }
}
