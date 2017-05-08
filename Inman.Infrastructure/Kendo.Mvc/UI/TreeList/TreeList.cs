using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeList component
    /// </summary>
    public partial class TreeList<T> : WidgetBase
        where T : class 
    {
        public TreeList(ViewContext viewContext) : base(viewContext)
        {
            DataSource = new DataSource(ModelMetadataProvider)
			{
				Type = DataSourceType.Ajax,
				ServerAggregates = true,
				ServerFiltering = true,
				ServerPaging = true,
				ServerSorting = true
			};

			DataSource.Schema.Model = new TreeListModelDescriptor(typeof(T), ModelMetadataProvider);
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

        public override void ProcessSettings()
        {
            if (DataSource.Type != DataSourceType.Custom || DataSource.CustomType == "aspnetmvc-ajax")
            {
                ProcessDataSource();
            }

            if (Editable.Enabled == true)
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

            if (DataSourceId.HasValue())
            {
                settings["dataSourceId"] = DataSourceId;
            }
            else
            {
                settings["dataSource"] = DataSource.ToJson();
            }

            var selectable = Selectable.Serialize();
            if (selectable.Any())
            {
                settings.AddRange(selectable);
            }

			writer.Write(Initializer.Initialize(Selector, "TreeList", settings));
        }

		private string EditorForModel(IHtmlHelper htmlHelper, string templateName, IEnumerable<Action<IDictionary<string, object>, object>> foreignKeyData, object additionalViewData)
		{
            IHtmlContent editor;
            var sb = new StringBuilder();
            var viewContext = ViewContext.ViewContextForType<T>(ModelMetadataProvider);

			((IViewContextAware)htmlHelper).Contextualize(viewContext);

			if (foreignKeyData != null)
			{
				var dataItem = Editable.DefaultDataItem();
				foreignKeyData.Each(action => action(viewContext.ViewData, dataItem));
			}

			if (templateName.HasValue())
			{
                editor = htmlHelper.EditorForModel(templateName, additionalViewData);
			} else
            {
                editor = htmlHelper.EditorForModel(additionalViewData);
            }            

            using (var writer = new StringWriter(sb))
            {                
                editor.WriteTo(writer, HtmlEncoder);
            }

            return sb.ToString();
        }

		private string EditorForColumn(TreeListColumn<T> column, IHtmlHelper helper)
		{
			((IViewContextAware)helper).Contextualize(ViewContext.ViewContextForType<T>(ModelMetadataProvider));			

            var sb = new StringBuilder();

            using (var writer = new StringWriter(sb))
            {
                helper.Editor(column.Field, string.Empty /*EditorTemplateName*/, null /*AdditionalViewData*/).WriteTo(writer, HtmlEncoder);
                helper.ValidationMessage(column.Field).WriteTo(writer, HtmlEncoder);
            }

            return sb.ToString();
        }

		private void InitializeEditors()
		{
			var popupSlashes = new Regex("(?<=data-val-regex-pattern=\")([^\"]*)", RegexOptions.Multiline);

			var dataItem = Editable.DefaultDataItem();

			var htmlHelper = ViewContext.CreateHtmlHelper<T>();

			if (Editable.Mode == TreeListEditMode.PopUp)
			{
				var html = EditorForModel(htmlHelper, Editable.TemplateName, null /*Columns.OfType<IGridForeignKeyColumn>().Select(c => c.SerializeSelectList)*/, null/*Editable.AdditionalViewData*/);

				Editable.EditorHtml = popupSlashes.Replace(html, match =>
				{
					return match.Groups[0].Value.Replace("\\", IsInClientTemplate ? "\\\\\\\\" : "\\\\");
				});
			}
			else
			{
				var fields = DataSource.Schema.Model.Fields;

				var isDynamic = dataItem.GetType().IsDynamicObject();

				Columns.Each(column =>
				{
					if (!column.Field.HasValue())
					{
						return;
					}

					var field = fields.FirstOrDefault(f => f.Member == column.Field);
					if (isDynamic && field != null && !field.IsEditable)
					{
						return;
					}

					var editorHtml = EditorForColumn(column, htmlHelper);

					if (IsInClientTemplate)
					{
						editorHtml = popupSlashes.Replace(editorHtml, match =>
						{
							return match.Groups[0].Value.Replace("\\", "\\\\");
						});
					}
					column.Editor = editorHtml;

				});
			}
		}		

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

