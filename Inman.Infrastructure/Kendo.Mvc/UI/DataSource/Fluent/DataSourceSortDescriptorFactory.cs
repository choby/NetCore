namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Extensions;

    public class DataSourceSortDescriptorFactory<TModel> : DataSourceSortDescriptorFactoryBase<DataSourceSortDescriptorFactory<TModel>>, IHideObjectMembers
        where TModel : class
    {
        public DataSourceSortDescriptorFactory(IList<SortDescriptor> descriptors)
            : base(descriptors)
        {
        }

        public virtual DataSourceSortDescriptorBuilder Add<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            return Add(new SortDescriptor
            {
                Member = expression.MemberWithoutInstance(),
                SortDirection = ListSortDirection.Ascending
            });
        }
    }
}