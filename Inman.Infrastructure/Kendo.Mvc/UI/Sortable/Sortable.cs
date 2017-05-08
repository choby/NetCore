using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Text.RegularExpressions;
using Kendo.Mvc.Resources;
using System.Text;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Sortable component
    /// </summary>
    public partial class Sortable : WidgetBase
        
    {
        public Sortable(ViewContext viewContext) : base(viewContext)
        {
        }

        public string SortableContainer { get; set; }

        public string ContainerSelector { get; set; }

        public ClientHandlerDescriptor HintHandler { get; set; }

        public string Hint { get; set; }

        public ClientHandlerDescriptor PlaceholderHandler { get; set; }

        public string Placeholder { get; set; }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (HintHandler?.HasValue() == true)
            {
                settings["hint"] = HintHandler;
            }
            else if(Hint?.HasValue() == true)
            {
                settings["hint"] = Hint;
            }

            if (PlaceholderHandler?.HasValue() == true)
            {
                settings["placeholder"] = PlaceholderHandler;
            }
            else if (Placeholder?.HasValue() == true)
            {
                settings["placeholder"] = Placeholder;
            }

            if (ContainerSelector?.HasValue() == true)
            {
                settings["container"] = SanitizeSelector(ContainerSelector);
            }

            if (Filter?.HasValue() == true)
            {
                settings["filter"] = SanitizeSelector(Filter);
            }

            if (Disabled?.HasValue() == true)
            {
                settings["disabled"] = SanitizeSelector(Disabled);
            }

            if (Handler?.HasValue() == true)
            {
                settings["handler"] = SanitizeSelector(Handler);
            }

            if (ConnectWith?.HasValue() == true)
            {
                settings["connectWith"] = SanitizeSelector(ConnectWith);
            }

            if (Ignore?.HasValue() == true)
            {
                settings["ignore"] = SanitizeSelector(Ignore);
            }

            if (HoldToDrag.HasValue && HoldToDrag.Value == true)
            {
                settings["holdToDrag"] = HoldToDrag;
            }

            if (Axis.HasValue && Axis.Value != SortableAxis.None)
            {
                settings["axis"] = Axis?.Serialize();
            }

            if (Cursor?.HasValue() == true)
            {
                settings["cursor"] = SanitizeSelector(Cursor);
            }

            writer.Write(Initializer.Initialize(SanitizeSelector(SortableContainer), "Sortable", settings));
        }

        public override void VerifySettings()
        {
            if (string.IsNullOrEmpty(SortableContainer))
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

        private string Encode(string value)
        {
            value = Regex.Replace(value, "(%20)*%23%3D(%20)*", "#=", RegexOptions.IgnoreCase);
            value = Regex.Replace(value, "(%20)*%23(%20)*", "#", RegexOptions.IgnoreCase);
            value = Regex.Replace(value, "(%20)*%24%7B(%20)*", "${", RegexOptions.IgnoreCase);
            value = Regex.Replace(value, "(%20)*%7D(%20)*", "}", RegexOptions.IgnoreCase);

            return value;
        }
    }
}

