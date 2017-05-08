using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DropDownList component
    /// </summary>
    public partial class DropDownList 
    {
        public bool? AutoBind { get; set; }

        public bool? AutoWidth { get; set; }

        public string CascadeFrom { get; set; }

        public string CascadeFromField { get; set; }

        public string DataTextField { get; set; }

        public string DataValueField { get; set; }

        public double? Delay { get; set; }

        public bool? Enable { get; set; }

        public bool? EnforceMinLength { get; set; }

        public string FixedGroupTemplate { get; set; }

        public string FixedGroupTemplateId { get; set; }

        public string FooterTemplate { get; set; }

        public string FooterTemplateId { get; set; }

        public string GroupTemplate { get; set; }

        public string GroupTemplateId { get; set; }

        public double? Height { get; set; }

        public bool? IgnoreCase { get; set; }

        public double? MinLength { get; set; }

        public string NoDataTemplate { get; set; }

        public string NoDataTemplateId { get; set; }

        public DropDownListPopupSettings Popup { get; } = new DropDownListPopupSettings();

        public object OptionLabel { get; set; }

        public string OptionLabelTemplate { get; set; }

        public string OptionLabelTemplateId { get; set; }

        public string HeaderTemplate { get; set; }

        public string HeaderTemplateId { get; set; }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public string ValueTemplate { get; set; }

        public string ValueTemplateId { get; set; }

        public string Text { get; set; }

        public string Value { get; set; }

        public bool? ValuePrimitive { get; set; }

        public DropDownListVirtualSettings Virtual { get; } = new DropDownListVirtualSettings();

        public FilterType? Filter { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (AutoWidth.HasValue)
            {
                settings["autoWidth"] = AutoWidth;
            }

            if (CascadeFrom?.HasValue() == true)
            {
                settings["cascadeFrom"] = CascadeFrom;
            }

            if (CascadeFromField?.HasValue() == true)
            {
                settings["cascadeFromField"] = CascadeFromField;
            }

            if (DataTextField?.HasValue() == true)
            {
                settings["dataTextField"] = DataTextField;
            }

            if (DataValueField?.HasValue() == true)
            {
                settings["dataValueField"] = DataValueField;
            }

            if (Delay.HasValue)
            {
                settings["delay"] = Delay;
            }

            if (Enable.HasValue)
            {
                settings["enable"] = Enable;
            }

            if (EnforceMinLength.HasValue)
            {
                settings["enforceMinLength"] = EnforceMinLength;
            }

            if (FixedGroupTemplateId.HasValue())
            {
                settings["fixedGroupTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, FixedGroupTemplateId
                    )
                };
            }
            else if (FixedGroupTemplate.HasValue())
            {
                settings["fixedGroupTemplate"] = FixedGroupTemplate;
            }

            if (FooterTemplateId.HasValue())
            {
                settings["footerTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, FooterTemplateId
                    )
                };
            }
            else if (FooterTemplate.HasValue())
            {
                settings["footerTemplate"] = FooterTemplate;
            }

            if (GroupTemplateId.HasValue())
            {
                settings["groupTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, GroupTemplateId
                    )
                };
            }
            else if (GroupTemplate.HasValue())
            {
                settings["groupTemplate"] = GroupTemplate;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            if (IgnoreCase.HasValue)
            {
                settings["ignoreCase"] = IgnoreCase;
            }

            if (MinLength.HasValue)
            {
                settings["minLength"] = MinLength;
            }

            if (NoDataTemplateId.HasValue())
            {
                settings["noDataTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, NoDataTemplateId
                    )
                };
            }
            else if (NoDataTemplate.HasValue())
            {
                settings["noDataTemplate"] = NoDataTemplate;
            }

            var popup = Popup.Serialize();
            if (popup.Any())
            {
                settings["popup"] = popup;
            }

            if (OptionLabel != null)
            {
                settings["optionLabel"] = OptionLabel;
            }

            if (OptionLabelTemplateId.HasValue())
            {
                settings["optionLabelTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, OptionLabelTemplateId
                    )
                };
            }
            else if (OptionLabelTemplate.HasValue())
            {
                settings["optionLabelTemplate"] = OptionLabelTemplate;
            }

            if (HeaderTemplateId.HasValue())
            {
                settings["headerTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, HeaderTemplateId
                    )
                };
            }
            else if (HeaderTemplate.HasValue())
            {
                settings["headerTemplate"] = HeaderTemplate;
            }

            if (TemplateId.HasValue())
            {
                settings["template"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, TemplateId
                    )
                };
            }
            else if (Template.HasValue())
            {
                settings["template"] = Template;
            }

            if (ValueTemplateId.HasValue())
            {
                settings["valueTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, ValueTemplateId
                    )
                };
            }
            else if (ValueTemplate.HasValue())
            {
                settings["valueTemplate"] = ValueTemplate;
            }

            if (Text?.HasValue() == true)
            {
                settings["text"] = Text;
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            if (ValuePrimitive.HasValue)
            {
                settings["valuePrimitive"] = ValuePrimitive;
            }

            var @virtual = Virtual.Serialize();
            if (@virtual.Any())
            {
                settings["virtual"] = @virtual;
            }
            else if (Virtual.Enabled.HasValue)
            {
                settings["virtual"] = Virtual.Enabled;
            }

            if (Filter.HasValue)
            {
                settings["filter"] = Filter?.Serialize();
            }

            return settings;
        }
    }
}
