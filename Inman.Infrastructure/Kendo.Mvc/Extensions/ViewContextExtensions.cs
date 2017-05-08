using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Kendo.Mvc.Extensions
{
    public static class ViewContextExtensions
    {
		public static T GetService<T>(this ViewContext viewContext)
		{
			return viewContext.HttpContext.GetService<T>();
		}

		public static T GetService<T>(this HttpContext context)
		{
			return (T)context.RequestServices.GetService(typeof(T));
		}

		public static ViewContext ViewContextForType<T>(this ViewContext viewContext, IModelMetadataProvider metadataProvider)
		{
			var actionContext = new ActionContext(viewContext.HttpContext, new RouteData(), new ActionDescriptor());
			var viewDataDictionary = new ViewDataDictionary<T>(viewContext.ViewData, null);
            var tempDataFactory = viewContext.GetService<ITempDataDictionaryFactory>();
            var tempDataDictionary = tempDataFactory.GetTempData(viewContext.HttpContext);
            var options = new HtmlHelperOptions
            {
                ClientValidationEnabled = viewContext.ClientValidationEnabled,
                Html5DateRenderingMode = viewContext.Html5DateRenderingMode,
                ValidationSummaryMessageElement = viewContext.ValidationSummaryMessageElement,
                ValidationMessageElement = viewContext.ValidationMessageElement
            };

            return new ViewContext(actionContext, viewContext.View, viewDataDictionary, tempDataDictionary, new StringWriter(), options);
		}

		public static HtmlHelper<T> CreateHtmlHelper<T>(this ViewContext viewContext)
		{
			return new HtmlHelper<T>(
                viewContext.GetService<IHtmlGenerator>(),
                viewContext.GetService<ICompositeViewEngine>(),
                viewContext.GetService<IModelMetadataProvider>(),
                viewContext.GetService<IViewBufferScope>(),
                viewContext.GetService<HtmlEncoder>(),
                viewContext.GetService<UrlEncoder>(),
                new ExpressionTextCache()
            );
		}
        public static string GetFullHtmlFieldName(this ViewContext viewContext, string name)
        {
            return viewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(name);
        }
    }
}