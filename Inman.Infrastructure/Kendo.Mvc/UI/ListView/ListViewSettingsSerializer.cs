namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;
    using Kendo.Mvc.Extensions;

    public class ListViewSettingsSerializer<T> where T : class
    {
        private readonly ListView<T> listView;

        public ListViewSettingsSerializer(ListView<T> listView)
        {
            this.listView = listView;
        }

        public void Serialize(IDictionary<string, object> options)
        {
            if (listView.DataSourceId.HasValue())
            {
                options["dataSourceId"] = listView.DataSourceId;
            }
            else
            {
                options["dataSource"] = listView.DataSource.ToJson();
            }

            var autoBind = listView.DataSource.Type != DataSourceType.Server && listView.AutoBind.GetValueOrDefault(true);

            if (!autoBind)
            {
                options["autoBind"] = autoBind;
                listView.Pageable.AutoBind = autoBind;
            }

            SerializeClientTemplate(options);

            SerializePaging(options);

            SerializeSelection(options);

            SerializeEditTemplate(options);
        }

        private void SerializePaging(IDictionary<string, object> options)
        {
            if (listView.Pageable.Enabled)
            {
                listView.AutoBind = listView.DataSource.Type != DataSourceType.Server && listView.AutoBind.GetValueOrDefault(true);
                listView.Pageable.AutoBind = listView.AutoBind.Value;
                var paging = listView.Pageable.ToJson();
                paging.Add("pagerId", listView.Id + "_pager");
                options["pageable"] = paging;
            }
        }

        private void SerializeEditTemplate(IDictionary<string, object> options)
        {
            if (listView.Editable.Enabled && !string.IsNullOrEmpty(listView.EditorHtml))
            {
                var html = listView.EditorHtml.Trim()
                                .EscapeHtmlEntities()
                                .Replace("\r\n", string.Empty)
                                .Replace("jQuery(\"#", "jQuery(\"\\#");

                options["editTemplate"] = html;
            }
        }

        private void SerializeClientTemplate(IDictionary<string, object> options)
        {
            var idPrefix = "#";

            if (listView.IsInClientTemplate)
            {
                idPrefix = "\\" + idPrefix;
            }

            if (!string.IsNullOrEmpty(listView.ClientTemplateId))
            {
                options["template"] = new ClientHandlerDescriptor { HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", idPrefix, listView.ClientTemplateId) };
            }

            if (!string.IsNullOrEmpty(listView.ClientAltTemplateId))
            {
                options["altTemplate"] = new ClientHandlerDescriptor { HandlerName = string.Format("kendo.template(jQuery('{0}{1}').html())", idPrefix, listView.ClientAltTemplateId) };
            }
        }

        private void SerializeSelection(IDictionary<string, object> options)
        {
            if (listView.Selectable.Enabled == true)
            {
                var selectable = "single";
                if (listView.Selectable.Mode.HasValue)
                {
                    selectable = listView.Selectable.Mode.Value.Serialize();
                }
                options["selectable"] = selectable;
            }
        }
    }
}
