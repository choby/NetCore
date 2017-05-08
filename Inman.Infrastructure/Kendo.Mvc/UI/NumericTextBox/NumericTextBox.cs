using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
using System.IO;

namespace Kendo.Mvc.UI
{
	/// <summary>
	/// Kendo UI NumericTextBox component
	/// </summary>
	public partial class NumericTextBox<T> : WidgetBase
        where T : struct 
    {
        public NumericTextBox(ViewContext viewContext) : base(viewContext)
        {
        }

        protected override void WriteHtml(TextWriter writer)
        {
			// Do custom rendering here

			var explorer = ExpressionMetadataProvider.FromStringExpression(Name, HtmlHelper.ViewData, HtmlHelper.MetadataProvider);
			var tag = Generator.GenerateNumericInput(ViewContext, explorer, Id, Name, Value, string.Empty, HtmlAttributes);

			if (!Enable.GetValueOrDefault(true))
			{
				tag.MergeAttribute("disabled", "disabled");
			}

			if (Value.HasValue)
			{
				tag.MergeAttribute("value", "{0}".FormatWith(Value));
			}

			if (Min.HasValue)
			{
				tag.MergeAttribute("min", "{0}".FormatWith(Min));
			}

			if (Max.HasValue)
			{
				tag.MergeAttribute("max", "{0}".FormatWith(Max));
			}

			if (Step.HasValue)
			{
				tag.MergeAttribute("step", "{0}".FormatWith(Step));
			}

			tag.TagRenderMode = TagRenderMode.SelfClosing;
            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

			// TODO: Manually serialized settings go here			

			writer.Write(Initializer.Initialize(Selector, "NumericTextBox", settings));
        }
    }
}

