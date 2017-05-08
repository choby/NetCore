using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GridPdfSettings class
    /// </summary>
    public partial class GridPdfSettings<T> where T : class 
    {
        public bool? AllPages { get; set; }

        public string Author { get; set; }

        public bool? AvoidLinks { get; set; }

        public string Creator { get; set; }

        public DateTime? Date { get; set; }

        public string FileName { get; set; }

        public bool? ForceProxy { get; set; }

        public string Keywords { get; set; }

        public bool? Landscape { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public bool? RepeatHeaders { get; set; }

        public double? Scale { get; set; }

        public string ProxyURL { get; set; }

        public string ProxyTarget { get; set; }

        public string Subject { get; set; }

        public string Title { get; set; }


        public Grid<T> Grid { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AllPages.HasValue)
            {
                settings["allPages"] = AllPages;
            }

            if (Author?.HasValue() == true)
            {
                settings["author"] = Author;
            }

            if (AvoidLinks.HasValue)
            {
                settings["avoidLinks"] = AvoidLinks;
            }

            if (Creator?.HasValue() == true)
            {
                settings["creator"] = Creator;
            }

            if (Date.HasValue)
            {
                settings["date"] = Date;
            }

            if (FileName?.HasValue() == true)
            {
                settings["fileName"] = FileName;
            }

            if (ForceProxy.HasValue)
            {
                settings["forceProxy"] = ForceProxy;
            }

            if (Keywords?.HasValue() == true)
            {
                settings["keywords"] = Keywords;
            }

            if (Landscape.HasValue)
            {
                settings["landscape"] = Landscape;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Grid.IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (RepeatHeaders.HasValue)
            {
                settings["repeatHeaders"] = RepeatHeaders;
            }

            if (Scale.HasValue)
            {
                settings["scale"] = Scale;
            }

            if (ProxyURL?.HasValue() == true)
            {
                settings["proxyURL"] = ProxyURL;
            }

            if (ProxyTarget?.HasValue() == true)
            {
                settings["proxyTarget"] = ProxyTarget;
            }

            if (Subject?.HasValue() == true)
            {
                settings["subject"] = Subject;
            }

            if (Title?.HasValue() == true)
            {
                settings["title"] = Title;
            }

            return settings;
        }
    }
}
