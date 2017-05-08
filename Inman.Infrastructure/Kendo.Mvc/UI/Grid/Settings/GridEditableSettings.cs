namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Extensions;
    using Kendo.Mvc.Resources;
    using System.Reflection;
    using System.Text.RegularExpressions;

    public interface IGridEditingSettings
    {
        bool Enabled
        {
            get;
        }
    }

    public class GridEditableSettings<T> : JsonObject, IGridEditingSettings
        where T : class
    {
        private readonly Grid<T> grid;

        public GridEditableSettings(Grid<T> grid)
        {
            this.grid = grid;

            DisplayDeleteConfirmation = true;

            DefaultDataItem = CreateDefaultItem;
            Confirmation = Messages.Grid_Confirmation;
            ConfirmDelete = Messages.Grid_ConfirmDelete;
            CancelDelete = Messages.Grid_CancelDelete;
            CreateAt = GridInsertRowPosition.Top;
        }

        public Window PopUp
		{
			get;
			set;
		}

		public string Confirmation
		{
			get;
			set;
		}

        public ClientHandlerDescriptor ConfirmationHandler
        {
            get;
            set;
        }

        public string ConfirmDelete
        {
            get;
            set;
        }

        public string CancelDelete
        {
            get;
            set;
        }

        public GridEditMode Mode
        {
            get;
            set;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public bool DisplayDeleteConfirmation
        {
            get;
            set;
        }

        public Func<T> DefaultDataItem
        {
            get;
            set;
        }

        public string TemplateName
        {
            get;
            set;
        }

        public object AdditionalViewData
        {
            get;
            set;
        }

        public GridInsertRowPosition CreateAt
        {
            get;
            set;
        }

        private T CreateDefaultItem()
        {
            var instance = Activator.CreateInstance<T>();

            if (grid.DataSource.Schema.Model != null &&
                grid.DataSource.Schema.Model.Fields.Any())
            {
                grid.DataSource.Schema.Model.Fields.Each(f => {
                    var property = typeof(T).GetProperty(f.Member, BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                    if (property != null && property.CanWrite)
	                {
                        if (f.DefaultValue == null || f.DefaultValue.GetType() != typeof(ClientHandlerDescriptor))
                        {
                            property.SetValue(instance, f.DefaultValue, null);
                        }
	                }
                });
            }

            return instance;
        }


		private IDictionary<string, object> SerializePopUp()
		{
			var title = PopUp.Title ?? Messages.Grid_Edit;
			var result = new Dictionary<string, object> {
				["title"] = title,
				["modal"] = PopUp.Modal,
				["draggable"] = PopUp.Draggable,
				["resizable"] = PopUp.ResizingSettings.Enabled,
				["width"] = PopUp.Width ?? 0,
				["height"] = PopUp.Height ?? 0
			};

			var popupPosition = PopUp.Position;

			if (popupPosition.Left.HasValue || popupPosition.Top.HasValue)
			{
				var topLeft = new Dictionary<string, double>();

				if (popupPosition.Top.HasValue)
				{
					topLeft.Add("top", popupPosition.Top.Value);
				}

				if (popupPosition.Left.HasValue)
				{
					topLeft.Add("left", popupPosition.Left.Value);
				}

				result.Add("position", topLeft);
			}

			return result;
		}

		protected override void Serialize(IDictionary<string, object> json)
        {
            var editorHtml = grid.EditorHtml;

            if (editorHtml != null && IsClientBinding)
            {
                if (grid.IsInClientTemplate)
                {
                    editorHtml = Regex.Replace(editorHtml, "(&amp;)#([0-9]+;)", "$1\\\\#$2");
                }

                editorHtml = editorHtml.Trim()
                                .Replace("\r\n", string.Empty)
                                .Replace("\n", string.Empty)
                                .Replace("</script>", "<\\/script>")
                                .Replace("jQuery(\"#", "jQuery(\"\\\\#")
                                .Replace("#", "\\#");
            }

            if (DisplayDeleteConfirmation)
            {
                if (ConfirmationHandler != null)
                {
                    json["confirmation"] = ConfirmationHandler;
                }
                else
                {
                    json["confirmation"] = Confirmation;
                }
            }
            else
            {
                json["confirmation"] = false;
            }

            json.AddRange(new Dictionary<string, object> {
				["confirmDelete"] = ConfirmDelete,
				["cancelDelete"] = CancelDelete,
				["mode"] = Mode.ToString().ToLowerInvariant(),
				["create"] = IsClientBinding,
				["update"] = IsClientBinding,
				["destroy"] = IsClientBinding
			});

			json.Add("template", editorHtml, () => Mode != GridEditMode.InLine)
				.Add("createAt", CreateAt.ToString().ToLower(), () => CreateAt != GridInsertRowPosition.Top)
				.Add("window", SerializePopUp(), () => Mode == GridEditMode.PopUp && IsClientBinding);
		}

		private bool IsClientBinding
        {
            get
            {
                return grid.DataSource.Type == DataSourceType.Ajax || grid.DataSource.Type == DataSourceType.WebApi || grid.DataSource.Type == DataSourceType.Custom || grid.DataSourceId.HasValue();
            }
        }
    }

    public enum GridInsertRowPosition
    {
        Top,
        Bottom
    }
}
