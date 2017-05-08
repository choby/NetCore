using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ProgressBar component
    /// </summary>
    public partial class ProgressBar : WidgetBase
        
    {
        public ProgressBar(ViewContext viewContext) : base(viewContext)
        {
			Enable = true;
			Reverse = false;
			ShowStatus = true;

			Animation = new ProgressBarAnimationSettings();
		}

		/// <summary>
		/// Gets or sets the current value of the ProgressBar 
		/// </summary>
		public object Value { get; set; }

		protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

			if (Animation.Enable == false)
			{
				settings["animation"] = false;
			}

			if (Value != null)
			{
				settings["value"] = Value;
			}

            writer.Write(Initializer.Initialize(Selector, "ProgressBar", settings));
        }
    }
}

