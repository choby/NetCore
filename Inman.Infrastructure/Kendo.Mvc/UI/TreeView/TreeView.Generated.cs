using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeView component
    /// </summary>
    public partial class TreeView 
    {
        public bool? AutoBind { get; set; }

        public bool? AutoScroll { get; set; }

        public TreeViewCheckboxesSettings Checkboxes { get; } = new TreeViewCheckboxesSettings();

        public string DataImageUrlField { get; set; }

        public string DataSpriteCssClassField { get; set; }

        public string[] DataTextField { get; set; }

        public string DataUrlField { get; set; }

        public bool? DragAndDrop { get; set; }

        public bool? LoadOnDemand { get; set; }

        public TreeViewMessagesSettings Messages { get; } = new TreeViewMessagesSettings();

        public string Template { get; set; }

        public string TemplateId { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (AutoScroll.HasValue)
            {
                settings["autoScroll"] = AutoScroll;
            }

            var checkboxes = Checkboxes.Serialize();
            if (checkboxes.Any())
            {
                settings["checkboxes"] = checkboxes;
            }
            else if (Checkboxes.Enabled.HasValue)
            {
                settings["checkboxes"] = Checkboxes.Enabled;
            }

            if (DataImageUrlField?.HasValue() == true)
            {
                settings["dataImageUrlField"] = DataImageUrlField;
            }

            if (DataSpriteCssClassField?.HasValue() == true)
            {
                settings["dataSpriteCssClassField"] = DataSpriteCssClassField;
            }

            if (DataTextField?.Any() == true)
            {
                settings["dataTextField"] = DataTextField;
            }

            if (DataUrlField?.HasValue() == true)
            {
                settings["dataUrlField"] = DataUrlField;
            }

            if (DragAndDrop.HasValue)
            {
                settings["dragAndDrop"] = DragAndDrop;
            }

            if (LoadOnDemand.HasValue)
            {
                settings["loadOnDemand"] = LoadOnDemand;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
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

            return settings;
        }
    }
}
