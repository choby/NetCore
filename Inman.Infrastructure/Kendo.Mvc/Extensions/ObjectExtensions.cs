using System;
using System.Collections.Generic;
using System.Reflection;

namespace Kendo.Mvc.Extensions
{
    internal static class ObjectExtensions
    {
        public static IDictionary<string, object> ToDictionary(this object @object)
        {
            var dictionary = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);
            if (@object != null)
            {
                foreach (var property in @object.GetType().GetProperties())
                {
                    dictionary.Add(property.Name.Replace("_", "-"), property.GetValue(@object));
                }
            }
            return dictionary;
        }
    }
}
