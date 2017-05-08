using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DialogAction class
    /// </summary>
    public partial class DialogAction 
    {
        public string Text { get; set; }

        public ClientHandlerDescriptor Action { get; set; }

        public bool? Primary { get; set; }


        public Dialog Dialog { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Action?.HasValue() == true)
            {
                settings["action"] = Action;
            }

            if (Primary.HasValue)
            {
                settings["primary"] = Primary;
            }

            return settings;
        }
    }
}
