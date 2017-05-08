namespace Kendo.Mvc.UI
{    
    using Kendo.Mvc.Resources;    

    public class GridToolBarExcelCommand : GridActionCommandBase
    {    
        public GridToolBarExcelCommand()
        {
            Text = Messages.Grid_Excel;
        }

		public override string Name
		{
			get
			{
				return "excel";
			}			
		}
	}
}
