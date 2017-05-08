using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeViewMessagesSettings class
    /// </summary>
    public partial class TreeViewMessagesSettings 
    {
        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();
            
            return settings;
        }
    }
}
