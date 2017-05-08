using System.Collections.Generic;
using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI
{
    public class GridGroupableMessages
    {        
        public string Empty { get; set; } = Messages.Group_Empty;

        public IDictionary<string, object> Serialize()
        {
			var json = new Dictionary<string, object>();

            if (Empty != DefaultEmpty)
            {
                json["empty"] = Empty;
            }

			return json;
        }

        private const string DefaultEmpty = "Drag a column header and drop it here to group by that column";
    }
}
