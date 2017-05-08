namespace Kendo.Mvc.UI.Fluent
{
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.Resources;
    using System;
    using System.Linq.Expressions;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
    /// <summary>
    /// Creates resources for the <see cref="Scheduler{TModel}" /> class.
    /// </summary>
    public class SchedulerResourceFactory<T> : IHideObjectMembers
        where T : class, ISchedulerEvent
    {
        private readonly Scheduler<T> container;

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerResourceFactory{TModel}"/> class.
        /// </summary>
        /// <param name="container">The container</param>
        public SchedulerResourceFactory(Scheduler<T> container)
        {
            this.container = container;
        }

        /// <summary>
        /// Defines a Scheduler resource.
        /// </summary>
        public SchedulerResourceBuilder<T> Add<TValue>(Expression<Func<T, TValue>> expression)
        {
            //TODO: Refactor and add validation for fields
            if (!typeof(T).IsPlainType() && !expression.IsBindable())
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            string memberName = ExpressionHelper.GetExpressionText(expression);

            SchedulerResource<T> resource = new SchedulerResource<T>(memberName, container.ModelMetadataProvider);

            container.Resources.Add(resource);

            return new SchedulerResourceBuilder<T>(resource, container.ViewContext, container.UrlGenerator);
        }
    }
}
