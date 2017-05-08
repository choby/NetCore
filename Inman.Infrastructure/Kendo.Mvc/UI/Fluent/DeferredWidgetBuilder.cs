using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Html;
using System.Text.Encodings.Web;
using System.IO;
using System.Threading.Tasks;

namespace Kendo.Mvc.UI.Fluent
{
    public class DeferredWidgetBuilder<TViewComponent> : HelperResult
        where TViewComponent : WidgetBase
    {
        /// <summary>
        /// Gets the view component.
        /// </summary>
        /// <value>The component.</value>
        protected internal TViewComponent Component
        {
            get;
            set;
        }

        public DeferredWidgetBuilder(TViewComponent component) : base(async (writer) => await Task.Yield())
        {
            Component = component;
        }

        /// <summary>
        /// Returns the internal view component.
        /// </summary>
        /// <returns></returns>
        public TViewComponent ToComponent()
        {
            return Component;
        }

        /// <summary>
        /// Renders the component in place.
        /// </summary>
        public virtual void Render()
        {
            Component.Render();
        }

        public virtual string ToHtmlString()
        {
            return ToComponent().ToHtmlString();
        }

        public override void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            writer.Write(ToHtmlString());
        }

        public virtual HtmlString ToClientTemplate()
        {
            return ToComponent().ToClientTemplate();
        }
    }   
}
