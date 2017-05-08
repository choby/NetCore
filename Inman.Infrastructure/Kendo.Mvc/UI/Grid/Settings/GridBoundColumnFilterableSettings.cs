using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Kendo.Mvc.UI
{
    public class GridBoundColumnFilterableSettings : GridFilterableSettings
    {
		public GridBoundColumnFilterableSettings(IModelMetadataProvider modelMetadataProvider)
		{
			Enabled = true;
			FilterUIHandler = new ClientHandlerDescriptor();
			ItemTemplate = new ClientHandlerDescriptor();
			CellSettings = new GridColumnFilterableCellSettings(modelMetadataProvider);

			DataSource = new DataSource(modelMetadataProvider);
			DataSource.Transport.SerializeEmptyPrefix = false;
			DataSource.Schema.Data = "";
			DataSource.Schema.Total = "";
			DataSource.Schema.Errors = "";
		}

		public GridFilterUIRole FilterUIRole { get; set; }
        public ClientHandlerDescriptor FilterUIHandler { get; set; }
		public bool Multi { get; set; }
		public ClientHandlerDescriptor ItemTemplate { get; set; }
		public bool CheckAll { get; set; }
        public bool Search { get; set; }
        public GridColumnFilterableCellSettings CellSettings { get; }
		public DataSource DataSource { get; set; }

		protected override void Serialize(IDictionary<string, object> json)
		{
			base.Serialize(json);

			if (FilterUIHandler.HasValue())
			{
				json["ui"] = FilterUIHandler;
			}
			else if (FilterUIRole != GridFilterUIRole.Default)
			{
				json["ui"] = Enum.GetName(typeof(GridFilterUIRole), FilterUIRole).ToLowerInvariant();
			}

			var cellSettings = CellSettings.ToJson();
			if (cellSettings.Any())
			{
				json["cell"] = cellSettings;
			}

            if (!string.IsNullOrEmpty(DataSource.Transport.Read.Url))
            {
                json["dataSource"] = DataSource.ToJson();
            }
            else if (DataSource.Data != null)
            {
                json["dataSource"] = DataSource.Data;
            }            

            if (Multi)
			{
				json["multi"] = Multi;
			}
			if (ItemTemplate.HasValue())
			{
				json["itemTemplate"] = ItemTemplate;
			}
			if (CheckAll == false)
			{
				json["checkAll"] = CheckAll;
			}
            if (Search)
            {
                json["search"] = Search;
            }

		}
    }
}