using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Kendo.Mvc.TagHelpers
{
    /// <summary>
    /// Kendo UI NumericTextBox TagHelper
    /// </summary>
    [HtmlTargetElement("kendo-numerictextbox")]
    [OutputElementHint("input")]
    public partial class NumericTextBoxTagHelper : TagHelperBase
    {
        /// <summary>
        /// An expression to be evaluated against the current model.
        /// </summary>
        public ModelExpression For { get; set; }

        public NumericTextBoxTagHelper(IKendoHtmlGenerator generator) : base(generator)
        {
        }

        protected override void WriteHtml(TagHelperOutput output)
        {
            ModelMetadata metadata = null;
            ModelExplorer explorer = null;

            if (For != null)
            {
                explorer = For.ModelExplorer;
                metadata = For.Metadata;
                Name = For.Name;

                if (Value == null && For.Model != null)
                {
                    Value = Convert.ToDouble(For.Model);
                }

                Format = ExtractEditFormat(For.ModelExplorer.Metadata.EditFormatString);

                Min = Min ?? GetRangeValidationParameter<double>(explorer, MinimumValidator);
                Max = Max ?? GetRangeValidationParameter<double>(explorer, MaximumValidator);
            }

            GenerateId(output);

            var htmlAttributes = new Dictionary<string, object>();

            if (!Enable.GetValueOrDefault(true))
            {
                htmlAttributes.Add("disabled", "disabled");
            }

            if (Min != null)
            {
                htmlAttributes.Add("min", "{0}".FormatWith(Min));
            }

            if (Max != null)
            {
                htmlAttributes.Add("max", "{0}".FormatWith(Max));
            }

            if (Step != null)
            {
                htmlAttributes.Add("step", "{0}".FormatWith(Step));
            }

            var tagBuilder = Generator.GenerateNumericInput(ViewContext, explorer,
                Id, Name, Value, string.Empty, htmlAttributes);

            output.TagName = "input";
            output.TagMode = TagMode.SelfClosing;

            output.MergeAttributes(tagBuilder);
        }

        protected override string GetInitializationScript()
        {
            var settings = SerializeSettings();

            // TODO: Manually serialized settings go here

            return Initializer.Initialize(Selector, "NumericTextBox", settings);
        }
    }
}

