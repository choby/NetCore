using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Sortable
    /// </summary>
    public partial class SortableBuilder: WidgetBuilderBase<Sortable, SortableBuilder>
        
    {
        public SortableBuilder(Sortable component) : base(component)
        {
        }

        /// <summary>
        /// The selector to match the DOM element to which the Sortable widget will be instantiated
        /// </summary>
        /// <param name="selector">jQuery selector</param>
        /// <returns></returns>
        public virtual SortableBuilder For(string selector)
        {
            Component.SortableContainer = selector;
            Component.Name = selector;

            return this;
        }

        /// <summary>
        /// Selector that determines the container boundaries in which hint movement will be constrained to.
        /// </summary>
        /// <param name="selector">jQuery selector</param>
        /// <returns></returns>
        public virtual SortableBuilder ContainerSelector(string selector)
        {
            Component.ContainerSelector = selector;

            return this;
        }

        /// <summary>
        /// Sets JavaScript function which to return the hint for the sorted item.
        /// </summary>                
        public virtual SortableBuilder HintHandler(Func<object, object> handler)
        {
            Container.HintHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };

            return this;
        }

        /// <summary>
        /// Sets JavaScript function which to return the hint for the sorted item.
        /// </summary>
        /// <param name="handler">JavaScript function name</param>        
        public virtual SortableBuilder HintHandler(string handler)
        {
            Container.HintHandler = new ClientHandlerDescriptor { HandlerName = handler };

            return this;
        }

        /// <summary>
        /// HTML string representing the the hint element
        /// </summary>
        /// <param name="string">Html string</param>
        /// <returns></returns>
        public virtual SortableBuilder Hint(string content)
        {
            Container.Hint = content;

            return this;
        }

        /// <summary>
        /// Sets JavaScript function which to return the placeholder for the sorted item.
        /// </summary>                
        public virtual SortableBuilder PlaceholderHandler(Func<object, object> handler)
        {
            Container.PlaceholderHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };

            return this;
        }

        /// <summary>
        /// Sets JavaScript function which to return the placeholder for the sorted item.
        /// </summary>
        /// <param name="handler">JavaScript function name</param>        
        public virtual SortableBuilder PlaceholderHandler(string handler)
        {
            Container.PlaceholderHandler = new ClientHandlerDescriptor { HandlerName = handler };

            return this;
        }

        /// <summary>
        /// HTML string representing the placeholder
        /// </summary>
        /// <param name="string">Html string</param>
        /// <returns></returns>
        public virtual SortableBuilder Placeholder(string content)
        {
            Container.Placeholder = content;

            return this;
        }
    }
}

