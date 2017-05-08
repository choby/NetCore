using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListSelectableSettings class
    /// </summary>
    public partial class TreeListSelectableSettings<T> 
    {
        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            if (Enabled == true)
            {
                if (Mode.HasValue || Type.HasValue)
                {
                    var selectable = "row";

                    if (Mode.HasValue)
                    {
                        selectable = Mode.Value.Serialize();
                    }

                    if (Type.HasValue)
                    {
                        selectable += ", " + Type.Value.Serialize();
                    }

                    settings["selectable"] = selectable;
                }

                if (!Mode.HasValue && !Type.HasValue)
                {
                    settings["selectable"] = true;
                }
            }

            return settings;
        }
    }
}
