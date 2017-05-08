namespace Kendo.Mvc.UI
{
	using Kendo.Mvc.Resources;

	public class GridDestroyActionCommand : GridActionCommandBase
    {
        public GridDestroyActionCommand()
        {
            Text = Messages.Grid_Destroy;
        }

        public override string Name
        {
            get { return "destroy"; }
        }		
    }
}
