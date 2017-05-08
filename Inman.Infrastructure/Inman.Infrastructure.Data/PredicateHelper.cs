using Inman.Infrastructure.Data.DapperExtensions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace Inman.Infrastructure.Data
{
    public class PredicateHelper
    {
        public static PredicateGroup BuildPredicateGroup(params IPredicate[] predicates)
        {
            var pg = new PredicateGroup();
            pg.Predicates = new List<IPredicate>();
            if(predicates!= null && predicates.Length > 0)
                foreach (var predicate in predicates)
                    pg.Predicates.Add(predicate);
            return pg;
                
        }

        public static PredicateGroup BuildPredicateGroup(GroupOperator groupOperator)
        {
            var pg = BuildPredicateGroup();
            pg.Operator = groupOperator;
            return pg;
        }

        public static PredicateGroup BuildPredicateGroup(GroupOperator groupOperator, params IPredicate[] predicates)
        {
            var pg = BuildPredicateGroup(predicates);
            pg.Operator = groupOperator;
            return pg;
        }
        

        public static FieldPredicate<TEntity> BuildFieldPredicate<TEntity>(string propertyName,object value, Operator @operator,bool not = false) where TEntity:class
        {
            if (!typeof(TEntity).GetProperties().Any(p => p.Name == propertyName))
                return null;
            var fp = new FieldPredicate<TEntity>();
            fp.PropertyName = propertyName;
            fp.Value = value;
            fp.Operator = @operator;
            fp.Not = not;
            return fp;
        }

        public static BetweenPredicate<TEntity> BuildBetweenPredicate<TEntity>(string propertyName , BetweenValues value, bool not = false) where TEntity : class
        {
            if (!typeof(TEntity).GetType().GetProperties().Any(p => p.Name == propertyName))
                return null;
            var bp = new BetweenPredicate<TEntity>();
            bp.PropertyName = propertyName;
            bp.Value = value;
            bp.Not = not;
            return bp;
        }
    }
}
