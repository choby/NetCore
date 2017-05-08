namespace Kendo.Mvc.UI
{
	using System.Collections.Generic;
	using System.Linq;
	using Kendo.Mvc.Extensions;

	public class GridActionColumn<T> : GridColumnBase<T>, IGridActionColumn where T : class
    {
        public GridActionColumn(Grid<T> grid)
            : base(grid)
        {
            Commands = new List<IGridActionCommand>();
        }

        public IList<IGridActionCommand> Commands
        {
            get;
            private set;
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
            base.Serialize(json);

            var commands = new List<IDictionary<string,object>>();
            
            Commands.Each(command =>
            {
                commands.Add(command.Serialize());
            });
        
            if (commands.Any())
            {
                json["command"] = commands;
            }
        }
    }
}