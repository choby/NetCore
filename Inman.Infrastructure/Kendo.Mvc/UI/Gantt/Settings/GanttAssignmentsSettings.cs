using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttAssignmentsSettings class
    /// </summary>
    public class GanttAssignmentsSettings
    {
        public string DataResourceIdField { get; set; }

        public string DataTaskIdField { get; set; }

        public string DataValueField { get; set; }

        public DataSource DataSource { get; set; }

        public IModelMetadataProvider ModelMetaDataProvider;

        public GanttAssignmentsSettings(IModelMetadataProvider modelMetaDataProvider)
        {
            ModelMetaDataProvider = modelMetaDataProvider;

            DataSource = new DataSource(modelMetaDataProvider);
            DataSource.Type = DataSourceType.Ajax;
        }

        public Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (DataResourceIdField?.HasValue() == true)
            {
                settings["dataResourceIdField"] = DataResourceIdField;
            }

            if (DataTaskIdField?.HasValue() == true)
            {
                settings["dataTaskIdField"] = DataTaskIdField;
            }

            if (DataValueField?.HasValue() == true)
            {
                settings["dataValueField"] = DataValueField;
            }

            if (!string.IsNullOrEmpty(DataSource.Transport.Read.Url) ||
                !string.IsNullOrEmpty(DataSource.Transport.FunctionRead.HandlerName) ||
                DataSource.Transport.CustomRead != null ||
                DataSource.Type == DataSourceType.Custom)
            {
                settings["dataSource"] = DataSource.ToJson();
            }
            else if (DataSource.Data != null)
            {
                settings["dataSource"] = DataSource.Data;
            }

            return settings;
        }
    }
}
