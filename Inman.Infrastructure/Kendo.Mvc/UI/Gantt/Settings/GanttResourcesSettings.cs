using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttResourcesSettings class
    /// </summary>
    public partial class GanttResourcesSettings
    {
        public string DataFormatField { get; set; }

        public string DataColorField { get; set; }

        public string DataTextField { get; set; }

        public string Field { get; set; }

        public DataSource DataSource { get; set; }

        public GanttResourcesSettings(IModelMetadataProvider modelMetaDataProvider)
        {
            DataSource = new DataSource(modelMetaDataProvider);
        }

        public Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (DataFormatField?.HasValue() == true)
            {
                settings["dataFormatField"] = DataFormatField;
            }

            if (DataColorField?.HasValue() == true)
            {
                settings["dataColorField"] = DataColorField;
            }

            if (DataTextField?.HasValue() == true)
            {
                settings["dataTextField"] = DataTextField;
            }

            if (Field?.HasValue() == true)
            {
                settings["field"] = Field;
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
