using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using Kendo.Mvc.Resources;
using System.Linq;
using System.Net;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Tooltip component
    /// </summary>
    public partial class Tooltip : WidgetBase
        
    {
        public Tooltip(ViewContext viewContext) : base(viewContext)
        {            
        }

        public PopupAnimation Animation { get; } = new PopupAnimation();

        private string container;
        public string Container
        {
            get
            {
                return container;
            }
            set
            {
                Name = container = value;
            }
        }
        public string ContentUrl { get; set; }
        public string Content { get; set; }
        public string ContentTemplateId { get; set; }
        public ClientHandlerDescriptor ContentHandler { get; } = new ClientHandlerDescriptor();

        private string Encode(string value)
        {
            value = Regex.Replace(value, "(%20)*%23%3D(%20)*", "#=", RegexOptions.IgnoreCase);
            value = Regex.Replace(value, "(%20)*%23(%20)*", "#", RegexOptions.IgnoreCase);
            value = Regex.Replace(value, "(%20)*%24%7B(%20)*", "${", RegexOptions.IgnoreCase);
            value = Regex.Replace(value, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);

            return value;
        }

        protected override void WriteHtml(TextWriter writer)
        {
            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = Serialize();

            writer.Write(Initializer.InitializeFor(SanitizeSelector(Container), "Tooltip", settings));
        }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            if (Filter.HasValue())
            {
                settings["filter"] = SanitizeSelector(Filter);
            }

            var animation = Animation.ToJson();

            if (animation.Any())
            {
                if (animation["animation"] is bool)
                {
                    settings["animation"] = false;
                }
                else
                {
                    settings["animation"] = animation["animation"];
                }
            }

            SerializeContent(settings);

            return settings;
        }

        private void SerializeContent(Dictionary<string, object> options)
        {
            if (ContentUrl.HasValue())
            {
                options["content"] = new Dictionary<string, object>() {
                    { "url", Encode(ContentUrl) }
                };
            }
            else if (ContentHandler.HasValue())
            {
                options["content"] = ContentHandler;
            }
            else if (!String.IsNullOrEmpty(ContentTemplateId))
            {
                var idPrefix = "#";
                if (IsInClientTemplate)
                {
                    idPrefix = "\\" + idPrefix;
                }
                options["content"] = new ClientHandlerDescriptor { HandlerName = String.Format("kendo.template(jQuery('{0}{1}').html())", idPrefix, ContentTemplateId) };
            }
            else if (Content.HasValue())
            {
                options["content"] = WebUtility.UrlDecode(Content);
            }
        }

        public override void VerifySettings()
        {
            if (string.IsNullOrEmpty(Container))
            {
                throw new InvalidOperationException(Exceptions.TooltipContainerShouldBeSet);
            }

            this.ThrowIfClassIsPresent("k-" + GetType().GetTypeName().ToLowerInvariant() + "-rtl", Exceptions.Rtl);
        }

        private string SanitizeSelector(string selector)
        {
            if (string.IsNullOrWhiteSpace(selector))
            {
                return string.Empty;
            }

            if (!IsInClientTemplate)
            {
                return selector;
            }

            StringBuilder builder = new StringBuilder(selector.Length);
            int startSharpIndex = selector.IndexOf("#=");
            int endSharpIndex = selector.LastIndexOf("#");

            if (endSharpIndex > startSharpIndex && startSharpIndex > -1)
            {
                builder.Append(selector.Substring(0, startSharpIndex).Replace("#", "\\#"));
                builder.Append(selector.Substring(startSharpIndex, endSharpIndex - startSharpIndex + 1));
                builder.Append(selector.Substring(endSharpIndex + 1).Replace("#", "\\#"));
            }
            else
            {
                builder.Append(selector.Replace("#", "\\#"));
            }

            return builder.ToString();
        }
    }
}

