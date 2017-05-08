using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<GanttColumn<TTaskModel, TDependenciesModel>>
    /// </summary>
    public partial class GanttColumnFactory<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttColumnFactory(List<GanttColumn<TTaskModel, TDependenciesModel>> container)
        {
            Container = container;
        }

        protected List<GanttColumn<TTaskModel, TDependenciesModel>> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Defines a bound column.
        /// </summary>
        public virtual GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> Bound<TValue>(Expression<Func<TTaskModel, TValue>> expression)
        {
            var column = new GanttBoundColumn<TTaskModel, TDependenciesModel, TValue>(expression, Gantt.ModelMetadataProvider);

            Container.Add(column);

            return new GanttBoundColumnBuilder<TTaskModel, TDependenciesModel>(column);
        }

        /// <summary>
        /// Defines a bound column.
        /// </summary>
        public virtual GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> Bound(string fieldName)
        {
            return Bound(null, fieldName);
        }

        /// <summary>
        /// Defines a bound column.
        /// </summary>
        public virtual GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> Bound(Type memberType, string fieldName)
        {
            const bool liftMemberAccess = false;

            var lambdaExpression = ExpressionBuilder.Lambda<TTaskModel>(memberType, fieldName, liftMemberAccess);

            if (typeof(TTaskModel).IsDynamicObject() && memberType != null && lambdaExpression.Body.Type.GetNonNullableType() != memberType.GetNonNullableType())
            {
                lambdaExpression = Expression.Lambda(Expression.Convert(lambdaExpression.Body, memberType), lambdaExpression.Parameters);
            }
            var columnType = typeof(GanttBoundColumn<,,>).MakeGenericType(new[] { typeof(TTaskModel), typeof(TDependenciesModel), lambdaExpression.Body.Type });

            var constructor = columnType.GetConstructor(new[] { lambdaExpression.GetType(), typeof(IModelMetadataProvider) });

            var column = (IGanttBoundColumn)constructor.Invoke(new object[] { lambdaExpression, Gantt.ModelMetadataProvider });

            column.Field = fieldName;

            if (!column.Title.HasValue())
            {
                column.Title = fieldName.AsTitle();
            }

            Container.Add((GanttColumn<TTaskModel, TDependenciesModel>)column);

            return new GanttBoundColumnBuilder<TTaskModel, TDependenciesModel>((GanttColumn<TTaskModel, TDependenciesModel>)column);
        }

        /// <summary>
        /// Defines a resource column.
        /// </summary>
        public virtual GanttResourceColumnBuilder<TTaskModel, TDependenciesModel> Resources(string fieldName)
        {
            var column = new GanttResourceColumn<TTaskModel, TDependenciesModel>(fieldName);

            Container.Add(column);

            return new GanttResourceColumnBuilder<TTaskModel, TDependenciesModel>(column);
        }
    }
}
