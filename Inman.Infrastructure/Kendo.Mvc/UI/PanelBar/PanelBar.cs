using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI PanelBar component
    /// </summary>
    public partial class PanelBar : WidgetBase, INavigationItemComponent<PanelBarItem>
    {
        internal bool isPathHighlighted;
        internal bool isExpanded;

        public PanelBar(ViewContext viewContext) 
            : base(viewContext)
        {
            Animation = new ExpandableAnimation();

            ExpandMode = PanelBarExpandMode.Multiple;

            Items = new List<PanelBarItem>();
            DataSource = new DataSource(ModelMetadataProvider);
            DataSource.Schema.Model = new TreeListModelDescriptor(typeof(object), ModelMetadataProvider);

            LoadOnDemand = true;
            AutoBind = true;

            HighlightPath = true;
            SelectedIndex = -1;
        }

        public IList<PanelBarItem> Items { get; private set; }

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
        public ExpandableAnimation Animation { get; private set; }

        public Action<PanelBarItem> ItemAction { get; set; }

        public bool HighlightPath { get; set; }

        public bool ExpandAll { get; set; }

        public int SelectedIndex { get; set; }

        public Effects Effects { get; set; }

        protected override void WriteHtml(TextWriter writer)
        {
            if (Items.Any())
            {
                if (SelectedIndex != -1 && Items.Count < SelectedIndex)
                {
                    throw new ArgumentOutOfRangeException(Exceptions.IndexOutOfRange);
                }

                int itemIndex = 0;

                INavigationComponentHtmlBuilder<PanelBarItem> builder = new PanelBarHtmlBuilder(this);

                IHtmlNode panelbarTag = builder.Build();

                if (HighlightPath)
                {
                    Items.Each(HighlightSelectedItem);
                }

                this.Items.Each(item =>
                {
                    if (item.Enabled)
                    {
                        PrepareItem(item, itemIndex);
                    }

                    itemIndex++;

                    item.WriteItem<PanelBar, PanelBarItem>(this, panelbarTag, builder);
                });

                panelbarTag.WriteTo(writer, HtmlEncoder);
            }
            else
            {
                var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

                tag.WriteTo(writer, HtmlEncoder);
            }

            base.WriteHtml(writer);
        }

        private void HighlightSelectedItem(PanelBarItem item)
        {
            if (item.Enabled)
            {
                if (item.IsCurrent(ViewContext, UrlGenerator))
                {
                    item.Selected = true;
                    isPathHighlighted = true;

                    PanelBarItem tmpItem = item.Parent;
                    while (tmpItem != null)
                    {
                        tmpItem.Expanded = true;
                        tmpItem = tmpItem.Parent;
                    }
                }
                item.Items.Each(HighlightSelectedItem);
            }
        }

        private void PrepareItem(PanelBarItem item, int itemIndex)
        {
            if (!this.isPathHighlighted)
            {
                if (itemIndex == this.SelectedIndex)
                {
                    item.Selected = true;

                    if (item.Items.Any() || item.Template.HasValue() || !string.IsNullOrEmpty(item.ContentUrl))
                    {
                        item.Expanded = true;
                    }
                }
            }

            if (ExpandMode == PanelBarExpandMode.Single)
            {
                if (item.Expanded && !isExpanded)
                {
                    isExpanded = true;
                }
                else
                {
                    if (item.Parent != null && item.Parent.Expanded)
                    {
                        item.Expanded = true;
                    }   
                    else
                    {
                        item.Expanded = false;
                    }  
                }
            }
            else
            {
                if (ExpandAll)
                {
                    item.Expanded = true;
                }
            }
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
                //if (Items.Any())// && this.UsesTemplates())
                //{
                //    this.DataSource.Data = SerializeItems(Items);
                //    this.LoadOnDemand = false;
                //}

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

            writer.Write(Initializer.Initialize(Selector, "PanelBar", settings));
        }
    }
}

