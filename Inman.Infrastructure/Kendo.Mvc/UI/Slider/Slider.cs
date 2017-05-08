using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Slider component
    /// </summary>
    public partial class Slider<T> : WidgetBase, IInputComponent<T>
        where T : struct, IComparable
    {
        public Slider(ViewContext viewContext) : base(viewContext)
        {
        }

        public override void ProcessSettings()
        {
            Func<object, T?> converter = val =>
            {
                return ((T)Convert.ChangeType(val, typeof(T)));
            };

            string value = this.GetAttemptedValue();
            if (value == null)
            {
                T? result = this.GetValue(converter);

                if (!result.HasValue)
                {
                    result = Min;
                }
                CultureInfo info = CultureInfo.CurrentCulture;
                value = string.Format(info, "{0}", result);
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
            var explorer = ExpressionMetadataProvider.FromStringExpression(Name, HtmlHelper.ViewData, HtmlHelper.MetadataProvider);
            var tag = Generator.GenerateRangeInput(ViewContext, explorer, Id, Name, Value, HtmlAttributes);

            if (SmallStep.HasValue)
            {
                tag.MergeAttribute("step", SmallStep.ToString());
            }

            if (Min.HasValue)
            {
                tag.MergeAttribute("min", Min.ToString());
            }

            if (Max.HasValue)
            {
                tag.MergeAttribute("max", Max.ToString());
            }

            if (Value.HasValue == false)
            {
                tag.Attributes.Remove("value");
            }

            tag.TagRenderMode = TagRenderMode.SelfClosing;
            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            writer.Write(Initializer.Initialize(Selector, "Slider", settings));
        }
    }
}

