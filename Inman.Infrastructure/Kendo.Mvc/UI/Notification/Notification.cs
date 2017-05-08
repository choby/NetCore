using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Notification component
    /// </summary>
    public partial class Notification : WidgetBase
        
    {
        public Notification(ViewContext viewContext) : base(viewContext)
        {
        }

		public IList<NotificationTemplateSettings> Templates { get; } = new List<NotificationTemplateSettings>();

		public PopupAnimation Animation { get; } = new PopupAnimation();

		public string Tag { get; set; } = "span";

		protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag(Tag, ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

			var animation = Animation.ToJson();

			if (animation.Any())
			{
				if (animation["animation"] is bool)
				{
					settings["animation"] = false;
				}
				else
				{
					settings["animation"] = animation["animation"];
				}
			}

			if (Templates.Any())
			{
				settings["templates"] = Templates.Select(t => t.Serialize());
			}

			writer.Write(Initializer.Initialize(Selector, "Notification", settings));
        }
    }
}

