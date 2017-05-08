namespace Kendo.Mvc.UI.Fluent
{
	using System;
	using Kendo.Mvc.UI;	

	public class GridCustomActionCommandBuilder<T> : GridActionCommandBuilderBase<GridCustomActionCommand, GridCustomActionCommandBuilder<T>>
        where T : class
    {
        public GridCustomActionCommandBuilder(GridCustomActionCommand command) : base(command)
        {
        }

        public GridCustomActionCommandBuilder<T> Click(Func<object, object> handler)
        {            
            Command.Click.TemplateDelegate = handler;

            return this;
        }

        public GridCustomActionCommandBuilder<T> Click(string handler)
        {
            Command.Click.HandlerName = handler;

            return this;
        }

    }
}