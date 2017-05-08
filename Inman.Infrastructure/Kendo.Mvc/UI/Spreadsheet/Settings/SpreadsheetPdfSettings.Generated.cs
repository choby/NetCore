using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetPdfSettings class
    /// </summary>
    public partial class SpreadsheetPdfSettings 
    {
        public string Area { get; set; }

        public string Author { get; set; }

        public string Creator { get; set; }

        public DateTime? Date { get; set; }

        public string FileName { get; set; }

        public bool? FitWidth { get; set; }

        public bool? ForceProxy { get; set; }

        public bool? Guidelines { get; set; }

        public bool? HCenter { get; set; }

        public string Keywords { get; set; }

        public bool? Landscape { get; set; }

        public SpreadsheetPdfMarginSettings Margin { get; } = new SpreadsheetPdfMarginSettings();

        public string PaperSize { get; set; }

        public string ProxyURL { get; set; }

        public string ProxyTarget { get; set; }

        public string Subject { get; set; }

        public string Title { get; set; }

        public bool? VCenter { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Area?.HasValue() == true)
            {
                settings["area"] = Area;
            }

            if (Author?.HasValue() == true)
            {
                settings["author"] = Author;
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

            if (FitWidth.HasValue)
            {
                settings["fitWidth"] = FitWidth;
            }

            if (ForceProxy.HasValue)
            {
                settings["forceProxy"] = ForceProxy;
            }

            if (Guidelines.HasValue)
            {
                settings["guidelines"] = Guidelines;
            }

            if (HCenter.HasValue)
            {
                settings["hCenter"] = HCenter;
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

            if (VCenter.HasValue)
            {
                settings["vCenter"] = VCenter;
            }

            return settings;
        }
    }
}
