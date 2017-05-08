using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI MultiSelect
    /// </summary>
    public partial class MultiSelectBuilder: WidgetBuilderBase<MultiSelect, MultiSelectBuilder>
        
    {
        public MultiSelectBuilder(MultiSelect component) : base(component)
        {
        }

        /// <summary>
        /// Use to enable or disable animation of the popup element.
        /// </summary>
        /// <param name="enable">The boolean value.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().MultiSelect()
        ///	           .Name("MultiSelect")
        ///	           .Animation(false) //toggle effect
        ///	%&gt;
        /// </code>
        /// </example>
        public MultiSelectBuilder Animation(bool enable)
        {
            Component.Animation.Enabled = enable;

            return this;
        }

        /// <summary>
        /// Configures the animation effects of the widget.
        /// </summary>
        /// <param name="animationAction">The action which configures the animation effects.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().MultiSelect()
        ///	           .Name("MultiSelect")
        ///	           .Animation(animation =>
        ///	           {
        ///		            animation.Open(open =>
        ///		            {
        ///		                open.SlideIn(SlideDirection.Down);
        ///		            }
        ///	           })
        ///	%&gt;
        /// </code>
        /// </example>
        public MultiSelectBuilder Animation(Action<PopupAnimationBuilder> animationAction)
        {
            animationAction(new PopupAnimationBuilder(Component.Animation));

            return this;
        }

        /// <summary>
        /// Binds the MultiSelect to an IEnumerable list.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().MultiSelect()
        ///             .Name("MultiSelect")
        ///             .DataTextField("CompanyName")
        ///             .DataValueField("CompanyID")
        ///             .BindTo(new List<Company>
        ///             {
        ///                 new Company {
        ///                     CompanyName = "Text1",
        ///                     CompanyID = "Value1"
        ///                 },
        ///                 new Company {
        ///                     CompanyName = "Text2",
        ///                     CompanyID = "Value2"
        ///                 }
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public MultiSelectBuilder BindTo(IEnumerable data)
        {
            Component.DataSource.Data = data;

            return this;
        }

        /// <summary>
        /// Binds the MultiSelect to a list of SelectListItem.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().MultiSelect()
        ///             .Name("MultiSelect")
        ///             .BindTo(new List<SelectListItem>
        ///             {
        ///                 new SelectListItem{
        ///                     Text = "Text1",
        ///                     Value = "Value1"
        ///                 },
        ///                 new SelectListItem{
        ///                     Text = "Text2",
        ///                     Value = "Value2"
        ///                 }
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public MultiSelectBuilder BindTo(IEnumerable<SelectListItem> dataSource)
        {
            if (string.IsNullOrEmpty(Component.DataValueField)
                && string.IsNullOrEmpty(Component.DataTextField))
            {
                DataValueField("Value");
                DataTextField("Text");
            }

            Component.DataSource.Data = dataSource
                .Select(item => new {
                    Text = item.Text,
                    Value = item.Value ?? item.Text,
                    Selected = item.Selected
                });

            if (Component.Value == null)
            {
                Component.Value = dataSource
                    .Where(item => item.Selected == true)
                    .Select(item => item.Value ?? item.Text);
            }

            return this;
        }

        /// <summary>
        /// Defines the items in the MultiSelect
        /// </summary>
        /// <param name="addAction">The add action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().MultiSelect()
        ///             .Name("MultiSelect")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item");
        ///                 items.Add().Text("Second Item");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public MultiSelectBuilder Items(Action<SelectListItemFactory> addAction)
        {
            var items = new List<SelectListItem>();

            addAction(new SelectListItemFactory(items));

            return BindTo(items);
        }

        /// <summary>
        /// Sets the data source configuration of the MultiSelect.
        /// </summary>
        /// <param name="configurator">The lambda which configures the data source</param>
        public MultiSelectBuilder DataSource(Action<ReadOnlyDataSourceBuilder> configurator)
        {
            configurator(new ReadOnlyDataSourceBuilder(Component.DataSource, Component.ViewContext, Component.UrlGenerator));

            return this;
        }

        /// <summary>
        /// Use it to enable filtering of items.
        /// The supported filter values are startswith, endswith and contains.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public MultiSelectBuilder Filter(string value)
        {
            Container.Filter = (FilterType)Enum.Parse(typeof(FilterType), value, true);

            return this;
        }

        /// <summary>
        /// Sets the value of the widget.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().MultiSelect()
        ///             .Name("MultiSelect")
        ///             .Value(new string[] { "1" })
        /// %&gt;
        /// </code>
        /// </example>
        public MultiSelectBuilder Value(IEnumerable value)
        {
            Component.Value = value;

            return this;
        }
    }
}

