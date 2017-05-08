using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Button
    /// </summary>
    public partial class ButtonBuilder: WidgetBuilderBase<Button, ButtonBuilder>
        
    {
        public ButtonBuilder(Button component) : base(component)
        {
        }

		/// <summary>
		/// Sets the HTML content of the Button.
		/// </summary>
		/// <param name="content">The action which renders the HTML content.</param>
		/// <code lang="CS">
		///  &lt;%  Html.Kendo().Button()
		///             .Name("Button1")
		///             .Content(() =&gt; { &gt;%
		///                   &lt;p&gt;Content&lt;/p&gt;
		///              %&lt;})
		///             .Render();
		/// %&gt;
		/// </code>        
		public ButtonBuilder Content(Action content)
		{
			Component.ContentAction = content;

			return this;
		}

		/// <summary>
		/// Sets the HTML content of the Button.
		/// </summary>
		/// <param name="content">The Razor template for the HTML content.</param>
		/// <code lang="CS">
		///  @(Html.Kendo().Button()
		///        .Name("Button1")
		///        .Content(@&lt;p&gt;Content&lt;/p&gt;)
		///        .Render();)
		/// </code>        
		public ButtonBuilder Content(Func<object, object> content)
		{
			Component.Content = content;

			return this;
		}

		/// <summary>
		/// Sets the HTML content of the Button.
		/// </summary>
		/// <param name="content">The HTML content.</param>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Button()
		///          .Name("Button")
		///           .Content("&lt;p&gt;Content&lt;/p&gt;")
		/// %&gt;
		/// </code>        
		public ButtonBuilder Content(string content)
		{
			Component.Html = content;

			return this;
		}

		/// <summary>Sets the Button HTML tag. A button tag is used by default.</summary>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().Button()
		///            .Name("Button")
		///            .Tag("span")
		/// %&gt;
		/// </code>
		/// </example>
		public ButtonBuilder Tag(string tag)
		{
			Component.Tag = tag;

			return this;
		}
	}
}

