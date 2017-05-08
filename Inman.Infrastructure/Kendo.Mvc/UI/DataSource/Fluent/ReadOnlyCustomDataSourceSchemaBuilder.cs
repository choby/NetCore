namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using Microsoft.AspNetCore.Mvc.ModelBinding;


    /// <summary>    
    /// Defines the fluent interface for configuring the <see cref="Schema"/> options.
    /// </summary>
    public class ReadOnlyCustomDataSourceSchemaBuilder<TModel> : CustomDataSourceSchemaBuilderBase<ReadOnlyCustomDataSourceSchemaBuilder<TModel>>, IHideObjectMembers
        where TModel : class
    {
        private IModelMetadataProvider metadataProvider;

        public ReadOnlyCustomDataSourceSchemaBuilder(DataSourceSchema schema, IModelMetadataProvider metadataProvider)
            : base(schema)
        {
            this.metadataProvider = metadataProvider;
        }

        /// <summary>
        /// Configures Model properties
        /// </summary>
        public virtual ReadOnlyCustomDataSourceSchemaBuilder<TModel> Model(Action<ReadOnlyCustomDataSourceModelDescriptorFactory<TModel>> configurator)
        {
            schema.Model = new ModelDescriptor(typeof(TModel), metadataProvider);

            configurator(new ReadOnlyCustomDataSourceModelDescriptorFactory<TModel>(schema.Model));

            return this;
        }
    }
}
