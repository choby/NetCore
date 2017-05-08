using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridGroupableSettings class
    /// </summary>
    public partial class GridGroupableSettings<T> 
    {
		public GridGroupableMessages Messages { get; } = new GridGroupableMessages();

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();
			
			var messages = Messages.Serialize();
			if (messages.Any() && Enabled.GetValueOrDefault(false))
			{
				settings["messages"] = messages;
			}

			return settings;
        }
    }
}
