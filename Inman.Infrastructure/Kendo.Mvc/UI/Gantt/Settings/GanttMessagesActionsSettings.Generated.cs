using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttMessagesActionsSettings class
    /// </summary>
    public partial class GanttMessagesActionsSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public string AddChild { get; set; }

        public string Append { get; set; }

        public string InsertAfter { get; set; }

        public string InsertBefore { get; set; }

        public string Pdf { get; set; }


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AddChild?.HasValue() == true)
            {
                settings["addChild"] = AddChild;
            }

            if (Append?.HasValue() == true)
            {
                settings["append"] = Append;
            }

            if (InsertAfter?.HasValue() == true)
            {
                settings["insertAfter"] = InsertAfter;
            }

            if (InsertBefore?.HasValue() == true)
            {
                settings["insertBefore"] = InsertBefore;
            }

            if (Pdf?.HasValue() == true)
            {
                settings["pdf"] = Pdf;
            }

            return settings;
        }
    }
}
