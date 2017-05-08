namespace Kendo.Mvc.UI.Fluent
{
	using System.Collections.Generic;
	using Kendo.Mvc.Extensions;

	/// <summary>
	/// Defines the fluent interface for configuring toolbar command.
	/// </summary>
	/// <typeparam name="TModel">The type of the model</typeparam>
	/// <typeparam name="TCommand">The type of the command.</typeparam>
	/// <typeparam name="TBuilder">The type of the builder.</typeparam>
	public abstract class GridToolBarCommandBuilderBase<TCommand, TBuilder> : IHideObjectMembers        
        where TCommand : GridActionCommandBase
        where TBuilder : GridToolBarCommandBuilderBase<TCommand, TBuilder>
    {
        protected GridToolBarCommandBuilderBase(TCommand command)
        {
            Command = command;
        }
    
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

        protected TCommand Command
        {
            get;
            private set;
        }
    }
}