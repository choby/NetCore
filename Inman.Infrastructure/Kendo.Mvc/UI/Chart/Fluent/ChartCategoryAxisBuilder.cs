using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxis
    /// </summary>
    public partial class ChartCategoryAxisBuilder<T>
        where T : class
    {
        public ChartCategoryAxisBuilder(ChartCategoryAxis<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxis<T> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the axis type to date.
        /// </summary>
        public ChartCategoryAxisBuilder<T> Date()
        {
            Container.Type = ChartCategoryAxisType.Date;
            return this;
        }

        /// <summary>
        /// Defines bound categories.
        /// </summary>
        /// <param name="expression">
        /// The expression used to extract the categories value from the chart model.
        /// </param>
        public ChartCategoryAxisBuilder<T> Categories<TValue>(Expression<Func<T, TValue>> expression)
        {
            if (typeof(T).IsPlainType() && !expression.IsBindable())
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            Container.Field = expression.MemberWithoutInstance();

            return this;
        }

        /// <summary>
        /// Defines categories.
        /// </summary>
        /// <param name="categories">
        /// The list of categories
        /// </param>
        public ChartCategoryAxisBuilder<T> Categories(params string[] categories)
        {
            Container.Categories = categories;

            return this;
        }
        
        /// <summary>
        /// Sets the selection range.
        /// </summary>
        public ChartCategoryAxisBuilder<T> Select(object from, object to)
        {
            Container.Select.From = from;
            Container.Select.To = to;

            return this;
        }

        /// <summary>
        /// Sets the axis title.
        /// </summary>
        /// </example>
        public ChartCategoryAxisBuilder<T> Title(string value)
        {
            Container.Title.Text = value;

            return this;
        }
    }
}
