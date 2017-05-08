using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttViewRangeSettings class
    /// </summary>
    public partial class GanttViewRangeSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            // Do manual serialization here

            return settings;
        }
    }
}
