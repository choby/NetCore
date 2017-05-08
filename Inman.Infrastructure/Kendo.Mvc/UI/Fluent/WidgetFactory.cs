using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        private static readonly Regex StringFormatExpression = new Regex(@"(?<=\{\d:)(.)*(?=\})", RegexOptions.Compiled);
        private const string MinimumValidator = "min";
        private const string MaximumValidator = "max";

        public WidgetFactory(IHtmlHelper<TModel> htmlHelper)
        {
            HtmlHelper = htmlHelper;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public IHtmlHelper<TModel> HtmlHelper
        {
            get;
            set;
        }

        protected ModelExplorer GetModelExplorer<TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            var explorer = ExpressionMetadataProvider.FromLambdaExpression(expression, HtmlHelper.ViewData, HtmlHelper.MetadataProvider);
            if (explorer == null)
            {
                var expressionName = GetExpressionName(expression);
                throw new InvalidOperationException("No model metadata: " + expressionName);
            }

            return explorer;
        }

        protected string GetExpressionName<TProperty>(Expression<Func<TModel, TProperty>> expression)
        {
            return ExpressionHelper.GetExpressionText(expression);
        }

        private Nullable<TValue> GetRangeValidationParameter<TValue>(ModelExplorer explorer, string parameter) where TValue : struct
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

        private string ExtractEditFormat(string format)
        {
            if (string.IsNullOrEmpty(format))
            {
                return string.Empty;
            }

            return StringFormatExpression.Match(format).ToString();
        }

        /// <summary>
        /// Returns the initialization scripts for widgets set as deferred
        /// </summary>
        /// <param name="renderScriptTags">Determines if the script should be rendered within a script tag</param>
        /// <returns></returns>
        public virtual HtmlString DeferredScripts(bool renderScriptTags = true)
        {
            var items = HtmlHelper.ViewContext.HttpContext.Items;

            if (items.ContainsKey(WidgetBase.DeferredScriptsKey))
            {
                var scripts = (List<KeyValuePair<string, string>>)items[WidgetBase.DeferredScriptsKey];

                return DeferredScripts(scripts.Select(kv => kv.Value), renderScriptTags);
            }

            return HtmlString.Empty;
        }

        private HtmlString DeferredScripts(IEnumerable<string> scripts, bool renderScriptTags)
        {
            var result = new StringBuilder();

            if (renderScriptTags)
            {
                result.Append("<script>");
            }

            foreach (var script in scripts)
            {
                result.Append(script);
            }

            if (renderScriptTags)
            {
                result.Append("</script>");
            }

            return new HtmlString(result.ToString());
        }

        /// <summary>
        /// Returns the initialization scripts for the specified widget.
        /// </summary>
        /// <param name="name">The name of the widget.</param>
        /// <param name="renderScriptTags">Determines if the script should be rendered within a script tag</param>
        /// <returns></returns>
        public virtual HtmlString DeferredScriptsFor(string name, bool renderScriptTags = true)
        {
            var items = HtmlHelper.ViewContext.HttpContext.Items;

            if (items.ContainsKey(WidgetBase.DeferredScriptsKey))
            {
                var scripts = (List<KeyValuePair<string, string>>)items[WidgetBase.DeferredScriptsKey];
                var match = scripts.Any(kv => kv.Key == name);

                if (match)
                {
                    var entry = scripts.First(kv => kv.Key == name);
                    return DeferredScripts(new[] { entry.Value }, renderScriptTags);
                }
            }

            return HtmlString.Empty;
        }

        private string GetValue<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var explorer = GetModelExplorer(expression);
            var model = explorer.Model;

            if (model != null && (model.GetType().IsPredefinedType() || model.GetType().IsEnumType()))
            {
                return Convert.ToString(model);
            }

            return null;
        }

        private string GetValueWithEnum<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var explorer = GetModelExplorer(expression);
            var model = explorer.Model;

            if (model != null)
            {
                if (model.GetType().IsPredefinedType())
                {
                    return Convert.ToString(model);
                }
                else if (model.GetType().IsEnumType())
                {
                    return Convert.ToString(Convert.ToInt32(model));
                }
            }

            return null;
        }
    }
}
