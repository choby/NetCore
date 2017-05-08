using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RangeSlider component
    /// </summary>
    public partial class RangeSlider<T> : WidgetBase, IWidget
        where T : struct, IComparable 
    {
        public RangeSlider(ViewContext viewContext) : base(viewContext)
        {
        }

        public override void ProcessSettings()
        {
            if (!SelectionStart.HasValue)
            {
                SelectionStart = Min;
            }

            if (!SelectionEnd.HasValue)
            {
                SelectionEnd = Max;
            }

            if (!LargeStep.HasValue)
            {
                LargeStep = (T)Convert.ChangeType(5, typeof(T));
                if (LargeStep.Value.CompareTo(SmallStep) < 0)
                {
                    LargeStep = SmallStep;
                }
            }

            base.ProcessSettings();
        }

        protected override void WriteHtml(TextWriter writer)
        {
            var metadata = ExpressionMetadataProvider.FromStringExpression(Name, HtmlHelper.ViewData, HtmlHelper.MetadataProvider).Metadata;
            var wrapper = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);
            // TODO RC2
            //wrapper.MergeAttributes(Generator.GetValidationAttributes(ViewContext, metadata, Name));

            var firstInput = Generator.GenerateTag("input", ViewContext, Id, 
                             string.Format("{0}[0]", Name), HtmlAttributes);
            firstInput.Attributes.Remove(Id);

            if (SelectionStart.HasValue)
            {
                firstInput.MergeAttribute("value", this.GetValue("{0}[0]".FormatWith(Name), SelectionStart));
            }

            var secondInput = Generator.GenerateTag("input", ViewContext, Id,
                              string.Format("{0}[1]", Name), HtmlAttributes);
            secondInput.Attributes.Remove(Id);

            if (SelectionEnd.HasValue)
            {
                secondInput.MergeAttribute("value", this.GetValue("{0}[1]".FormatWith(Name), SelectionEnd));
            }

            var defaultOptions = new Dictionary<string, object>();
            defaultOptions.Add("type", "range");

            if (SmallStep.HasValue)
            {
                defaultOptions.Add("step", SmallStep);
            }

            if (Min.HasValue)
            {
                defaultOptions.Add("min", Min);
            }

            if (Max.HasValue)
            {
                defaultOptions.Add("max", Max);
            }

            firstInput.MergeAttributes(defaultOptions);
            secondInput.MergeAttributes(defaultOptions);

            wrapper.TagRenderMode = TagRenderMode.StartTag;
            wrapper.WriteTo(writer, HtmlEncoder);
            
            firstInput.TagRenderMode = TagRenderMode.SelfClosing;
            firstInput.WriteTo(writer, HtmlEncoder);

            secondInput.TagRenderMode = TagRenderMode.SelfClosing;
            secondInput.WriteTo(writer, HtmlEncoder);
            
            wrapper.TagRenderMode = TagRenderMode.EndTag;
            wrapper.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            writer.Write(Initializer.Initialize(Selector, "RangeSlider", settings));
        }
    }
}

