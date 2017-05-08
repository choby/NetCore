namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Extensions;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;
    public class GridColumnGenerator<T> where T : class
    {
        private readonly Grid<T> grid;

        public GridColumnGenerator(Grid<T> grid)
        {
            this.grid = grid;
        }

        public IEnumerable<GridColumnBase<T>> GetColumns()
        {
            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                .Where(property => property.CanRead && property.GetGetMethod().GetParameters().Length == 0)
                                .Where(property => property.PropertyType.IsEnumType() || (property.PropertyType != typeof(object) && property.PropertyType.IsPredefinedType())
                                    || (property.PropertyType.IsNullableType() && property.PropertyType.GetNonNullableType().IsPredefinedType()));

			var modelMetadataProvider = grid.ModelMetadataProvider;
            var viewDataDictionary = new ViewDataDictionary<T>(modelMetadataProvider, new ModelStateDictionary());

			properties = properties.Select(property => new {
                                       Order = ExpressionMetadataProvider.FromStringExpression(property.Name, viewDataDictionary, modelMetadataProvider).Metadata.Order,
                                       Property = property
                                    })
                                    .OrderBy(property => property.Order)
                                    .Select(property => property.Property);

            return properties.Select(property => CreateBoundColumn(property));
        }

        public GridColumnBase<T> CreateBoundColumn(string memberName, Type memberType)
        {
            bool liftMemberAccess = false;

            if (grid.DataSource.Data != null)
            {
                liftMemberAccess = grid.DataSource.Data.AsQueryable().Provider.IsLinqToObjectsProvider();
            }

            LambdaExpression lambdaExpression = ExpressionBuilder.Lambda<T>(memberType, memberName, liftMemberAccess);

            Type columnType = typeof(GridBoundColumn<,>).MakeGenericType(new[] { typeof(T), lambdaExpression.Body.Type });

            ConstructorInfo constructor = columnType.GetConstructor(new[] { grid.GetType(), lambdaExpression.GetType() });

            IGridBoundColumn column = (IGridBoundColumn)constructor.Invoke(new object[] { grid, lambdaExpression });

            column.Member = memberName;
            column.Title = memberName.AsTitle();

            if (memberType != null)
            {
                column.MemberType = memberType;
            }
            return (GridColumnBase<T>)column;
        }

        public GridColumnBase<T> CreateBoundColumn(PropertyInfo property)
        {
            Type columnType = typeof(GridBoundColumn<,>).MakeGenericType(new[] { typeof(T), property.PropertyType });
            Type funcType = typeof(Func<,>).MakeGenericType(new[] { typeof(T), property.PropertyType });
            Type expressionType = typeof(Expression<>).MakeGenericType(new[] { funcType });

            ParameterExpression parameterExpression = Expression.Parameter(typeof(T), "x");

            Expression propertyExpression = Expression.Property(parameterExpression, property);
            
            Expression expression = Expression.Lambda(funcType, propertyExpression, parameterExpression);

            return (GridColumnBase<T>)columnType.GetConstructor(new[] { grid.GetType(), expressionType }).Invoke(new object[] { grid, expression });
        }
        
        public GridColumnBase<T> CreateColumn(GridColumnSettings settings)
        {			
			var commandSettings = settings as GridCommandColumnSettings;
			if (commandSettings != null)
			{
				var column = new GridActionColumn<T>(grid);

				column.Settings = settings;

				foreach (var command in commandSettings.Commands)
				{	
					grid.Editable.Enabled = true;					
					column.Commands.Add(command);
				}

				if (settings.ClientHeaderTemplate.HasValue())
				{					
					column.ClientHeaderTemplate = settings.ClientHeaderTemplate;
				}

				return column;

			}
			return CreateBoundColumn(settings);
        }
        
        private GridColumnBase<T> CreateBoundColumn(GridColumnSettings settings)
        {
            var memberType = settings.MemberType;

            var lambdaExpression = ExpressionBuilder.Lambda<T>(memberType, settings.Member, false);

            var columnType = typeof(GridBoundColumn<,>).MakeGenericType(new[] { typeof(T), lambdaExpression.Body.Type });

            var constructor = columnType.GetConstructor(new[] { grid.GetType(), lambdaExpression.GetType() });

            var column = (GridColumnBase<T>)constructor.Invoke(new object[] { grid, lambdaExpression });

            if (memberType != null)
            {
                (column as IGridBoundColumn).MemberType = memberType;
            }

            column.Settings = settings;

            return column;
        }
    }
}