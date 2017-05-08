using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Gantt component
    /// </summary>
    public partial class Gantt<TTaskModel, TDependenciesModel> : WidgetBase
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency
    {

        public DataSource DataSource
        {
            get;
            private set;
        }
        public string DataSourceId
        {
            get;
            set;
        }

        public DataSource DependenciesDataSource
        {
            get;
            private set;
        }
        public string DependenciesDataSourceId
        {
            get;
            set;
        }

        public GanttAssignmentsSettings Assignments { get; }

        public GanttResourcesSettings Resources { get; }

        public Gantt(ViewContext viewContext) : base(viewContext)
        {
            DataSource = new DataSource(ModelMetadataProvider);
            DataSource.Type = DataSourceType.Ajax;
            DataSource.Schema.Model = new GanttTaskModelDescriptor(typeof(TTaskModel), ModelMetadataProvider);

            DependenciesDataSource = new DataSource(ModelMetadataProvider);
            DependenciesDataSource.Type = DataSourceType.Ajax;
            DependenciesDataSource.Schema.Model = new GanttDependencyModelDescriptor(typeof(TDependenciesModel), ModelMetadataProvider);

            Assignments = new GanttAssignmentsSettings(ModelMetadataProvider);

            Resources = new GanttResourcesSettings(ModelMetadataProvider);
        }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (DataSourceId.HasValue())
            {
                settings["dataSourceId"] = DataSourceId;
            }
            else
            {
                ProcessDataSource(DataSource);

                settings["dataSource"] = (Dictionary<string, object>)DataSource.ToJson();
            }

            if (DependenciesDataSourceId.HasValue())
            {
                settings["dependenciesId"] = DependenciesDataSourceId;
            }
            else
            {
                ProcessDataSource(DependenciesDataSource);

                settings["dependencies"] = (Dictionary<string, object>)DependenciesDataSource.ToJson();
            }
            var assignments = Assignments.Serialize();
            if (assignments.Any())
            {
                settings["assignments"] = assignments;
            }

            var resources = Resources.Serialize();
            if (resources.Any())
            {
                settings["resources"] = resources;
            }

            if (Editable.Enabled.HasValue && Editable.Enabled == false)
            {
                settings["editable"] = false;
            }
            else
            {
                var editable = Editable.Serialize();
                if (editable.Any())
                {
                    settings["editable"] = editable;
                }
            }

            writer.Write(Initializer.Initialize(Selector, "Gantt", settings));
        }

        private void ProcessDataSource(DataSource dataSource)
        {
            if (dataSource.Type != DataSourceType.Custom || dataSource.CustomType == "aspnetmvc-ajax")
            {
                if (dataSource.IsClientOperationMode)
                {
                    DataSourceRequest request = new DataSourceRequest();

                    dataSource.Process(request, true);
                }
            }
        }
    }
}

