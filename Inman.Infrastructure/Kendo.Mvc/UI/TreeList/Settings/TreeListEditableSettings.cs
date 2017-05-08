using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListEditableSettings class
    /// </summary>
    public partial class TreeListEditableSettings<T> 
    {
		public TreeListEditableSettings()
		{
			DefaultDataItem = CreateDefaultItem;
        }

		public Func<T> DefaultDataItem { get; set; }

		public string EditorHtml { get; set; }

		public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

			SerializeEditTemplate(settings);

			return settings;
        }

		private T CreateDefaultItem()
		{
			return Activator.CreateInstance<T>();
		}

		private void SerializeEditTemplate(IDictionary<string, object> options)
		{
			if (Enabled == true && EditorHtml.HasValue())
			{
				var html = EditorHtml.Trim()
								.EscapeHtmlEntities()
								.Replace("\r\n", string.Empty)
								.Replace("jQuery(\"#", "jQuery(\"\\#");

				options["template"] = html;
			}
		}
	}
}
