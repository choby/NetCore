using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListMessagesCommandsSettings class
    /// </summary>
    public partial class TreeListMessagesCommandsSettings<T> where T : class 
    {
        public string Canceledit { get; set; }

        public string Create { get; set; }

        public string Createchild { get; set; }

        public string Destroy { get; set; }

        public string Edit { get; set; }

        public string Excel { get; set; }

        public string Pdf { get; set; }

        public string Update { get; set; }


        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Canceledit?.HasValue() == true)
            {
                settings["canceledit"] = Canceledit;
            }

            if (Create?.HasValue() == true)
            {
                settings["create"] = Create;
            }

            if (Createchild?.HasValue() == true)
            {
                settings["createchild"] = Createchild;
            }

            if (Destroy?.HasValue() == true)
            {
                settings["destroy"] = Destroy;
            }

            if (Edit?.HasValue() == true)
            {
                settings["edit"] = Edit;
            }

            if (Excel?.HasValue() == true)
            {
                settings["excel"] = Excel;
            }

            if (Pdf?.HasValue() == true)
            {
                settings["pdf"] = Pdf;
            }

            if (Update?.HasValue() == true)
            {
                settings["update"] = Update;
            }

            return settings;
        }
    }
}
