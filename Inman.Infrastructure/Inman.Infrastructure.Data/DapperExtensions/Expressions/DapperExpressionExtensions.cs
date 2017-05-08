using Inman.Infrastructure.Data.DapperExtensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Inman.Infrastructure.Data.DapperExtensions.Expressions
{
    public static class DapperExpressionExtensions
    {
        public static IPredicate ToPredicateGroup<TEntity, TPrimaryKey>(this Expression<Func<TEntity, bool>> expression) where TEntity : class, IEntity<TPrimaryKey>
        {
            //Check.NotNull(expression, nameof(expression));

            var dev = new DapperExpressionVisitor<TEntity, TPrimaryKey>();
            IPredicate pg = dev.Process(expression);

            return pg;
        }
    }
}
