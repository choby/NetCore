using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DropDownList
    /// </summary>
    public partial class DropDownListBuilder: WidgetBuilderBase<DropDownList, DropDownListBuilder>
        
    {
        public DropDownListBuilder(DropDownList component) : base(component)
        {
        }

        /// <summary>
        /// Use to enable or disable animation of the popup element.
        /// </summary>
        /// <param name="enable">The boolean value.</param>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().DropDownList()
        ///	           .Name("DropDownList")
        ///	           .Animation(false) //toggle effect
        ///	%&gt;
        /// </code>
        /// </example>
        public DropDownListBuilder Animation(bool enable)
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
        /// &lt;%= Html.Kendo().DropDownList()
        ///	           .Name("DropDownList")
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
        public DropDownListBuilder Animation(Action<PopupAnimationBuilder> animationAction)
        {
            animationAction(new PopupAnimationBuilder(Component.Animation));

            return this;
        }

        /// <summary>
        /// Binds the DropDownList to an IEnumerable list.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
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
        public DropDownListBuilder BindTo(IEnumerable data)
        {
            Component.DataSource.Data = data;

            return this;
        }

        /// <summary>
        /// Binds the DropDownList to a list of SelectListItem.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
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
        public DropDownListBuilder BindTo(IEnumerable<SelectListItem> dataSource)
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
                Component.Value = dataSource.SelectedValue();
            }

            return this;
        }

        /// <summary>
        /// Defines the items in the DropDownList
        /// </summary>
        /// <param name="addAction">The add action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .Items(items =>
        ///             {
        ///                 items.Add().Text("First Item");
        ///                 items.Add().Text("Second Item");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public DropDownListBuilder Items(Action<SelectListItemFactory> addAction)
        {
            var items = new List<SelectListItem>();

            addAction(new SelectListItemFactory(items));

            return BindTo(items);
        }

        /// <summary>
        /// Sets the data source configuration of the DropDownList.
        /// </summary>
        /// <param name="configurator">The lambda which configures the data source</param>
        public DropDownListBuilder DataSource(Action<ReadOnlyDataSourceBuilder> configurator)
        {
            configurator(new ReadOnlyDataSourceBuilder(Component.DataSource, Component.ViewContext, Component.UrlGenerator));

            return this;
        }

        /// <summary>
        /// The filtering method used to determine the suggestions for the current value. Filtration is turned off by default.
		/// The supported filter values are startswith, endswith and contains.
        /// </summary>
        /// <param name="value">The value for Filter</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public DropDownListBuilder Filter(string value)
        {
            Container.Filter = (FilterType)Enum.Parse(typeof(FilterType), value, true);
            return this;
        }

        /// <summary>
        /// Use it to set selected item index
        /// </summary>
        /// <param name="index">Item index.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().DropDownList()
        ///             .Name("DropDownList")
        ///             .SelectedIndex(0);
        /// %&gt;
        /// </code>
        /// </example>
        public DropDownListBuilder SelectedIndex(int value)
        {
            Container.SelectedIndex = value;
            return this;
        }
    }
}

