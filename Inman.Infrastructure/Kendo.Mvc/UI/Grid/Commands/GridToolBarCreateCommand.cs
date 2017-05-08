namespace Kendo.Mvc.UI
{    
    using Kendo.Mvc.Resources;

    public class GridToolBarCreateCommand : GridActionCommandBase
    {
        public GridToolBarCreateCommand()
        {
            Text = Messages.Grid_Create;
        }

		public override string Name
		{
			get
			{
				return "create";
			}			
		}
	}
}
