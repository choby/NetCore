using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using System.Text.RegularExpressions;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace Kendo.Mvc.TagHelpers
{
    public abstract class TagHelperBase : TagHelper
    {
        internal static readonly string DeferredScriptsKey = "$DeferredScriptsKey$";
        private static readonly Regex StringFormatExpression = new Regex(@"(?<=\{\d:)(.)*(?=\})", RegexOptions.Compiled);
        protected const string MinimumValidator = "min";
        protected const string MaximumValidator = "max";

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeNotBound]
        protected IKendoHtmlGenerator Generator { get; set; }

        [HtmlAttributeNotBound]
        public IJavaScriptInitializer Initializer { get; set; }

        public string Name { get; set; }

        [HtmlAttributeNotBound]
        public string Id { get; set; }

        public string Selector
        {
            get
            {
                return IdPrefix + Id;
            }
        }

        public string IdPrefix
        {
            get
            {
                return "#";
            }
        }
        public bool Deferred { get; set; }

        public TagHelperBase(IKendoHtmlGenerator generator)
        {
            Generator = generator;

            Initializer = new JavaScriptInitializer();
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            VerifySettings();

            WriteHtml(output);
            string initializationScript = GetInitializationScript();
            if (Deferred)
            {
                AppendScriptToContext(initializationScript);
            }
            else
            {
                output.PostElement.SetHtmlContent("<script>" + initializationScript + "</script>");
            }
        }
        private void AppendScriptToContext(string script)
        {
            var items = ViewContext.HttpContext.Items;

            var scripts = new List<KeyValuePair<string, string>>();

            if (items.ContainsKey(DeferredScriptsKey))
            {
                scripts = (List<KeyValuePair<string, string>>)items[DeferredScriptsKey];
            }
            else
            {
                items[DeferredScriptsKey] = scripts;
            }

            scripts.Add(new KeyValuePair<string, string>(Name, script));
        }
        protected virtual void VerifySettings()
        {

        }

        protected abstract void WriteHtml(TagHelperOutput output);

        protected abstract string GetInitializationScript();

        protected virtual Dictionary<string, object> SerializeSettings()
        {
            var settings = SerializeEvents();

            return settings;
        }

        protected abstract Dictionary<string, object> SerializeEvents();

        protected void GenerateId(TagHelperOutput output)
        {
            Id = Generator.SanitizeId(output.Attributes.ContainsName("id") ? (string)output.Attributes["id"].Value : ViewContext.GetFullHtmlFieldName(Name));
        }

        protected ClientHandlerDescriptor CreateHandler(string handler)
        {
            return new ClientHandlerDescriptor { HandlerName = handler };
        }

        protected Nullable<TValue> GetRangeValidationParameter<TValue>(ModelExplorer explorer, string parameter) where TValue : struct
        {
            var rangeAttribute = explorer.Metadata.ValidatorMetadata
                .Where(attr => attr is RangeAttribute)
                .FirstOrDefault() as RangeAttribute;

            if (rangeAttribute != null)
            {
                object value = parameter == "min" ? rangeAttribute.Minimum : rangeAttribute.Maximum;

                return (TValue)Convert.ChangeType(value, typeof(TValue));
            }

            return null;
        }

        protected string ExtractEditFormat(string format)
        {
            if (string.IsNullOrEmpty(format))
            {
                return string.Empty;
            }

            return StringFormatExpression.Match(format).ToString();
        }
    }
}
