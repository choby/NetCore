using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace Kendo.Mvc.Extensions
{
    public static class InputComponentExtensions
    {
        public static T? GetValue<T>(this IInputComponent<T> instance, Func<object, T?> converter) where T : struct
        {
            T? value = null;

            object valueFromViewData = instance.ViewContext.ViewData.Eval(instance.Name);

            if (instance.Value != null)
            {
                value = instance.Value;
            }
            else if (valueFromViewData != null)
            {
                value = converter(valueFromViewData);
            }

            instance.Value = value;

            return value;
        }

        public static string GetAttemptedValue<T>(this IInputComponent<T> instance) where T : struct
        {
            return (string) instance.GetModelStateValue(instance.Name, typeof(string));
        }

        internal static object GetModelStateValue<T>(this IInputComponent<T> instance, string key, Type destinationType) where T : struct
        {
            ModelStateEntry modelState;
            if (instance.ViewContext.ViewData.ModelState.TryGetValue(key, out modelState) && modelState.RawValue != null)
            {
                return Convert.ChangeType(modelState.RawValue, destinationType);
            }

            return null;
        }
    }
}
