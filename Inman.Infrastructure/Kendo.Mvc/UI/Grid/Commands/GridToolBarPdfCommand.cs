namespace Kendo.Mvc.UI
{    
    using Kendo.Mvc.Resources;

    public class GridToolBarPdfCommand : GridActionCommandBase
    {
        public GridToolBarPdfCommand()
        {
            Text = Messages.Grid_Pdf;
        }

		public override string Name
		{
			get
			{
				return "pdf";
			}
		}
	}
}
