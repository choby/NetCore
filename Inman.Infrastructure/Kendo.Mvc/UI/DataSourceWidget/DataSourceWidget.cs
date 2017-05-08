using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI DataSource component
    /// </summary>
    public partial class DataSourceWidget<T> : WidgetBase where T : class
    {
        public DataSource DataSource
        {
            get;
            private set;
        }

        public PivotDataSource PivotDataSource
        {
            get;
            internal set;
        }

        public DataSourceWidget(ViewContext context) : base(context)
        {
            DataSource = new DataSource(context.GetService<IModelMetadataProvider>());
            DataSource.ModelType(typeof(T));
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (DataSource.Type != DataSourceType.Custom || DataSource.CustomType == "aspnetmvc-ajax")
            {
                ProcessDataSource();
            }

            if (PivotDataSource != null)
            {
                writer.Write(this.Name + "= new kendo.data." + ClassName + "(" + Initializer.Serialize(PivotDataSource.ToJson()) + ")");
            }
            else {
                writer.Write(this.Name + "= new kendo.data." + ClassName + "(" + Initializer.Serialize(DataSource.ToJson()) + ")");
            }
        }

        internal string ClassName
        {
            get;
            set;
        } = "DataSource";

        private void ProcessDataSource()
        {
            var request = DataSourceRequestModelBinder.CreateDataSourceRequest(
                ModelMetadataProvider.GetMetadataForType(typeof(T)),
                ValueProvider,
                string.Empty
            );

            DataSource.Process(request, true);
        }

    }
}
