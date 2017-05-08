namespace Kendo.Mvc.UI.Fluent
{
    using Infrastructure;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="Window.Actions"/>.
    /// </summary>
    public class WindowActionsBuilder
    {
        private readonly IWindowButtonsContainer container;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowActionsBuilder"/> class.
        /// </summary>
        /// <param name="container">The <see cref="IWindowButton" /> instance that is to be configured</param>
        public WindowActionsBuilder(IWindowButtonsContainer container)
        {

            this.container = container;
        }

        /// <summary>
        /// Configures the window to show a close button.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Window()
        ///             .Name("Window")
        ///             .Actions(actions => actions.Close())
        /// %&gt;
        /// </code>
        /// </example>
        public WindowActionsBuilder Close()
        {
            return AddButton("Close", "k-i-close");
        }

        /// <summary>
        /// Configures the window to show a maximize button.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Window()
        ///             .Name("Window")
        ///             .Actions(actions => actions.Maximize())
        /// %&gt;
        /// </code>
        /// </example>
        public WindowActionsBuilder Maximize()
        {
            return AddButton("Maximize", "k-i-maximize");
        }

        /// <summary>
        /// Configures the window to show a minimize button.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Window()
        ///             .Name("Window")
        ///             .Actions(actions => actions.Maximize())
        /// %&gt;
        /// </code>
        /// </example>
        public WindowActionsBuilder Minimize()
        {
            return AddButton("Minimize", "k-i-minimize");
        }

        /// <summary>
        /// Configures the window to show a refresh button.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Window()
        ///             .Name("Window")
        ///             .Actions(actions => actions.Refresh())
        /// %&gt;
        /// </code>
        /// </example>
        public WindowActionsBuilder Refresh()
        {
            return AddButton("Refresh", "k-i-refresh");
        }

        /// <summary>
        /// Configures the window to show a pin button.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Window()
        ///             .Name("Window")
        ///             .Actions(actions => actions.Pin())
        /// %&gt;
        /// </code>
        /// </example>
        public WindowActionsBuilder Pin()
        {
            return AddButton("Pin", "k-i-pin");
        }

        /// <summary>
        /// Configures the window to show a refresh button.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Window()
        ///             .Name("Window")
        ///             .Actions(actions => actions.Custom("menu"))
        /// %&gt;
        /// </code>
        /// </example>
        public WindowActionsBuilder Custom(string actionName)
        {
            return AddButton(actionName, "k-i-custom");
        }

        /// <summary>
        /// Configures the window to show no buttons in its titlebar.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Window()
        ///             .Name("Window")
        ///             .Actions(actions => actions.Clear())
        /// %&gt;
        /// </code>
        /// </example>
        public WindowActionsBuilder Clear()
        {
            return ClearButtons();
        }

        private WindowActionsBuilder AddButton(string name, string cssClass)
        {
            container.Container.Add(new HeaderButton { Name = name, CssClass = cssClass });

            return this;
        }

        private WindowActionsBuilder ClearButtons()
        {
            container.Container.Clear();

            return this;
        }
    }
}
