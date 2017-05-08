using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Kendo.Mvc.UI
{
    public class RadioButtonHtmlBuilder
    {
        public RadioButtonHtmlBuilder(RadioButton component)
        {
            Component = component;
        }

        public RadioButton Component { get; private set; }

        public virtual void WriteHtml(TextWriter writer, HtmlEncoder htmlEncoder)
        {
            var radioButton = BuildRadioButton();
            BuildRadioButton().WriteTo(writer, htmlEncoder);

            var label = BuildLabel();
            label.WriteTo(writer, htmlEncoder);
        }

        protected virtual IHtmlNode BuildRadioButton()
        {
            var radioButton = new HtmlElement("input", TagRenderMode.SelfClosing)
                .Attributes(new
                {
                    name = Component.Name,
                    id = RenderId(),
                    type = "radio",
                    value = Component.Value != null ? Component.Value.ToString() : string.Empty
                })
                .ToggleAttribute("checked", "checked", Component.Checked == true || IsCheckedFromModel())
                .ToggleAttribute("disabled", "disabled", Component.Enabled != true)
                .Attributes(Component.HtmlAttributes)
                .PrependClass("k-radio");

            return radioButton;
        }

        public IHtmlNode BuildLabel()
        {
            var metadata = GetModelMetaData();
            var defaultLabel = metadata != null ? metadata.DisplayName : string.Empty;

            return new HtmlElement("label")
                .Attributes(new
                {
                    @for = RenderId(),
                    @class = "k-radio-label"
                })
                .Text(Component.Label ?? defaultLabel);
        }

        protected virtual bool IsCheckedFromModel()
        {
            string modelCheckedValue = "";
            ModelStateEntry state;

            if (Component.ViewContext.ViewData.ModelState.TryGetValue(Component.Name, out state) && state.RawValue != null)
            {
                modelCheckedValue = state.RawValue as string;
            }
            else
            {
                modelCheckedValue = Component.GetValue<string>(Component.Name, null);
            }

            string componentValue = Component.Value != null ? Component.Value.ToString() : string.Empty;

            return (modelCheckedValue.HasValue() && modelCheckedValue == componentValue);
        }

        protected virtual ModelMetadata GetModelMetaData()
        {
            var modelExplorer = ExpressionMetadataProvider.FromStringExpression(
                Component.Name, Component.HtmlHelper.ViewData, Component.HtmlHelper.MetadataProvider);

            return modelExplorer.Metadata;
        }

        private string RenderId()
        {
            return Component.Id + "_" + Component.Value;
        }
    }
}
