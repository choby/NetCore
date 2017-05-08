using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DateTimePicker component
    /// </summary>
    public partial class DateTimePicker : WidgetBase, IInputComponent<DateTime>
    {
        public DateTimePicker(ViewContext viewContext) : base(viewContext)
        {
            Enabled = true;
            Value = null;
        }

		public PopupAnimation Animation { get; } = new PopupAnimation();

		public CultureInfo CultureInfo
        {
            get
            {
                CultureInfo info = null;
                if (Culture.HasValue())
                {
                    info = new CultureInfo(Culture);
                }
                else
                {
                    info = CultureInfo.CurrentCulture;
                }

                return info;
            }
        }

        public IEnumerable<string> DisableDates { get; set; } = new string[] { };

        public ClientHandlerDescriptor DisableDatesHandler { get; set; }

        public bool Enabled
        {
            get;
            set;
        }
		public bool EnableFooter
		{
			get;
			set;
		} = true;

		public string FooterId
		{
			get;
			set;
		}

		protected override void WriteHtml(TextWriter writer)
        {
            var explorer = ExpressionMetadataProvider.FromStringExpression(Name, HtmlHelper.ViewData, HtmlHelper.MetadataProvider);
            var tag = Generator.GenerateDateTimeInput(ViewContext, explorer, Id, Name, Value, Format, HtmlAttributes);

            if (!Enabled)
            {
                tag.MergeAttribute("disabled", "disabled");
            }

            tag.TagRenderMode = TagRenderMode.SelfClosing;
            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

			var idPrefix = "#";
			if (IsInClientTemplate)
			{
				idPrefix = "\\" + idPrefix;
			}

			var animation = Animation.ToJson();
			if (animation.Any())
			{
				settings["animation"] = animation["animation"];
			}

            if (DisableDatesHandler?.HasValue() == true)
            {
                settings["disableDates"] = DisableDatesHandler;

            }
            else if (DisableDates.Any())
            {
                settings["disableDates"] = DisableDates;
            }

			if (EnableFooter)
			{
				if (FooterId.HasValue())
				{
					settings["footer"] = new ClientHandlerDescriptor { HandlerName = string.Format("jQuery('{0}{1}').html()", idPrefix, FooterId) };
				}
				else if (Footer.HasValue())
				{
					settings["footer"] = Footer;
				}
			}
			else
			{
				settings["footer"] = EnableFooter;
			}
			
			var month = MonthTemplate.Serialize();
			if (month.Any())
			{
				settings["month"] = month;
			}

			writer.Write(Initializer.Initialize(Selector, "DateTimePicker", settings));
        }
    }
}

