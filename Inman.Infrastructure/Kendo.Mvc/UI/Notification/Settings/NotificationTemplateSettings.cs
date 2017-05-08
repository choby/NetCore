using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
	public class NotificationTemplateSettings
    {
        public string Type { get; set; }
        public string ClientTemplateID { get; set; }
        public string ClientTemplate { get; set; }

        internal IDictionary<string, object> Serialize()
        {
            if (string.IsNullOrEmpty(Type))
            {
                throw new InvalidOperationException("Template Type cannot be null or an empty string.");
            }

			return new Dictionary<string, object>
			{
				["type"] = Type,
				["templateId"] = ClientTemplateID ?? "",
				["template"] = ClientTemplate ?? ""
			};			
        }
    }
}