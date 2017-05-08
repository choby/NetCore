namespace Kendo.Mvc.UI
{
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.Resources;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
    using System.Text.Encodings.Web;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    public class SchedulerEditableSettings<T> : SchedulerEditableSettingsBase
        where T : class
    {
        private const string DefaultConfirmation = "Are you sure you want to delete this event?";

        public SchedulerEditableSettings()
            :base()
        {
            DisplayDeleteConfirmation = true;

            Confirmation = Messages.Scheduler_Confirmation;

            DefaultDataItem = CreateDefaultItem;

            Resize = true;
            Move = true;
        }

        public HtmlEncoder HtmlEncoder
        {
            get;
            set;
        }

        public string Template { get; set; }

        public string TemplateId { get; set; }

        public string Confirmation { get; set; }

        public bool Resize { get; set; }

        public bool DisplayDeleteConfirmation { get; set; }

        public bool Move { get; set; }

        public SchedulerEditRecurringMode EditRecurringMode { get; set; }

        public string TemplateName
        {
            get;
            set;
        }

        protected string EditorHtml
        {
            get;
            set;
        }

        public Window PopUp
        {
            get;
            set;
        }

        public object AdditionalViewData
        {
            get;
            set;
        }

        private IDictionary<string, object> SerializePopUp()
        {
            var result = new Dictionary<string, object>();

            var title = PopUp.Title ?? Messages.Scheduler_Editor_EditorTitle;

            if ((string)PopUp.Title !=  Messages.Scheduler_Editor_EditorTitle)
            {
                result["title"] = PopUp.Title;
            }
            
            //if (!PopUp.Modal)
            //{
            //     result["modal"] = PopUp.Modal;
            //}
            //
            //if (!PopUp.Draggable)
            //{
            //     result["draggable"] = PopUp.Draggable;
            //}
            
            if (PopUp.ResizingSettings.Enabled)
            {
                result["resizable"] = PopUp.ResizingSettings.Enabled;
            }
            
            if (PopUp.Width > 0)
            {
                result["width"] = PopUp.Width;
            }
            
            if (PopUp.Height > 0)
            {
                result["height"] = PopUp.Height;
            }
            
            //if (PopUp.PositionSettings.Left != int.MinValue || PopUp.PositionSettings.Top != int.MinValue)
            //{
            //    var topLeft = new Dictionary<string, int>();
            //
            //    if (PopUp.PositionSettings.Top != int.MinValue)
            //    {
            //        topLeft.Add("top", PopUp.PositionSettings.Top);
            //    }
            //
            //    if (PopUp.PositionSettings.Left != int.MinValue)
            //    {
            //        topLeft.Add("left", PopUp.PositionSettings.Left);
            //    }
            //
            //    result.Add("position", topLeft);
            //}

            return result;
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
            base.Serialize(json);

            if (!string.IsNullOrEmpty(Template))
            {
                json["template"] = Template;
            }

            if (!string.IsNullOrEmpty(TemplateId))
            {
                var idPrefix = "#";

                json["template"] = new ClientHandlerDescriptor { HandlerName = String.Format("kendo.template(jQuery('{0}{1}').html())", idPrefix, TemplateId) };
            }

            SerializeEditTemplate(json);

            if (!DisplayDeleteConfirmation)
            {
                json["confirmation"] = false;
            }
            else if (!string.IsNullOrEmpty(Confirmation) && Confirmation != DefaultConfirmation)
            {
                json["confirmation"] = Confirmation;
            }

            if (!Resize)
            {
                json["resize"] = false;
            }

            if (!Move)
            {
                json["move"] = false;
            }

            var popup = SerializePopUp();
            if (popup.Count > 0)
            {
                json["window"] = popup;
            }

            string editRecurringMode = EditRecurringMode.ToString();
            json["editRecurringMode"] = Char.ToLowerInvariant(editRecurringMode[0]) + editRecurringMode.Substring(1);
        }

        private void SerializeEditTemplate(IDictionary<string, object> options)
        {
            if (Enabled && !string.IsNullOrEmpty(EditorHtml))
            {
                var html = EditorHtml.Trim()
                                .EscapeHtmlEntities()
                                .Replace("\r\n", string.Empty)
                                .Replace("jQuery(\"#", "jQuery(\"\\#");

                options["template"] = html;
            }
        }

        public void InitializeEditor(ViewContext viewContext, IModelMetadataProvider ModelMetadataProvider)
        {
            if (Enabled && TemplateName.HasValue())
            {
                var popupSlashes = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);

                var viewContextForType = viewContext.ViewContextForType<T>(ModelMetadataProvider);

                var htmlHelper = viewContext.CreateHtmlHelper<T>();
                ((IViewContextAware)htmlHelper).Contextualize(viewContextForType);

                var editorContent = htmlHelper.EditorForModel(TemplateName, AdditionalViewData);//.ToString();

                var sb = new StringBuilder();

                using (var writer = new StringWriter(sb))
                {
                    editorContent.WriteTo(writer, HtmlEncoder);
                }

                EditorHtml = popupSlashes.Replace(sb.ToString(), match =>
                {
                    return match.Groups[0].Value.Replace("\\", "\\\\");
                });
            }
        }

        public Func<T> DefaultDataItem
        {
            get;
            set;
        }

        private T CreateDefaultItem()
        {          
            return Activator.CreateInstance<T>();
        }

    }
}
