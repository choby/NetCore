using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Threading;
using System;

namespace Kendo.Mvc.Extensions
{
    public static class WidgetExtensions
    {
        public static string GetValue<T>(this IWidget instance, T value)
        {
            return instance.GetValue<T>(instance.Name, value);
        }

        public static string GetValue<T>(this IWidget instance, string name, T value, string format = "{0}")
        {
            ModelStateEntry state;
            string formattedValue = string.Empty;
            ViewDataDictionary viewData = instance.ViewContext.ViewData;

            object valueFromViewData = name.HasValue() ? viewData.Eval(name) : null;

            if (name.HasValue() && viewData.ModelState.TryGetValue(name, out state) && (state.RawValue != null))
            {
                formattedValue = state.AttemptedValue;
                if (viewData.ModelState.GetFieldValidationState(name) == ModelValidationState.Valid)
                {
                    formattedValue = format.FormatWith(Convert.ChangeType(state.RawValue, typeof(T)));
                }
            }
            else if (value != null)
            {
                formattedValue = format.FormatWith(value);
            }
            else if (valueFromViewData != null && valueFromViewData.GetType().IsPredefinedType())
            {
                formattedValue = format.FormatWith(valueFromViewData);
            }

            return formattedValue;
        }
    }
}