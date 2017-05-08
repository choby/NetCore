namespace Kendo.Mvc.UI.Fluent
{
    using Extensions;
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="DataSource"/> Model definition.
    /// </summary>
    /// <typeparam name="TModel">Type of the model</typeparam>
    public class GanttDependencyModelDescriptorFactory<TModel> : DataSourceModelDescriptorFactory<TModel>, IHideObjectMembers
        where TModel : class
    {
        private GanttDependencyModelDescriptor ganttDependencyModel;

        public GanttDependencyModelDescriptorFactory(GanttDependencyModelDescriptor model)
            : base(model)
        {
            ganttDependencyModel = model;
        }

        /// <summary>
        /// Specify the member used for the PredecessorId field.
        /// </summary>
        /// <typeparam name="TValue">Type of the field</typeparam>
        /// <param name="expression">Member access expression which describes the member</param>
        public void PredecessorId<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            ganttDependencyModel.PredecessorId = expression.MemberWithoutInstance();
        }

        /// <summary>
        /// Specify the member used for the PredecessorId field.
        /// </summary>
        /// <param name="fieldName">The member name.</param>
        public void PredecessorId(string fieldName)
        {
            ganttDependencyModel.PredecessorId = fieldName;
        }

        /// <summary>
        /// Specify the member used for the SuccessorId field.
        /// </summary>
        /// <typeparam name="TValue">Type of the field</typeparam>
        /// <param name="expression">Member access expression which describes the member</param>
        public void SuccessorId<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            ganttDependencyModel.SuccessorId = expression.MemberWithoutInstance();
        }

        /// <summary>
        /// Specify the member used for the SuccessorId field.
        /// </summary>
        /// <param name="fieldName">The member name.</param>
        public void SuccessorId(string fieldName)
        {
            ganttDependencyModel.SuccessorId = fieldName;
        }

    }
}
