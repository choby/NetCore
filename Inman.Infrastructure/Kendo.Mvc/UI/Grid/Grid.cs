using Kendo.Mvc.Extensions;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;
using System.Text;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Html;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Grid component
    /// </summary>
    public partial class Grid<T> : WidgetBase, IGridColumnContainer<T>
		where T : class 
    {
        public Grid(ViewContext viewContext) : base(viewContext)
        {
            Editable = new GridEditableSettings<T>(this)
			{
				PopUp = new Window(viewContext)
				{
					Modal = true,
					Draggable = true
				}
			};

			DataSource = new DataSource(ModelMetadataProvider)
			{
				Type = DataSourceType.Ajax
			};

			DataSource.ModelType(typeof(T));

            ToolBar = new GridToolBarSettings(this);
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

        private string clientRowTemplate;

		public string ClientRowTemplate
		{
			get
			{
				return clientRowTemplate;
			}
			set
			{
				clientRowTemplate = WebUtility.HtmlDecode(value);
			}
		}

		private string clientAltRowTemplate;

		public string ClientAltRowTemplate
		{
			get
			{
				return clientAltRowTemplate;
			}
			set
			{
				clientAltRowTemplate = WebUtility.HtmlDecode(value);
			}
		}

		public string ClientDetailTemplateId
		{
			get;
			set;
		}
		public bool AutoGenerateColumns
		{
			get;
			set;
		}
		= true;

		public GridEditableSettings<T> Editable { get; }

        public GridToolBarSettings ToolBar { get; }

		/// <summary>
		/// Gets the selection configuration
		/// </summary>
		public GridSelectableSettings Selectable { get; } = new GridSelectableSettings();

		/// <summary>
		/// Gets the filtering configuration.
		/// </summary>		
		public GridFilterableSettings Filterable { get; } = new GridFilterableSettings();

		/// <summary>
		/// Gets the scrolling configuration.
		/// </summary>
		public GridScrollableSettings Scrollable { get; } = new GridScrollableSettings();

		/// <summary>
		/// Gets the paging configuration.
		/// </summary>
		public PageableSettings Pageable { get; } = new PageableSettings();

		public GridSettings Resizable { get; } = new GridSettings();

		public GridSettings Reorderable { get; } = new GridSettings();

		/// <summary>
		/// Gets the columns of the grid.
		/// </summary>
		public IList<GridColumnBase<T>> Columns { get; } = new List<GridColumnBase<T>>();

		public IList<GridColumnBase<T>> VisibleColumns
		{
			get
			{
				return Columns.Where(c => c.Visible).ToList();
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether custom binding is enabled.
		/// </summary>
		/// <value><c>true</c> if custom binding is enabled; otherwise, <c>false</c>. The default value is <c>false</c></value>
		public bool EnableCustomBinding { get; set; }

		public MobileMode Mobile
		{
			get;
			set;
		}

        public override void ProcessSettings()
        {
            if (!Columns.Any() && AutoGenerateColumns)
            {
                foreach (GridColumnBase<T> column in new GridColumnGenerator<T>(this).GetColumns())
                {
                    Columns.Add(column);
                }
            }

            if (!HtmlAttributes.ContainsKey("id"))
            {
                HtmlAttributes["id"] = Id;
            }

            if (DataSource.Type != DataSourceType.Custom || DataSource.CustomType == "aspnetmvc-ajax")
            {
                ProcessDataSource();
            }

            if (Editable.Enabled)
            {
                InitializeEditors();
            }
            base.ProcessSettings();
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

            var autoBind = DataSource.Type != DataSourceType.Server && AutoBind.GetValueOrDefault(true);

            var idPrefix = "#";
            if (IsInClientTemplate)
            {
                idPrefix = "\\" + idPrefix;
            }

            var columns = VisibleColumns.Select(c => c.ToJson());
            if (columns.Any())
            {
                settings["columns"] = columns;
            }

            if (Pageable.Enabled)
            {
                Pageable.AutoBind = autoBind;

                settings["pageable"] = Pageable.ToJson();
            }

            if (Selectable.Enabled)
            {
                settings["selectable"] = $"{Selectable.Mode}, {Selectable.Type}";
            }

            if (Filterable.Enabled)
            {
                var filtering = Filterable.ToJson();
                settings["filterable"] = filtering.Any() ? (object)filtering : true;
            }

            if (Resizable.Enabled)
            {
                settings["resizable"] = true;
            }

            if (Reorderable.Enabled)
            {
                settings["reorderable"] = true;
            }

            if (!Scrollable.Enabled)
            {
                settings["scrollable"] = false;
            }
            else
            {
                var scrolling = Scrollable.ToJson();
                if (scrolling.Any())
                {
                    settings["scrollable"] = scrolling;
                }
                settings["height"] = Scrollable.Height;
            }

            if (Editable.Enabled)
            {
                settings["editable"] = Editable.ToJson();
            }

            if (ToolBar.Enabled)
            {
                settings["toolbar"] = ToolBar.ToJson().First().Value;
            }
            if (DataSourceId.HasValue())
            {
                settings["dataSourceId"] = DataSourceId;
            }
            else {
                settings["dataSource"] = DataSource.ToJson();
            }

            if (!String.IsNullOrEmpty(ClientDetailTemplateId))
			{
				settings["detailTemplate"] = new ClientHandlerDescriptor { HandlerName = String.Format("kendo.template(jQuery('{0}{1}').html())", idPrefix, ClientDetailTemplateId) };
			}

			if (!String.IsNullOrEmpty(ClientRowTemplate))
			{
				settings["rowTemplate"] = ClientRowTemplate;
			}

			if (!String.IsNullOrEmpty(ClientAltRowTemplate))
			{
				settings["altRowTemplate"] = ClientAltRowTemplate;
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
			writer.Write(Initializer.Initialize(Selector, "Grid", settings));
        }

		private string EditorForModel(IHtmlHelper htmlHelper, string templateName, IEnumerable<Action<IDictionary<string, object>, object>> foreignKeyData, object additionalViewData)
		{
			var viewContext = ViewContext.ViewContextForType<T>(ModelMetadataProvider);
			((IViewContextAware)htmlHelper).Contextualize(viewContext);

			if (foreignKeyData != null)
			{
				var dataItem = Editable.DefaultDataItem();
				foreignKeyData.Each(action => action(viewContext.ViewData, dataItem));
			}

            IHtmlContent editorContent;

            if (templateName.HasValue())
            {
                editorContent = htmlHelper.EditorForModel(templateName, additionalViewData);
            }
            else
            {
                editorContent = htmlHelper.EditorForModel(additionalViewData);
            }            

            var sb = new StringBuilder();

            using (var writer = new StringWriter(sb))
            {
                editorContent.WriteTo(writer, HtmlEncoder);
            }

            return sb.ToString();

        }

		private void InitializeEditors()
		{
			var popupSlashes = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);

			var dataItem = Editable.DefaultDataItem();

			var htmlHelper = ViewContext.CreateHtmlHelper<T>();

			if (Editable.Mode != GridEditMode.InLine && Editable.Mode != GridEditMode.InCell)
			{
				var html = EditorForModel(htmlHelper, Editable.TemplateName, Columns.OfType<IGridForeignKeyColumn>().Select(c => c.SerializeSelectList), Editable.AdditionalViewData);

				EditorHtml = popupSlashes.Replace(html, match =>
				{
					return match.Groups[0].Value.Replace("\\", IsInClientTemplate ? "\\\\\\\\" : "\\\\");
				});
			}
			else
			{
				var fields = DataSource.Schema.Model.Fields;

				var isDynamic = dataItem.GetType().IsDynamicObject();

				VisibleColumns.LeafColumns().OfType<IGridBoundColumn>().Each(column =>
				{
					var field = fields.FirstOrDefault(f => f.Member == column.Member);
					if (isDynamic && field != null && !field.IsEditable)
					{
						return;
					}

					var editorHtml = column.GetEditor(htmlHelper, HtmlEncoder);

					if (IsInClientTemplate)
					{
						editorHtml = popupSlashes.Replace(editorHtml, match =>
						{
							return match.Groups[0].Value.Replace("\\", "\\\\");
						});
					}
					column.EditorHtml = editorHtml;

				});
			}
		}
		public string EditorHtml { get; set; }

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

            DataSource.Process(request, !EnableCustomBinding);
        }
	}
}

