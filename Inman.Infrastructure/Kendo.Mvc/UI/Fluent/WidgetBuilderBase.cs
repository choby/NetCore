using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Kendo.Mvc.UI.Fluent
{
    public class WidgetBuilderBase<TViewComponent, TBuilder> : HelperResult
        where TViewComponent : WidgetBase
        where TBuilder : WidgetBuilderBase<TViewComponent, TBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the WidgetBuilderBase class.
        /// </summary>
        /// <param name="component">The component.</param>
        public WidgetBuilderBase(TViewComponent component) : base(async (writer) => await Task.Yield())
        {
            Component = component;
        }

        /// <summary>
        /// Gets the view component.
        /// </summary>
        /// <value>The component.</value>
        protected internal TViewComponent Component
        {
            get;
            set;
        }

        /// <summary>
        /// Alias for the component as used from settings builder
        /// </summary>
        /// <value>The settings container.</value>
        protected internal TViewComponent Container
        {
            get
            {
                return Component;
            }
        }

        private bool HasModelExpression { get; set; } = false;

        public static implicit operator TViewComponent(WidgetBuilderBase<TViewComponent, TBuilder> builder)
        {
            return builder.ToComponent();
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
        /// Sets the name of the component.
        /// </summary>
        /// <param name="componentName">The name.</param>
        /// <returns></returns>
        public virtual TBuilder Expression(string modelExpression)
        {
            Component.Name = modelExpression;
            HasModelExpression = true;

            return this as TBuilder;
        }

        /// <summary>
        /// Sets the name of the component.
        /// </summary>
        /// <param name="componentName">The name.</param>
        /// <returns></returns>
        public virtual TBuilder Name(string componentName)
        {
            if (HasModelExpression)
            {
                throw new InvalidOperationException(Exceptions.YouCannotOverrideModelExpressionName);
            }

            Component.Name = componentName;

            return this as TBuilder;
        }

        /// <summary>
        /// Suppress initialization script rendering. Note that this options should be used in conjunction with <see cref="WidgetFactory.DeferredScripts"/>
        /// </summary>        
        /// <returns></returns>
        public virtual DeferredWidgetBuilder<TViewComponent> Deferred(bool deferred = true)
        {
            Component.HasDeferredInitialization = deferred;

            if (Component.HasDeferredInitialization)
            {
                Component.ProcessSettings();
                Component.WriteDeferredScriptInitialization();
            }

            return new DeferredWidgetBuilder<TViewComponent>(Component);
        }

        /// <summary>
        /// Sets the HTML attributes.
        /// </summary>
        /// <param name="attributes">The HTML attributes.</param>
        /// <returns></returns>
        public virtual TBuilder HtmlAttributes(object attributes)
        {
            IDictionary<string, object> htmlAttributeDictionary = null;
            if (attributes != null)
            {
                htmlAttributeDictionary = attributes as IDictionary<string, object>;
                if (htmlAttributeDictionary == null)
                {
                    htmlAttributeDictionary = HtmlHelper.AnonymousObjectToHtmlAttributes(attributes);
                }
            }

            Component.HtmlAttributes = htmlAttributeDictionary;

            return this as TBuilder;
        }

        /// <summary>
        /// Sets the HTML attributes.
        /// </summary>
        /// <param name="attributes">The HTML attributes.</param>
        /// <returns></returns>
        public virtual TBuilder HtmlAttributes(IDictionary<string, object> attributes)
        {
            Component.HtmlAttributes = attributes;

            return this as TBuilder;
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
