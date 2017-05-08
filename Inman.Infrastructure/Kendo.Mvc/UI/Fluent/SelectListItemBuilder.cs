using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring child DropDownList items.
    /// </summary>
    public class SelectListItemBuilder : IHideObjectMembers
    {
        private readonly SelectListItem item;

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectListItemBuilder"/> class.
        /// </summary>
        /// <param name="item">The item.</param>
        public SelectListItemBuilder(SelectListItem item)
        {
            this.item = item;
        }

        /// <summary>
        /// Sets the value for the item.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .Items(items => items.Add().Text("First item."))
        /// %&gt;
        /// </code>
        /// </example>
        public SelectListItemBuilder Text(string value)
        {
            item.Text = value;

            return this;
        }

        /// <summary>
        /// Sets the value for the item.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .Items(items => items.Add().Value("1"))
        /// %&gt;
        /// </code>
        /// </example>
        public SelectListItemBuilder Value(string value)
        {
            item.Value = value;

            return this;
        }

        /// <summary>
        /// Define when the item will be selected on intial render.
        /// </summary>
        /// <param name="value">If true the item will be selected.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .Items(items => items.Add().Text("First Item").Selected(true))
        /// %&gt;
        /// </code>
        /// </example>
        public SelectListItemBuilder Selected(bool value)
        {
            item.Selected = value;

            return this;
        }
    }
}
