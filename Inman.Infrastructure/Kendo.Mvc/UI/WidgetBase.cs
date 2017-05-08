using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Linq;

namespace Kendo.Mvc.UI
{
    public abstract class WidgetBase : IHtmlAttributesContainer
    {
        internal static readonly string DeferredScriptsKey = "$DeferredScriptsKey$";
        private static readonly Regex UnicodeEntityExpression = new Regex(@"\\+u(\d+)\\*#(\d+;)", RegexOptions.Compiled);

        public WidgetBase(ViewContext viewContext)
        {
            Events = new Dictionary<string, object>();
            HtmlAttributes = new RouteValueDictionary();
            IsSelfInitialized = true;
            Initializer = new JavaScriptInitializer();
            ViewContext = viewContext;

            Activate();			
        }
	
		/// <summary>
		/// Gets the client events of the widget.
		/// </summary>
		/// <value>The client events.</value>
		public IDictionary<string, object> Events {
            get;
            private set;
        }
        
        /// <summary>
        /// Gets the unique ID of the widget
        /// </summary>
        /// <value>The unique ID of the widget</value>
        public string Id
        {
            get
            {
                return Generator.SanitizeId(HtmlAttributes.ContainsKey("id") ? (string) HtmlAttributes["id"] : ViewContext.GetFullHtmlFieldName(Name));
            }
        }

        public IJavaScriptInitializer Initializer
        {
            get;
            set;
        }

        public bool IsInClientTemplate
        {
            get;
            private set;
        }

        public bool IsSelfInitialized
        {
            get;
            set;
        }

        public bool HasDeferredInitialization
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the HTML attributes of the widget.
        /// </summary>
        /// <value>The HTML attributes.</value>
        public IDictionary<string, object> HtmlAttributes
        {
            get;
            set;
        }

        public IHtmlHelper HtmlHelper { get; set; }

        public IModelMetadataProvider ModelMetadataProvider
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name
        {
            get;
            set;
        }

        public string Selector
        {
            get
            {
                return IdPrefix + Id;
            }
        }

		public string IdPrefix
		{
			get
			{
				return IsInClientTemplate ? "\\#" : "#";
			}
		}

		/// <summary>
		/// Gets or sets the view context to rendering a view.
		/// </summary>
		/// <value>The view context.</value>
		public ViewContext ViewContext
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a reference to the ValueProvider for the current ActionContext
        /// </summary>
        public IValueProvider ValueProvider
        {
            get
            {
                var optionsAccessor = ViewContext.GetService<IOptions<MvcOptions>>();
                var providerFactories = optionsAccessor.Value.ValueProviderFactories.ToArray();

                var actionContext = ViewContext.GetService<IActionContextAccessor>().ActionContext;
                var factoryContext = new ValueProviderFactoryContext(actionContext);

                for (var i = 0; i < providerFactories.Length; i++)
                {
                    var factory = providerFactories[i];
                    factory.CreateValueProviderAsync(factoryContext);
                }

                return new CompositeValueProvider(factoryContext.ValueProviders);
            }
        }

        protected IKendoHtmlGenerator Generator { get; set; }

        public IUrlGenerator UrlGenerator
        {
            get;
            set;
        }

        public HtmlEncoder HtmlEncoder
        {
            get;
            set;
        }

        /// <summary>
        /// Renders the component.
        /// </summary>
        public void Render()
        {
            RenderHtml(ViewContext.Writer);
        }

        /// <summary>
        /// Serialize manual settings here
        /// </summary>
        /// <returns></returns>
        protected virtual Dictionary<string, object> SerializeSettings()
        {
            return new Dictionary<string, object>(Events);
        }

        public HtmlString ToClientTemplate()
        {
			IsInClientTemplate = true;

			var html = ToHtmlString().Replace("</script>", "<\\/script>");

			//TODO: Handle AntiXssEncoder
			//if (HttpEncoder.Current != null && HttpEncoder.Current.GetType().ToString().Contains("AntiXssEncoder"))
			//{
			//	html = Regex.Replace(html, "\\u0026", "&", RegexOptions.IgnoreCase);
			//	html = Regex.Replace(html, "%23", "#", RegexOptions.IgnoreCase);
			//	html = Regex.Replace(html, "%3D", "=", RegexOptions.IgnoreCase);
			//	html = Regex.Replace(html, "&#32;", " ", RegexOptions.IgnoreCase);
			//	html = Regex.Replace(html, @"\\u0026#32;", " ", RegexOptions.IgnoreCase);
			//}
			//escape entities in attributes encoded by the TextWriter Unicode encoding
			html = UnicodeEntityExpression.Replace(html, (m) =>
			{
				return WebUtility.HtmlDecode(Regex.Unescape(@"\u" + m.Groups[1].Value + "#" + m.Groups[2].Value));
			});

			//must decode unicode symbols otherwise they will be rendered as HTML entities
			//which will break the client template
			html = WebUtility.HtmlDecode(html);

			return new HtmlString(html);
		}

        public string ToHtmlString()
        {
            using (var output = new StringWriter())
            {
                RenderHtml(output);
                return output.ToString();
            }
        }

        public virtual void VerifySettings()
        {
            if (!Name.Contains("<#=") && Name.IndexOf(" ") != -1)
            {
                throw new InvalidOperationException(Resources.Exceptions.NameCannotContainSpaces);
            }

            ((IHtmlAttributesContainer) this).ThrowIfClassIsPresent("k-" + GetType().Name.ToLowerInvariant() + "-rtl", Resources.Exceptions.Rtl);
        }

        /// <summary>
        /// Writes the initialization script.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public abstract void WriteInitializationScript(TextWriter writer);

        public virtual void ProcessSettings()
        {
        }

        protected virtual void RenderHtml(TextWriter writer)
        {
            ProcessSettings();
            WriteHtml(writer);
        }

        /// <summary>
        /// Writes the HTML.
        /// </summary>
        protected virtual void WriteHtml(TextWriter writer)
        {
            VerifySettings();

            if (IsSelfInitialized && !HasDeferredInitialization)
            {                
                writer.Write("<script>");
                WriteInitializationScript(writer);
                writer.Write("</script>");                
            }
        }

        public virtual void WriteDeferredScriptInitialization()
        {
            var scripts = new StringWriter();
            WriteInitializationScript(scripts);
            AppendScriptToContext(scripts.ToString());
        }

        private void Activate()
        {            
            Generator = GetService<IKendoHtmlGenerator>();
            HtmlHelper = GetService<IHtmlHelper>();
            HtmlEncoder = GetService<HtmlEncoder>();
            ModelMetadataProvider = GetService<IModelMetadataProvider>();
            UrlGenerator = GetService<IUrlGenerator>();

            ((IViewContextAware)HtmlHelper).Contextualize(ViewContext);

            if (Generator == null)
            {
                throw( new Exception("Kendo services are not registered. Please call services.AddKendo() in ConfigureServices method of your project."));
            }
        }

        protected TService GetService<TService>()
        {
            return ViewContext.GetService<TService>();
        }

        private void AppendScriptToContext(string script)
        {
            var items = ViewContext.HttpContext.Items;

            var scripts = new List<KeyValuePair<string,string>>();

            if (items.ContainsKey(DeferredScriptsKey))
            {
                scripts = (List<KeyValuePair<string, string>>)items[DeferredScriptsKey];
            }
            else
            {
                items[DeferredScriptsKey] = scripts;
            }

            scripts.Add(new KeyValuePair<string, string>(Name, script));
        }
    }
}
