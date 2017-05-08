using Inman.Infrastructure.Data;
using Inman.Infrastructure.Data.DapperExtensions;
using System;
using System.Collections.Generic;
using System.Text;
using Kendo.Mvc.Infrastructure;
using Kendo.Mvc;

namespace Inman.Infrastructure.Data
{
    public class KendoPredicateFactory
    {
        public static IPredicate ResolveFilter<TEntity>(string filter) where TEntity : class
        {
           
            var fpDeleted = PredicateHelper.BuildFieldPredicate<TEntity>("Deleted", "0", Operator.Eq);
            IPredicate predicate = PredicateHelper.BuildPredicateGroup(GroupOperator.And, fpDeleted);

            if (!string.IsNullOrEmpty(filter))
            {
                var filterDescriptors = FilterDescriptorFactory.Create(filter);
                foreach (var descriptor in filterDescriptors)
                {
                    MiningDescriptor<TEntity>(predicate, descriptor);
                }
            }
            else
                predicate = fpDeleted;

            return predicate;
        }

        private static void MiningDescriptor<TEntity>(IPredicate predicate, IFilterDescriptor descriptor) where TEntity : class
        {

            if (descriptor is CompositeFilterDescriptor)
            {
                var composite = descriptor as CompositeFilterDescriptor;
                GroupOperator @operator;
                if (composite.LogicalOperator == FilterCompositionLogicalOperator.And)
                    @operator = GroupOperator.And;
                else
                    @operator = GroupOperator.Or;
                var group = PredicateHelper.BuildPredicateGroup(@operator);
                (predicate as PredicateGroup).Predicates.Add(group);
                foreach (var item in composite.FilterDescriptors)
                {
                    MiningDescriptor<TEntity>(group, item);
                }
                
            }
            else //FilterDescriptor
            {
                var filter = descriptor as FilterDescriptor;
                ParseFilterDescriptor<TEntity>(predicate, filter);
            }
            
        }

        private static void ParseFilterDescriptor<TEntity>(IPredicate predicate, FilterDescriptor descriptor) where TEntity : class
        {
            Operator @operator;
            bool not = false;
            IPredicate fieldPredicate = null;
            switch (descriptor.Operator)
            {
                case FilterOperator.IsLessThan:
                    @operator = Operator.Lt;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, descriptor.Value, @operator, not);
                    break;
                case FilterOperator.IsLessThanOrEqualTo:
                    @operator = Operator.Le;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, descriptor.Value, @operator, not);
                    break;
                case FilterOperator.IsEqualTo:
                    @operator = Operator.Eq;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, descriptor.Value, @operator, not);
                    break;
                case FilterOperator.IsNotEqualTo:
                    @operator = Operator.Eq;
                    not = true;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, descriptor.Value, @operator, not);
                    break;
                case FilterOperator.IsGreaterThanOrEqualTo:
                    @operator = Operator.Ge;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, descriptor.Value, @operator, not);
                    break;
                case FilterOperator.IsGreaterThan:
                    @operator = Operator.Gt;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, descriptor.Value, @operator, not);
                    break;
                case FilterOperator.StartsWith:
                    @operator = Operator.Like;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, $"{descriptor.Value}%", @operator, not);
                    break;
                case FilterOperator.EndsWith:
                    @operator = Operator.Like;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, $"%{descriptor.Value}", @operator, not);
                    break;
                case FilterOperator.Contains:
                    @operator = Operator.Like;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, $"%{descriptor.Value}%", @operator, not);
                    break;
                case FilterOperator.IsContainedIn:
                    break;
                case FilterOperator.DoesNotContain:
                    @operator = Operator.Like;
                    not = true;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, $"%{descriptor.Value}", @operator, not);
                    break;
                case FilterOperator.IsNull:
                    @operator = Operator.Eq;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, null, @operator, not);
                    break;
                case FilterOperator.IsNotNull:
                    @operator = Operator.Eq;
                    not = true;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, null, @operator, not);
                    break;
                case FilterOperator.IsEmpty:
                    @operator = Operator.Eq;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, "", @operator, not);
                    break;
                case FilterOperator.IsNotEmpty:
                    @operator = Operator.Eq;
                    not = true;
                    fieldPredicate = PredicateHelper.BuildFieldPredicate<TEntity>(descriptor.Member, "", @operator, not);
                    break;
                //default:
                //    break;
            }
            if (fieldPredicate != null)
                (predicate as PredicateGroup).Predicates.Add(fieldPredicate);
        }
    }

    
}
