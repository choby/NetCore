using Microsoft.AspNetCore.Razor.TagHelpers;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Kendo.Mvc.TagHelpers
{
    /// <summary>
    /// Kendo UI TimePicker TagHelper
    /// </summary>
    [HtmlTargetElement("kendo-timepicker")]
    [OutputElementHint("input")]
    public partial class TimePickerTagHelper : TagHelperBase
    {
        /// <summary>
        /// An expression to be evaluated against the current model.
        /// </summary>
        public ModelExpression For { get; set; }

        public TimePickerTagHelper(IKendoHtmlGenerator generator) : base(generator)
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

                Value = Value ?? For.Model as DateTime?;

                Format = ExtractEditFormat(For.ModelExplorer.Metadata.EditFormatString);

                Min = Min ?? GetRangeValidationParameter<DateTime>(explorer, MinimumValidator);
                Max = Max ?? GetRangeValidationParameter<DateTime>(explorer, MaximumValidator);
            }

            GenerateId(output);

            var htmlAttributes = new Dictionary<string, object>();

            var tagBuilder = Generator.GenerateTimeInput(ViewContext, explorer,
                Id, Name, Value, Format, htmlAttributes);

            output.TagName = "input";
            output.TagMode = TagMode.SelfClosing;

            output.MergeAttributes(tagBuilder);
        }

        protected override string GetInitializationScript()
        {
            var settings = SerializeSettings();

            // TODO: Manually serialized settings go here

            return Initializer.Initialize(Selector, "TimePicker", settings);
        }
    }
}

