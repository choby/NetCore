namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using Infrastructure;
    using Kendo.Mvc.Extensions;
    using System.Text.Encodings.Web;


    /// <summary>
    /// The base class for all columns in Kendo Grid for ASP.NET MVC.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class GridColumnBase<T> : JsonObject, IGridColumn where T : class
    {
        public string Format
        {
            get
            {
                return Settings.Format;
            }
            set
            {
                Settings.Format = value;
            }
        }
        
        public string EditorHtml
        {
            get;
            set;
        }

        protected GridColumnBase(Grid<T> grid)
        {
            Grid = grid;
            Settings = new GridColumnSettings();            
            Visible = true;						
        }

		/// <summary>
		/// Gets or sets the grid.
		/// </summary>
		/// <value>The grid.</value>
		public Grid<T> Grid { get; }

        /// <summary>
        /// Gets the member of the column.
        /// </summary>
        /// <value>The member.</value>
        public string Member
        {
            get
            {
                return Settings.Member;
            }
            
            set
            {
                Settings.Member = value;
            }
        }

        protected override void Serialize(IDictionary<string, object> json)
        {
            if (Title.HasValue())
            {
                json["title"] = Title;
            }

            if (HtmlAttributes.Any())
            {
                json["attributes"] = EncodeAttributes(HtmlAttributes);
            }

            if (HeaderHtmlAttributes.Any())
			{
				json["headerAttributes"] = EncodeAttributes(HeaderHtmlAttributes);
			}

			if (FooterHtmlAttributes.Any())
            {
                json["footerAttributes"] = EncodeAttributes(FooterHtmlAttributes);
            }

            if (Hidden)
            {
                json["hidden"] = true;
            }

            if (!IncludeInMenu)
            {
                json["menu"] = false;
            }

            if (Width.HasValue())
            {
                json["width"] = Width;
            }

            if (MinScreenWidth != default(int))
            {
                json["minScreenWidth"] = MinScreenWidth;
            }

            if (ClientTemplate.HasValue())                  
            {
                json["template"] = WebUtility.UrlDecode(ClientTemplate);
            }
            
            if (ClientFooterTemplate.HasValue())
            {
                json["footerTemplate"] = WebUtility.UrlDecode(ClientFooterTemplate);
            }

			if (ClientHeaderTemplate.HasValue())
			{
				json["headerTemplate"] = WebUtility.UrlDecode(ClientHeaderTemplate);
			}

			if (ClientGroupFooterTemplate.HasValue())
            {
                json["groupFooterTemplate"] = ClientGroupFooterTemplate;
            }

            if (!Encoded)
            {
                json["encoded"] = Encoded;
            }

            if (Locked)
            {
                json["locked"] = Locked;
            }

            if (!Lockable)
            {
                json["lockable"] = Lockable;
            }
        }

        private IDictionary<string, object> EncodeAttributes(IDictionary<string, object> htmlAttributes)
        {
            var attributes = new Dictionary<string, object>();            

            var encoder = HtmlEncoder.Default;
            //var hasAntiXss = HttpEncoder.Current != null && HttpEncoder.Current.GetType().ToString().Contains("AntiXssEncoder");

            htmlAttributes.Each(attr =>
            {
                var value = encoder.Encode(attr.Value.ToString());
                //if (hasAntiXss)
                //{
                //    value = value.Replace("&#32;", " ");
                //}
                attributes[encoder.Encode(attr.Key)] = value;
            });

            return attributes;            
        }


        /// <summary>
        /// Gets or sets the title of the column.
        /// </summary>
        /// <value>The title.</value>
        public virtual string Title
        {
            get
            {
                return Settings.Title;
            }
            set
            {
                Settings.Title = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the column.
        /// </summary>
        /// <value>The width.</value>
        public string Width
        {
            get
            {
                return Settings.Width;
            }
            set
            {
                Settings.Width = value;
            }
        }

        public int MinScreenWidth
        {
            get
            {
                return Settings.MinScreenWidth;
            }
            set
            {
                Settings.MinScreenWidth = value;
            }
        }

        public string ClientHeaderTemplate
		{
			get
			{
				return Settings.ClientHeaderTemplate;
			}
			set
			{
				Settings.ClientHeaderTemplate = value;
			}
		}

		public string ClientTemplate
        {
            get
            {
                return Settings.ClientTemplate;
            }
            set
            {
                Settings.ClientTemplate = value;
            }
        }

        public string ClientFooterTemplate
        {
            get
            {
                return Settings.ClientFooterTemplate;
            }
            set
            {
                Settings.ClientFooterTemplate = value;
            }
        }

        public string ClientGroupFooterTemplate
        {
            get
            {
                return Settings.ClientGroupFooterTemplate;
            }
            set
            {
                Settings.ClientGroupFooterTemplate = value;
            }
        }
        
        /// <summary>
        /// Gets or sets a value indicating whether this column is hidden.
        /// </summary>
        /// <value><c>true</c> if hidden; otherwise, <c>false</c>.</value>
        /// <remarks>
        /// Hidden columns are output as HTML but are not visible by the end-user.
        /// </remarks>
        public virtual bool Hidden
        {
            get
            {
                return Settings.Hidden || Grid.Columns.ColumnParents(this).Any(c => c.Hidden);
            }
            set
            {                
                Settings.Hidden = value;
            }
        }        
  
        public virtual bool IncludeInMenu
        {
            get
            {
                return Settings.IncludeInMenu;
            }
            set
            {
                Settings.IncludeInMenu = value;
            }
        }
   
        public virtual bool Locked
        {
            get
            {
                return Settings.Locked;
            }
            
            set
            {
                Settings.Locked = value;
            }
        }

        public virtual bool Lockable
        {
            get
            {
                return Settings.Lockable;
            }

            set
            {
                Settings.Lockable = value;
            }
        }

        public virtual bool Encoded
        {
            get
            {
                return Settings.Encoded;
            }
            
            set
            {
                Settings.Encoded = value;
            }
        }

        /// <summary>
        /// Gets the header HTML attributes.
        /// </summary>
        /// <value>The header HTML attributes.</value>
        public IDictionary<string, object> HeaderHtmlAttributes
        {
            get
            {
                return Settings.HeaderHtmlAttributes;
            }
        }        
        /// <summary>
        /// Gets the footer HTML attributes.
        /// </summary>
        /// <value>The footer HTML attributes.</value>
        public IDictionary<string, object> FooterHtmlAttributes
        {
            get
            {
                return Settings.FooterHtmlAttributes;
            }
        }
        
        /// <summary>
        /// Gets or sets a value indicating whether this column is visible.
        /// </summary>
        /// <value><c>true</c> if visible; otherwise, <c>false</c>. The default value is <c>true</c>.</value>
        /// <remarks>
        /// Invisible columns are not output in the HTML.
        /// </remarks>
        public virtual bool Visible
        {
            get
            {
                return Settings.Visible;
            }
            set
            {
                Settings.Visible = value;
            }
        }        
        
        /// <summary>
        /// Gets the HTML attributes of the cell rendered for the column
        /// </summary>
        /// <value>The HTML attributes.</value>
        public IDictionary<string, object> HtmlAttributes
        {
            get
            {
                return Settings.HtmlAttributes;
            }
        }

        public bool IsLast
        {
            get
            {                
                return Grid.VisibleColumns.Where(c => !c.Hidden).LastOrDefault() == this;
            }
        }

        internal GridColumnSettings Settings
        {
            get;
            set;
        }

        private int HeaderLevel
        {
            get
            {
                return Grid.Columns.ColumnLevel(this);
            }
        }

        private int HeaderDataIndex
        {
            get
            {
                return Grid.Columns.LeafColumns().Where(c => c.Visible).OrderByDescending(c => c.Locked).IndexOf(this);
            }
        }
    }
}
