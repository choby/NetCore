using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ListView component
    /// </summary>
    public partial class ListView<T> : WidgetBase where T : class
    {
        private readonly ListViewSettingsSerializer<T> settingsSerializer;

        public ListView(ViewContext viewContext) : base(viewContext)
        {
            settingsSerializer = new ListViewSettingsSerializer<T>(this);

            DataSource = new DataSource(ModelMetadataProvider)
            {
                Type = DataSourceType.Ajax,
                ServerAggregates = true,
                ServerFiltering = true,
                ServerGrouping = true,
                ServerPaging = true,
                ServerSorting = true
            };

            DataSource.ModelType(typeof(T));
        }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            if (Pageable.Enabled)
            {
                Dictionary<string, object> htmlAttributes = new Dictionary<string, object>();
                htmlAttributes.Add("id", this.Id + "_pager");
                htmlAttributes.Add("class", "k-pager-wrap");
                var pagerTag = Generator.GenerateTag("div", ViewContext, Id, Name, htmlAttributes);
                pagerTag.WriteTo(writer, HtmlEncoder);
            }

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (!DataSourceId.HasValue())
            {
                settings["dataSource"] = DataSource.ToJson();

                if (DataSource.Type != DataSourceType.Custom || DataSource.CustomType == "aspnetmvc-ajax")
                {
                    ProcessDataSource();
                }
            }
            InitializeEditor();
            settingsSerializer.Serialize(settings);

            writer.Write(Initializer.Initialize(Selector, "ListView", settings));
        }

        private void ProcessDataSource()
        {
            if (Pageable.Enabled && DataSource.PageSize == 0)
            {
                DataSource.PageSize = 10;
            }

            var request = DataSourceRequestModelBinder.CreateDataSourceRequest(
                ModelMetadataProvider.GetMetadataForType(typeof(T)),
                ValueProvider,
                string.Empty
            );

            DataSource.Process(request, true);
        }

        private void InitializeEditor()
        {
            if (Editable.Enabled)
            {
                var popupSlashes = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);
                var htmlHelper = ViewContext.CreateHtmlHelper<T>();

                var viewContext = ViewContext.ViewContextForType<T>(ModelMetadataProvider);
                ((IViewContextAware)htmlHelper).Contextualize(viewContext);

                var sb = new StringBuilder();
                using (var writer = new StringWriter(sb))
                {
                    if (Editable.TemplateName.HasValue())
                    {
                        htmlHelper.EditorForModel(Editable.TemplateName).WriteTo(writer, HtmlEncoder);
                    }
                    else
                    {
                        htmlHelper.EditorForModel().WriteTo(writer, HtmlEncoder);
                    }
                }
                EditorHtml = popupSlashes.Replace(sb.ToString(), match =>
                {
                    return match.Groups[0].Value.Replace("\\", IsInClientTemplate ? "\\\\\\\\" : "\\\\");
                });
            }
        }

        public override void VerifySettings()
        {
            base.VerifySettings();

            if (string.IsNullOrEmpty(ClientTemplateId))
            {
                throw new NotSupportedException(string.Format(Exceptions.CannotBeNullOrEmpty, "ClientTemplateId"));
            }

            if (string.IsNullOrEmpty(TagName))
            {
                throw new NotSupportedException(string.Format(Exceptions.CannotBeNullOrEmpty, "TagName"));
            }

            if (Editable.Enabled && DataSource.Schema.Model.Id == null && !DataSourceId.HasValue())
            {
                throw new NotSupportedException(Exceptions.DataKeysEmpty);
            }

            if (AutoBind.HasValue)
            {
                if (!IsClientBinding || (IsClientBinding && DataSource.Data != null))
                {
                    throw new NotSupportedException(Exceptions.CannotSetAutoBindIfBoundDuringInitialization);
                }
            }
        }
        private bool IsClientBinding
        {
            get
            {
                return DataSource.Type == DataSourceType.Ajax || DataSource.Type == DataSourceType.WebApi || DataSource.Type == DataSourceType.Custom;
            }
        }

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

        public string ClientTemplateId
        {
            get;
            set;
        }
        public string ClientAltTemplateId
        {
            get;
            set;
        }
        public PageableSettings Pageable { get; } = new PageableSettings();

        public ListViewEditingSettings<T> Editable { get; } = new ListViewEditingSettings<T>();
        public string EditorHtml
        {
            get;
            set;
        }
    }
}

