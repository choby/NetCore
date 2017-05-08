using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeViewCheckboxesSettings class
    /// </summary>
    public partial class TreeViewCheckboxesSettings 
    {
        public const string DefaultTemplate = "<input type='checkbox' name='#= treeview.checkboxes.name #' #= item.checked ? 'checked' : '' # value='#= item.id #' />";

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();
            
            return settings;
        }
    }
}
