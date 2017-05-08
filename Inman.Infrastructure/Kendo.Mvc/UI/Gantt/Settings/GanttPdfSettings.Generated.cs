using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttPdfSettings class
    /// </summary>
    public partial class GanttPdfSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public string Author { get; set; }

        public bool? AvoidLinks { get; set; }

        public string Creator { get; set; }

        public DateTime? Date { get; set; }

        public string FileName { get; set; }

        public bool? ForceProxy { get; set; }

        public string Keywords { get; set; }

        public bool? Landscape { get; set; }

        public GanttPdfMarginSettings<TTaskModel, TDependenciesModel> Margin { get; } = new GanttPdfMarginSettings<TTaskModel, TDependenciesModel>();

        public string PaperSize { get; set; }

        public string ProxyURL { get; set; }

        public string ProxyTarget { get; set; }

        public string Subject { get; set; }

        public string Title { get; set; }


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

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

            var margin = Margin.Serialize();
            if (margin.Any())
            {
                settings["margin"] = margin;
            }

            if (PaperSize?.HasValue() == true)
            {
                settings["paperSize"] = PaperSize;
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
