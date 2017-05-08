namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;    
    using Kendo.Mvc.Resources;    
    using System.Linq;

    public class GridEditActionCommand : GridActionCommandBase
    {
        public GridEditActionCommand()
        {            
            UpdateText = Messages.Grid_Update;
            Text = Messages.Grid_Edit;
            CancelText = Messages.Grid_Cancel;
        }

        private const string DefaultUpdateText = "Update";
        private const string DefaultEditText = "Edit";
        private const string DefaultCancelText = "Cancel";

        public string UpdateText { get; set; }

        public string CancelText { get; set; }        

        public override string Name
        {
            get { return "edit"; }
        }

        public override IDictionary<string, object> Serialize()
        {
            var result = base.Serialize();

            var texts = new Dictionary<string, object>();

            texts.Add("cancel", CancelText, () => CancelText.HasValue() && CancelText != DefaultCancelText)
                .Add("update", UpdateText, () => UpdateText.HasValue() && UpdateText != DefaultUpdateText)
                .Add("edit", Text, () => Text.HasValue() && Text != DefaultEditText);

            if (texts.Any())
	        {
		        result["text"] = texts;
            }
            return result;
        }		
    }
}
