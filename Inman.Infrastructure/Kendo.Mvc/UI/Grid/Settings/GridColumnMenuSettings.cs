using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridColumnMenuSettings class
    /// </summary>
    public partial class GridColumnMenuSettings<T> 
    {
		public GridColumnMenuMessages Messages { get; } = new GridColumnMenuMessages();
        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

			var messages = Messages.Serialize();
			if (messages.Any() && Enabled == true)
			{
				settings["messages"] = messages;
			}

			return settings;
        }
    }
}
