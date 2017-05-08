using Kendo.Mvc.Extensions;
using System;
using System.IO;
using System.Linq;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Calendar component
    /// </summary>
    public partial class Calendar : WidgetBase
    {
        public Calendar(ViewContext viewContext) : base(viewContext)
        {
        }

        public string FooterId
        {
            get;
            set;
        }

        public bool EnableFooter { get; set; } = true;

        public CalendarSelectionSettings SelectionSettings { get; } = new CalendarSelectionSettings();

        public IEnumerable<string> DisableDates { get; set; } = new string[] { };

        public ClientHandlerDescriptor DisableDatesHandler { get; set; }

        protected override void WriteHtml(TextWriter writer)
        {
            HtmlAttributes.AppendInValue("class", " ", "k-widget k-calendar");

            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void VerifySettings()
        {
            base.VerifySettings();

            if (Min > Max)
            {
                throw new ArgumentException(Exceptions.MinPropertyMustBeLessThenMaxProperty.FormatWith("Min", "Max"));
            }
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            var idPrefix = "#";
            if (IsInClientTemplate)
            {
                idPrefix = "\\" + idPrefix;
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

            if (SelectionSettings.Dates.Any())
            {
                settings["dates"] = SelectionSettings.Dates;
            }

            var url = SelectionSettings.GenerateUrl(ViewContext, UrlGenerator);

            if (url.HasValue())
            {
                settings["url"] = url;
            }

            if (DisableDatesHandler?.HasValue() == true)
            {
                settings["disableDates"] = DisableDatesHandler;

            }
            else if (DisableDates.Any())
            {
                settings["disableDates"] = DisableDates;
            }

            writer.Write(Initializer.Initialize(Selector, "Calendar", settings));
        }
    }
}