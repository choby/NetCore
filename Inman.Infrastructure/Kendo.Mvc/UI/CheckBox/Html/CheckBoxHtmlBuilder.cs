using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Kendo.Mvc.UI
{
    public class CheckBoxHtmlBuilder
    {
        public CheckBoxHtmlBuilder(CheckBox checkBox)
        {
            Component = checkBox;
        }

        public CheckBox Component { get; private set; }

        public virtual void WriteHtml(TextWriter writer, HtmlEncoder htmlEncoder)
        {
            var checkBox = BuildCheckBox();
            checkBox.WriteTo(writer, htmlEncoder);

            var label = BuildLabel();
            label.WriteTo(writer, htmlEncoder);

            var hiddenInput = BuildHiddenInput();
            hiddenInput.WriteTo(writer, htmlEncoder);
        }

        protected virtual IHtmlNode BuildCheckBox()
        {
            var tag = new HtmlElement("input", TagRenderMode.SelfClosing)
                .Attributes(new
                {
                    name = Component.Name,
                    id = Component.Id,
                    type = "checkbox",
                    value = "true"
                })
                .ToggleAttribute("checked", "checked", Component.Checked == true)
                .ToggleAttribute("disabled", "disabled", Component.Enabled != true)
                .Attributes(Component.HtmlAttributes)
                .PrependClass("k-checkbox");

            return tag;
        }
        
        protected virtual IHtmlNode BuildLabel()
        {
            var metadata = GetModelMetaData();
            var defaultLabel = metadata != null ? metadata.DisplayName : string.Empty;

            var label = new HtmlElement("label")
                .Attributes(new
                {
                    @for = Component.Id,
                    @class = "k-checkbox-label"
                })
                .Text(Component.Label ?? defaultLabel);

            return label;
        }

        protected virtual IHtmlNode BuildHiddenInput()
        {
            var hiddenInput = new HtmlElement("input", TagRenderMode.SelfClosing)
                .Attributes(new
                {
                    name = Component.Name,
                    value = "false",
                    type = "hidden"
                });

            return hiddenInput;
        }

        protected virtual ModelMetadata GetModelMetaData()
        {
            var modelExplorer = ExpressionMetadataProvider.FromStringExpression(
                Component.Name, Component.HtmlHelper.ViewData, Component.HtmlHelper.MetadataProvider);

            return modelExplorer.Metadata;
        }
    }
}
