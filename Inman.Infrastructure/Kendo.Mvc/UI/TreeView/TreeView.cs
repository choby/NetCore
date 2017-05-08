using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeView component
    /// </summary>
    public partial class TreeView : WidgetBase, INavigationItemComponent<TreeViewItem>
    {
        public TreeView(ViewContext viewContext) : base(viewContext)
        {
            Items = new LinkedObjectCollection<TreeViewItem>(null);

            DataSource = new DataSource(ModelMetadataProvider);
            DataSource.Schema.Model = new TreeListModelDescriptor(typeof(object), ModelMetadataProvider);
            LoadOnDemand = true;
            AutoBind = true;
        }

        /// <summary>
        /// Gets the items of the treeview.
        /// </summary>
        public IList<TreeViewItem> Items
        {
            get;
            private set;
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

        /// <summary>
        /// Gets or sets the item action.
        /// </summary>
        public Action<TreeViewItem> ItemAction
        {
            get;
            set;
        }
        public INavigationItemAuthorization Authorization
        {
            get;
            private set;
        }
        public SecurityTrimming SecurityTrimming
        {
            get;
            set;
        }
        public int SelectedIndex
        {
            get;
            set;
        } = -1;

        public bool HighlightPath
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets a value indicating whether all the item is expanded.
        /// </summary>
        /// <value><c>true</c> if expand all is enabled; otherwise, <c>false</c>. The default value is <c>false</c></value>
        public bool ExpandAll
        {
            get;
            set;
        }
        public ExpandableAnimation Animation { get; private set; } = new ExpandableAnimation();

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (DataSourceId.HasValue())
            {
                settings["dataSourceId"] = DataSourceId;
            }
            else
            {
                if (Items.Any())// && this.UsesTemplates())
                {
                    this.DataSource.Data = SerializeItems(Items);
                    this.LoadOnDemand = false;
                }

                if (!string.IsNullOrEmpty(DataSource.Transport.Read.Url) || DataSource.Type == DataSourceType.Custom)
                {
                    settings["dataSource"] = DataSource.ToJson();
                }
                else if (DataSource.Data != null)
                {
                    settings["dataSource"] = DataSource.Data;
                }
            }
            var animation = Animation.ToJson();
            if (animation.Keys.Any())
            {
                settings["animation"] = animation["animation"];
            }
            writer.Write(Initializer.Initialize(Selector, "TreeView", settings));
        }

        private IEnumerable SerializeItems(IList<TreeViewItem> items)
        {
            var factory = ViewContext.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>();

            var urlHelper = factory.GetUrlHelper(ViewContext);

            return from item in items select item.Serialize(urlHelper);
        }


        internal bool UsesTemplates()
        {
            return !string.IsNullOrEmpty(TemplateId) || !string.IsNullOrEmpty(Template) || Checkboxes.Template as string != TreeViewCheckboxesSettings.DefaultTemplate;
        }
         

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
            return;             
        }

        internal bool isPathHighlighted;
        private void HighlightSelectedItem(TreeViewItem item)
        {
            if (item.IsCurrent(ViewContext, UrlGenerator))
            {
                item.Selected = true;
                isPathHighlighted = true;

                TreeViewItem tmpItem = item.Parent;

                while (tmpItem != null)
                {
                    tmpItem.Expanded = true;
                    tmpItem = tmpItem.Parent;
                }
            }

            item.Items.Each(HighlightSelectedItem);
        }
        private void ExpandAllChildrens(TreeViewItem treeViewItem)
        {
            treeViewItem.Expanded = true;

            foreach (var item in treeViewItem.Items)
            {
                ExpandAllChildrens(item);
            }
        }        
    }
}

