namespace Kendo.Mvc.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Kendo.Mvc.Resources;    
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public static class ModelStateExtensions
    {
        public static object ToDataSourceResult(this ModelStateDictionary modelState)
        {
            if (!modelState.IsValid)
            {
                return new { Errors = modelState.SerializeErrors() };
            }
            return new object();
        }

        public static object SerializeErrors(this ModelStateDictionary modelState)
        {
            return modelState.Where(entry => entry.Value.Errors.Any())
                             .ToDictionary(entry => entry.Key, entry => SerializeModelState(entry.Value));
        }

        private static Dictionary<string, object> SerializeModelState(ModelStateEntry modelState)
        {
            var result = new Dictionary<string, object>();
            result["errors"] = modelState.Errors
                                         .Select(error => GetErrorMessage(error, modelState))
                                         .ToArray();
            return result;
        }

        private static string GetErrorMessage(ModelError error, ModelStateEntry modelState)
        {
            if (!error.ErrorMessage.HasValue())
            {
                if (modelState.RawValue == null)
                {
                    return error.ErrorMessage;
                }

                return Exceptions.ValueNotValidForProperty.FormatWith(modelState.AttemptedValue);
            }

            return error.ErrorMessage;
        }
    }
}
