namespace Kendo.Mvc.UI
{
	using System.Collections.Generic;
	using System.Linq;
	using Kendo.Mvc.Extensions;
	using Kendo.Mvc.Resources;

	public class GridToolBarSaveCommand : GridActionCommandBase
    {
        public GridToolBarSaveCommand()
        {
            CancelText = Messages.Grid_CancelChanges;
            SaveText = Messages.Grid_SaveChanges;
        }

		public override string Name
		{
			get
			{
				return "save";
			}			
		}

		public override string Text
		{
			get
			{
				return SaveText;
			}
			set
			{
				SaveText = value;
			}
		}

		public string SaveText
        {
            get;
            set;
        }

        public string CancelText
        {
            get;
            set;
        }      
    }

	public class GridToolBarCancelCommand : GridActionCommandBase
	{
		private GridToolBarSaveCommand parent;

		public GridToolBarCancelCommand(GridToolBarSaveCommand parent)
		{
			this.parent = parent;

			HtmlAttributes = parent.HtmlAttributes;
        }

		public override string Text
		{
			get
			{
				return parent.CancelText;
			}
			set
			{
				parent.CancelText = value;
			}
		}

		public override string Name
		{
			get
			{
				return "cancel";
			}
		}

		public override IDictionary<string, object> Serialize()
		{
			var command = new Dictionary<string, object>();

			command
				.Add("attr", HtmlAttributes.ToAttributeString(), HtmlAttributes.Any)
				.Add("text", Text, (System.Func<bool>)Text.HasValue)
				.Add("name", Name);

			return command;
		}
	}
}
