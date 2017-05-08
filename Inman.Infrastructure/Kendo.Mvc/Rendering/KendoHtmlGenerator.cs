using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Kendo.Mvc.Rendering
{
    public class KendoHtmlGenerator : IKendoHtmlGenerator
    {
        private readonly IClientModelValidatorProvider _clientModelValidatorProvider;
        private readonly ClientValidatorCache _clientValidatorCache;
        private readonly IModelMetadataProvider _metadataProvider;
        private readonly IServiceProvider _requestServices;

        /// <summary>
        /// Initializes a new instance of the <see cref="KendoHtmlGenerator"/> class.
        /// </summary>
        public KendoHtmlGenerator(
            IModelMetadataProvider metadataProvider,
            IServiceProvider requestServices,
            IOptions<MvcViewOptions> optionsAccessor,
            ClientValidatorCache clientValidatorCache)
        {
            var clientValidatorProviders = optionsAccessor.Value.ClientModelValidatorProviders;
            _clientModelValidatorProvider = new CompositeClientModelValidatorProvider(clientValidatorProviders);
            _clientValidatorCache = clientValidatorCache;

            _metadataProvider = metadataProvider;
            _requestServices = requestServices;

            IdAttributeDotReplacement = optionsAccessor.Value.HtmlHelperOptions.IdAttributeDotReplacement;
        }

        public string IdAttributeDotReplacement { get; }

        public TagBuilder GenerateInput(
		   ViewContext viewContext,
           ModelExplorer modelExplorer,
           string id,
		   string name,
		   object value,
		   string format,
		   string type,
		   IDictionary<string, object> htmlAttributes)
		{
			var tagBuilder = GenerateTag("input", viewContext, id, name, htmlAttributes);
            tagBuilder.TagRenderMode = TagRenderMode.SelfClosing;

            if (!string.IsNullOrEmpty(type))
            {
                tagBuilder.MergeAttribute("type", type);
            }

            modelExplorer = modelExplorer ??
                ExpressionMetadataProvider.FromStringExpression(name, viewContext.ViewData, _metadataProvider);

            var fullName = tagBuilder.Attributes["name"];
			var valueParameter = FormatValue(value, format);
			var useViewData = modelExplorer.Metadata == null && value == null;
			var attributeValue = (string)GetModelStateValue(viewContext, fullName, typeof(string));
			if (attributeValue == null)
			{
				attributeValue = useViewData ? EvalString(viewContext, fullName, format) : valueParameter;
			}

			tagBuilder.MergeAttribute("value", attributeValue, true);

            // If there are any errors for a named field, we add the CSS attribute.
            ModelStateEntry modelState;
			if (viewContext.ViewData.ModelState.TryGetValue(fullName, out modelState) && modelState.Errors.Count > 0)
			{
				tagBuilder.AddCssClass(HtmlHelper.ValidationInputCssClassName);
			}

            AddValidationAttributes(viewContext, tagBuilder, modelExplorer, name);

            return tagBuilder;
		}

        private TagBuilder GenerateSelect(
            ViewContext viewContext,
            ModelExplorer modelExplorer,
            string id,
            string name,
            string multiple,
            IDictionary<string, object> htmlAttributes)
        {
            var tagBuilder = GenerateTag("select", viewContext, id, name, htmlAttributes);
            tagBuilder.MergeAttribute("multiple", multiple);

            var fullName = tagBuilder.Attributes["name"];

            // If there are any errors for a named field, we add the CSS attribute.
            ModelStateEntry modelState;
            if (viewContext.ViewData.ModelState.TryGetValue(fullName, out modelState) && modelState.Errors.Count > 0)
            {
                tagBuilder.AddCssClass(HtmlHelper.ValidationInputCssClassName);
            }

            AddValidationAttributes(viewContext, tagBuilder, modelExplorer, name);

            return tagBuilder;
        }

        public virtual TagBuilder GenerateColorInput(
			ViewContext viewContext,
			ModelExplorer modelExplorer,
			string id,
			string name,
			object value,
			IDictionary<string, object> htmlAttributes)
		{
			return GenerateInput(viewContext, modelExplorer, id, name, value, null, "color", htmlAttributes);
		}

        public virtual TagBuilder GenerateRangeInput(
            ViewContext viewContext,
            ModelExplorer modelExplorer,
            string id,
            string name,
            object value,
            IDictionary<string, object> htmlAttributes)
        {
            return GenerateInput(viewContext, modelExplorer, id, name, value, null, "range", htmlAttributes);
        }

        public virtual TagBuilder GenerateDateInput(
            ViewContext viewContext,
            ModelExplorer modelExplorer,
            string id,
            string name,
            object value,
            string format,
            IDictionary<string, object> htmlAttributes)
        {
			return GenerateInput(viewContext, modelExplorer, id, name, value, format, "date", htmlAttributes);
        }

        public virtual TagBuilder GenerateDateTimeInput(
            ViewContext viewContext,
            ModelExplorer modelExplorer,
            string id,
            string name,
            object value,
            string format,
            IDictionary<string, object> htmlAttributes)
        {            
            return GenerateInput(viewContext, modelExplorer, id, name, value, format, "datetime", htmlAttributes);
		}

        public virtual TagBuilder GenerateTimeInput(
            ViewContext viewContext,
            ModelExplorer modelExplorer,
            string id,
            string name,
            object value,
            string format,
            IDictionary<string, object> htmlAttributes)
        {
            return GenerateInput(viewContext, modelExplorer, id, name, value, format, "time", htmlAttributes);
        }

        public virtual TagBuilder GenerateNumericInput(
			ViewContext viewContext,
			ModelExplorer modelExplorer,
			string id,
			string name,
			object value,
			string format,
			IDictionary<string, object> htmlAttributes)
		{			
			return GenerateInput(viewContext, modelExplorer, id, name, value, format, "number", htmlAttributes);
		}

        public virtual TagBuilder GenerateMultiSelect(
            ViewContext viewContext,
            ModelExplorer modelExplorer,
            string id,
            string name,
            IDictionary<string, object> htmlAttributes)
        {
            return GenerateSelect(viewContext, modelExplorer, id, name, "multiple", htmlAttributes);
        }

        public virtual TagBuilder GenerateTag(
            string tagName,            
            IDictionary<string, object> htmlAttributes)
        {            
            var tagBuilder = new TagBuilder(tagName);            
            tagBuilder.MergeAttributes(htmlAttributes, replaceExisting: true);
            return tagBuilder;
        }

        public virtual TagBuilder GenerateTag(
            string tagName,
            ViewContext viewContext,
            string id,
            string name,
            IDictionary<string, object> htmlAttributes)
        {
            var fullName = viewContext.GetFullHtmlFieldName(name);

            if (string.IsNullOrEmpty(fullName))
            {
                throw new InvalidOperationException(Resources.Exceptions.NameCannotBeBlank);
            }

            var tagBuilder = new TagBuilder(tagName);
            tagBuilder.MergeAttribute("id", id);
            tagBuilder.MergeAttribute("name", fullName);
            tagBuilder.MergeAttributes(htmlAttributes, replaceExisting: true);

            return tagBuilder;
        }

        /// <summary>
        /// Adds validation attributes to the <paramref name="tagBuilder" /> if client validation
        /// is enabled.
        /// </summary>
        /// <param name="viewContext">A <see cref="ViewContext"/> instance for the current scope.</param>
        /// <param name="tagBuilder">A <see cref="TagBuilder"/> instance.</param>
        /// <param name="modelExplorer">The <see cref="ModelExplorer"/> for the <paramref name="expression"/>.</param>
        /// <param name="expression">Expression name, relative to the current model.</param>
        protected virtual void AddValidationAttributes(
            ViewContext viewContext,
            TagBuilder tagBuilder,
            ModelExplorer modelExplorer,
            string expression)
        {
            // Only render attributes if client-side validation is enabled, and then only if we've
            // never rendered validation for a field with this name in this form.
            var formContext = viewContext.ClientValidationEnabled ? viewContext.FormContext : null;
            if (formContext == null)
            {
                return;
            }

            var fullName = GetFullHtmlFieldName(viewContext, expression);
            if (formContext.RenderedField(fullName))
            {
                return;
            }

            formContext.RenderedField(fullName, true);

            modelExplorer = modelExplorer ??
                ExpressionMetadataProvider.FromStringExpression(expression, viewContext.ViewData, _metadataProvider);

            var validators = _clientValidatorCache.GetValidators(modelExplorer.Metadata, _clientModelValidatorProvider);
            if (validators.Count > 0)
            {
                var validationContext = new ClientModelValidationContext(
                    viewContext,
                    modelExplorer.Metadata,
                    _metadataProvider,
                    tagBuilder.Attributes);

                for (var i = 0; i < validators.Count; i++)
                {
                    var validator = validators[i];
                    validator.AddValidation(validationContext);
                }
            }
        }

        internal static string GetFullHtmlFieldName(ViewContext viewContext, string expression)
        {
            var fullName = viewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(expression);
            return fullName;
        }

        private static object GetModelStateValue(ViewContext viewContext, string key, Type destinationType)
        {
            ModelStateEntry modelState;
            if (viewContext.ViewData.ModelState.TryGetValue(key, out modelState) && modelState.RawValue != null)
            {
                return Convert.ChangeType(modelState.RawValue, destinationType);
            }

            return null;
        }

        private static string EvalString(ViewContext viewContext, string key)
        {
            return Convert.ToString(viewContext.ViewData.Eval(key), CultureInfo.CurrentCulture);
        }

        private static string EvalString(ViewContext viewContext, string key, string format)
        {
            return Convert.ToString(viewContext.ViewData.Eval(key, format), CultureInfo.CurrentCulture);
        }

        private static string FormatValue(object value, string format)
        {
            return ViewDataDictionary.FormatValue(value, format);
        }

		public TagBuilder GenerateTextInput(
			ViewContext viewContext,
			ModelExplorer modelExplorer, 
			string id, 
			string name, 
			object value, 
			string format, 
			IDictionary<string, object> htmlAttributes)
		{
			return GenerateInput(viewContext, modelExplorer, id, name, value, format, "text", htmlAttributes);
		}

        private bool IsValidCharacter(char c)
        {
            if (c == '?' || c == '!' || c == '#' || c == '.' || c == '[' || c == ']')
            {
                return false;
            }

            return true;
        }

        private void ReplaceInvalidCharacters(string part, StringBuilder builder)
        {
            for (int i = 0; i < part.Length; i++)
            {
                char character = part[i];
                if (IsValidCharacter(character))
                {
                    builder.Append(character);
                }
                else
                {
                    builder.Append(IdAttributeDotReplacement);
                }
            }
        }

        public string SanitizeId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return string.Empty;
            }

            var builder = new StringBuilder(id.Length);
            int startSharpIndex = id.IndexOf("#");
            int endSharpIndex = id.LastIndexOf("#");

            if (endSharpIndex > startSharpIndex)
            {
                ReplaceInvalidCharacters(id.Substring(0, startSharpIndex), builder);
                builder.Append(id.Substring(startSharpIndex, endSharpIndex - startSharpIndex + 1));
                ReplaceInvalidCharacters(id.Substring(endSharpIndex + 1), builder);
            }
            else
            {
                ReplaceInvalidCharacters(id, builder);
            }

            return builder.ToString();
        }
    }
}
