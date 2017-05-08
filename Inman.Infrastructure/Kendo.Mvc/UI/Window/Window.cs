using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Window component
    /// </summary>
    public partial class Window : WidgetBase        
    {
		private readonly IList<IWindowButton> defaultButtons = new [] { new HeaderButton { Name = "Close", CssClass = "k-i-close" } };

		public Window(ViewContext viewContext) : base(viewContext)
        {
			defaultButtons.Each(button => Actions.Container.Add(button));
			ContentHtmlAttributes = new RouteValueDictionary();
			Scrollable = true;
		}		

		public string AppendTo
		{
			get;
			set;
		}	

		private string loadContentFromUrl;
		public string ContentUrl
		{
			get
			{
				return loadContentFromUrl;
			}
			set
			{

				loadContentFromUrl = value;
				ContentHtmlAttributes.Clear();
				Content = null;
			}
		}

		public string Html
		{
			get; set;
		}

		public Func<object, object> Content
		{
			get; set;
		}

		public Action ContentAction { get; set; }

		public IDictionary<string, object> ContentHtmlAttributes
		{
			get;
			private set;
		}

		public WindowButtons Actions { get; } = new WindowButtons();

		public PopupAnimation Animation { get; } = new PopupAnimation();

		public WindowResizingSettings ResizingSettings { get; } = new WindowResizingSettings();

		protected override void WriteHtml(TextWriter writer)
        {			
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

			if (!Visible.GetValueOrDefault(true))
			{
				tag.MergeAttribute("style", "display:none");
			}			
						
            tag.TagRenderMode = TagRenderMode.StartTag;
            tag.WriteTo(writer, HtmlEncoder);

            if (Html.HasValue())
			{
				writer.Write(Html);
			}
			else if (Content != null)
			{
				writer.WriteContent(Content, HtmlEncoder);
			}
			else if (ContentAction != null)
			{
				ContentAction();
			}

            tag.TagRenderMode = TagRenderMode.EndTag;
            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

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

			settings.Add("content", ContentUrl);

            if (!string.IsNullOrEmpty(AppendTo))
			{
				settings.Add("appendTo", AppendTo);
			}

			settings.Add("actions", Actions.Container.Select(item => item.Name));

			if (ResizingSettings.Enabled)
			{
				if (ResizingSettings.MinHeight != int.MinValue)
				{
					settings.Add("minHeight", ResizingSettings.MinHeight);
				}

				if (ResizingSettings.MinWidth != int.MinValue)
				{
					settings.Add("minWidth", ResizingSettings.MinWidth);
				}

				if (ResizingSettings.MaxHeight != int.MinValue)
				{
					settings.Add("maxHeight", ResizingSettings.MaxHeight);
				}

				if (ResizingSettings.MaxWidth != int.MinValue)
				{
					settings.Add("maxWidth", ResizingSettings.MaxWidth);
				}
			}

			writer.Write(Initializer.Initialize(Selector, "Window", settings));
        }
    }
}

