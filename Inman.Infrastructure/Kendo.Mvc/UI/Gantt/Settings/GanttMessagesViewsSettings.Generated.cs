using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttMessagesViewsSettings class
    /// </summary>
    public partial class GanttMessagesViewsSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public string Day { get; set; }

        public string End { get; set; }

        public string Month { get; set; }

        public string Start { get; set; }

        public string Week { get; set; }

        public string Year { get; set; }


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Day?.HasValue() == true)
            {
                settings["day"] = Day;
            }

            if (End?.HasValue() == true)
            {
                settings["end"] = End;
            }

            if (Month?.HasValue() == true)
            {
                settings["month"] = Month;
            }

            if (Start?.HasValue() == true)
            {
                settings["start"] = Start;
            }

            if (Week?.HasValue() == true)
            {
                settings["week"] = Week;
            }

            if (Year?.HasValue() == true)
            {
                settings["year"] = Year;
            }

            return settings;
        }
    }
}
