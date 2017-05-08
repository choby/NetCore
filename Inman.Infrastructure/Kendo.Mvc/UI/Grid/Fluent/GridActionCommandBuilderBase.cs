namespace Kendo.Mvc.UI.Fluent
{

    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.Infrastructure;
    using System;

    /// <summary>
    /// Defines the fluent interface for configuring command.
    /// </summary>    
    /// <typeparam name="TCommand">The type of the command.</typeparam>
    /// <typeparam name="TBuilder">The type of the builder.</typeparam>
    public abstract class GridActionCommandBuilderBase<TCommand, TBuilder>  : IHideObjectMembers
        where TCommand : GridActionCommandBase
        where TBuilder : GridActionCommandBuilderBase<TCommand, TBuilder>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridActionCommandBuilderBase&lt; TColumn, TBuilder&gt;"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        public GridActionCommandBuilderBase(TCommand command)
        {
            Command = command;
        }

        /// <summary>
        /// Sets the text displayed by the command. If not set a default value is used.
        /// </summary>
        /// <param name="text">The text which should be displayed</param>
        /// <returns></returns>
        public TBuilder Text(string text)
        {
            Command.Text = text;

            return this as TBuilder;
        }

        /// <summary>
        /// Sets the HTML attributes.
        /// </summary>
        /// <param name="attributes">The HTML attributes.</param>
        /// <returns></returns>
        public TBuilder HtmlAttributes(object attributes)
        {
            return HtmlAttributes(attributes.ToDictionary());
        }

        /// <summary>
        /// Sets the HTML attributes.
        /// </summary>
        /// <param name="attributes">The HTML attributes.</param>
        /// <returns></returns>
        public TBuilder HtmlAttributes(IDictionary<string, object> attributes)
        {
            Command.HtmlAttributes.Merge(attributes);

            return this as TBuilder;
        }

        /// <summary>
        /// Sets the visible function which will determine if the command button will render.
        /// </summary>
        /// <param name="visible">The visible function.</param>
        /// <returns></returns>
        public TBuilder Visible(Func<object, object> handler)
        {
            Command.Visible.TemplateDelegate = handler;

            return this as TBuilder;
        }

        /// <summary>
        /// Sets the visible function which will determine if the command button will render.
        /// </summary>
        /// <param name="visible">The visible function.</param>
        /// <returns></returns>
        public TBuilder Visible(string handler)
        {
            Command.Visible.HandlerName = handler;

            return this as TBuilder;
        }

        protected TCommand Command
        {
            get;
            private set;
        }
    }
}
