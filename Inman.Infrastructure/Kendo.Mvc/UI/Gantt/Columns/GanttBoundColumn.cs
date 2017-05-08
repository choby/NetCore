using System;
using System.Linq.Expressions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Kendo.Mvc.UI
{
    public class GanttBoundColumn<TTaskModel, TDependenciesModel, ТValue> : GanttColumn<TTaskModel, TDependenciesModel>, IGanttBoundColumn
        where TTaskModel : class, IGanttTask where TDependenciesModel : class, IGanttDependency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GanttBoundColumn{TTaskModel, TValue}"/> class.
        /// </summary>
        /// <param name="Gantt"></param>
        /// <param name="expression"></param>
        public GanttBoundColumn(Expression<Func<TTaskModel, ТValue>> expression, IModelMetadataProvider modelMetadataProvider)
            : base()
        {
            if (typeof(TTaskModel).IsPlainType() && !expression.IsBindable())
            {
                throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
            }

            Field = expression.MemberWithoutInstance();

            if (typeof(TTaskModel).IsPlainType())
            {
                var viewDataDictionary = new ViewDataDictionary<TTaskModel>(modelMetadataProvider, new ModelStateDictionary());
                var metadata = ExpressionMetadataProvider.FromLambdaExpression(expression, viewDataDictionary, modelMetadataProvider).Metadata;

                Title = metadata.DisplayName;
                Format = metadata.DisplayFormatString;
            }

            if (string.IsNullOrEmpty(Title))
            {
                Title = Field.AsTitle();
            }

            if (typeof(IGanttTask).GetProperty(Field) != null)
            {
                Field = Field.ToCamelCase();
            }
        }
    }
}