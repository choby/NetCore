using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeListFilterableMessagesSettings class
    /// </summary>
    public partial class TreeListFilterableMessagesSettings<T> where T : class 
    {
        public string And { get; set; }

        public string Clear { get; set; }

        public string Filter { get; set; }

        public string Info { get; set; }

        public string IsFalse { get; set; }

        public string IsTrue { get; set; }

        public string Or { get; set; }

        public string SelectValue { get; set; }

        public string Cancel { get; set; }

        public string Operator { get; set; }


        public TreeList<T> TreeList { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (And?.HasValue() == true)
            {
                settings["and"] = And;
            }

            if (Clear?.HasValue() == true)
            {
                settings["clear"] = Clear;
            }

            if (Filter?.HasValue() == true)
            {
                settings["filter"] = Filter;
            }

            if (Info?.HasValue() == true)
            {
                settings["info"] = Info;
            }

            if (IsFalse?.HasValue() == true)
            {
                settings["isFalse"] = IsFalse;
            }

            if (IsTrue?.HasValue() == true)
            {
                settings["isTrue"] = IsTrue;
            }

            if (Or?.HasValue() == true)
            {
                settings["or"] = Or;
            }

            if (SelectValue?.HasValue() == true)
            {
                settings["selectValue"] = SelectValue;
            }

            if (Cancel?.HasValue() == true)
            {
                settings["cancel"] = Cancel;
            }

            if (Operator?.HasValue() == true)
            {
                settings["operator"] = Operator;
            }

            return settings;
        }
    }
}
