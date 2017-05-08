using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Scheduler component
    /// </summary>
    public partial class Scheduler<T> : WidgetBase, IScheduler<T>
        where T : class, ISchedulerEvent 
    {
        public Scheduler(ViewContext viewContext) : base(viewContext)
        {
            ToolbarCommands = new List<SchedulerToolbarCommand>();

            Editable = new SchedulerEditableSettings<T>()
            {
                PopUp = new Window(viewContext)
                {
                    Modal = true,
                    Draggable = true,
                    Title = Kendo.Mvc.Resources.Messages.Scheduler_Editor_EditorTitle
                },
                HtmlEncoder = HtmlEncoder
            };

            Group = new SchedulerGroupSettings();

            Views = new List<SchedulerViewBase>();

            Resources = new List<SchedulerResource<T>>();

            DataSource = new DataSource(ModelMetadataProvider);

            DataSource.Type = DataSourceType.Ajax;

            DataSource.Schema.Model = new SchedulerModelDescriptor(typeof(T), ModelMetadataProvider);
        }

        public SchedulerEditableSettings<T> Editable
        {
            get;
            set;
        }

        public DataSource DataSource
        {
            get;
            private set;
        }

        public IList<SchedulerToolbarCommand> ToolbarCommands
        {
            get;
            private set;
        }

        public IList<SchedulerViewBase> Views
        {
            get;
            private set;
        }

        public IList<SchedulerResource<T>> Resources
        {
            get;
            private set;
        }

        public SchedulerGroupSettings Group
        {
            get;
            set;
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

            var idPrefix = "#";
            if (IsInClientTemplate)
            {
                idPrefix = "\\" + idPrefix;
            }

            if (Editable.Enabled == false)
            {
                settings["editable"] = false;
            }
            else
            {
                Editable.InitializeEditor(ViewContext, ModelMetadataProvider);

                IDictionary<string, object> editable = Editable.ToJson();
                if (editable.Count > 0)
                {
                    settings["editable"] = editable;
                }
            }

            if (Views.Count > 0)
            {
                settings["views"] = Views.ToJson();
            }

            if (Resources.Count > 0)
            {
                settings["resources"] = Resources.ToJson();
            }

            var group = Group.ToJson();
            if (group.Count > 0)
            {
                settings["group"] = group;
            }

            if (DataSource.Type != DataSourceType.Custom || DataSource.CustomType == "aspnetmvc-ajax")
            {
                DataSource.Transport.StringifyDates = true;
                if (DataSource.IsClientOperationMode)
                {
                    ProcessDataSource();
                }
            }

            if (ToolbarCommands.Count > 0)
            {
                settings["toolbar"] = ToolbarCommands.ToJson();
            }

            if (Mobile != MobileMode.Disabled)
            {
                if (Mobile == MobileMode.Auto)
                {
                    settings["mobile"] = true;
                }
                else
                {
                    settings["mobile"] = Mobile.ToString().ToLowerInvariant();
                }
            }

            Dictionary<string, object> dataSource = (Dictionary<string, object>)DataSource.ToJson();

            settings["dataSource"] = dataSource;

            writer.Write(Initializer.Initialize(Selector, "Scheduler", settings));
        }

        private void ProcessDataSource()
        {
            DataSourceRequest request = new DataSourceRequest();

            DataSource.Process(request, true);
        }
    }
}

