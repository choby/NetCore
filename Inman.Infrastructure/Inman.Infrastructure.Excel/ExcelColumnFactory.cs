using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using Kendo.Mvc;
using Kendo.Mvc.Extensions;

namespace Inman.Infrastructure.Excel
{
    public class ExcelColumnFactory<TModel>
    {
        public Excel<TModel> Container
        {
            get;
            private set;
        }

        public ExcelColumnFactory(Excel<TModel> container)
        {
            this.Container = container;
        }

        public virtual ExcelBoundColumnBuilder<TModel> Bound<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            ExcelBoundColumn<TModel, TValue> boundColumn = new ExcelBoundColumn<TModel, TValue>(this.Container, expression);
            this.Container.Columns.Add(boundColumn);
            return new ExcelBoundColumnBuilder<TModel>(boundColumn);
        }

        public virtual ExcelBoundColumnBuilder<TModel> Bound(string memberName)
        {
            return Bound(null, memberName);
        }

        /// <summary>
        /// Defines a bound column.
        /// </summary>
        public virtual ExcelBoundColumnBuilder<TModel> Bound(Type memberType, string memberName)
        {
            const bool liftMemberAccess = false;

            var lambdaExpression = ExpressionBuilder.Lambda<TModel>(memberType, memberName, liftMemberAccess);

            if (typeof(TModel).IsDynamicObject() && memberType != null && lambdaExpression.Body.Type.GetNonNullableType() != memberType.GetNonNullableType())
            {
                lambdaExpression = Expression.Lambda(Expression.Convert(lambdaExpression.Body, memberType), lambdaExpression.Parameters);
            }
            var columnType = typeof(ExcelBoundColumn<,>).MakeGenericType(new[] { typeof(TModel), lambdaExpression.Body.Type });

            var constructor = columnType.GetConstructor(new[] { Container.GetType(), lambdaExpression.GetType() });

            var column = (ExcelColumnBase<TModel>)constructor.Invoke(new object[] { Container, lambdaExpression });

            column.Member = memberName;

            if (!column.Title.HasValue())
            {
                column.Title = memberName.AsTitle();
            }

            if (memberType != null)
            {
                column.MemberType = memberType;
            }

            this.Container.Columns.Add(column);

            return new ExcelBoundColumnBuilder<TModel>(column);
          
        }

        public virtual ExcelBoundColumnBuilder<TModel> BoundPicture<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            ExcelBoundColumn<TModel, TValue> boundColumn = new ExcelBoundColumn<TModel, TValue>(this.Container, expression);
            
            //boundColumn.Metadata.Description = "Image";
            this.Container.Columns.Add(boundColumn);
            return new ExcelBoundColumnBuilder<TModel>(boundColumn);
        }
    }

  
}
