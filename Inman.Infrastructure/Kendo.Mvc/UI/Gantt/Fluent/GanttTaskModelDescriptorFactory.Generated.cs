namespace Kendo.Mvc.UI.Fluent
{
    using Extensions;
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="DataSource"/> Model definition.
    /// </summary>
    /// <typeparam name="TModel">Type of the model</typeparam>
    public class GanttTaskModelDescriptorFactory<TModel> : DataSourceModelDescriptorFactory<TModel>, IHideObjectMembers
        where TModel : class
    {
        private GanttTaskModelDescriptor ganttTaskModel;

        public GanttTaskModelDescriptorFactory(GanttTaskModelDescriptor model)
            : base(model)
        {
            ganttTaskModel = model;
        }

        /// <summary>
        /// Specify the member used for the ParentId field.
        /// </summary>
        /// <typeparam name="TValue">Type of the field</typeparam>
        /// <param name="expression">Member access expression which describes the member</param>
        public void ParentId<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            ganttTaskModel.ParentId = expression.MemberWithoutInstance();
        }

        /// <summary>
        /// Specify the member used for the ParentId field.
        /// </summary>
        /// <param name="fieldName">The member name.</param>
        public void ParentId(string fieldName)
        {
            ganttTaskModel.ParentId = fieldName;
        }

    }
}
