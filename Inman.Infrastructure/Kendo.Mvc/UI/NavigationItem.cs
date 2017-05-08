namespace Kendo.Mvc.UI
{
    // using System.Web.Script.Serialization;
    using Kendo.Mvc;
    using Kendo.Mvc.Extensions;
    using Microsoft.AspNetCore.Routing;
    using Rendering;
    using System;
    using System.Collections.Generic;
    using System.Net;
    public abstract class NavigationItem<T> : LinkedObjectBase<T>, INavigatable, IHideObjectMembers, IHtmlAttributesContainer, IContentContainer
        where T : NavigationItem<T>
    {
        private string text;
        private string routeName;
        private string controllerName;
        private string actionName;
        private string url;
        private string template;
        private Func<T, object> inlineTemplate;

        private bool selected;
        private bool enabled;

        protected NavigationItem()
        {
            Template = new HtmlTemplate();
            HtmlAttributes = new RouteValueDictionary();
            ImageHtmlAttributes = new RouteValueDictionary();
            LinkHtmlAttributes = new RouteValueDictionary();
            RouteValues = new RouteValueDictionary();
            ContentHtmlAttributes = new RouteValueDictionary();
            Visible = true;
            Enabled = true;
            Encoded = true;
        }

        //[ScriptIgnore]
        public RouteValueDictionary RouteValues
        {
            get;
            set;
        }

        //[ScriptIgnore]
        public IDictionary<string, object> HtmlAttributes
        {
            get;
            private set;
        }

        //[ScriptIgnore]
        public IDictionary<string, object> ImageHtmlAttributes
        {
            get;
            private set;
        }

        //[ScriptIgnore]
        public IDictionary<string, object> LinkHtmlAttributes
        {
            get;
            private set;
        }

        //[ScriptIgnore]
        public IDictionary<string, object> ContentHtmlAttributes
        {
            get;
            private set;
        }

        public bool Encoded
        {
            get;
            set;
        }

        //[ScriptIgnore]
        public HtmlTemplate Template
        {
            get;
            private set;
        }

        public Func<T, object> InlineTemplate
        {
            get; set;
        }

        //[ScriptIgnore]
        public string Html
        {
            get
            {
                return Template.Html;
            }
            set
            {
                Template.Html = value;
            }
        }

        //[ScriptIgnore]
        public bool Visible
        {
            get;
            set;
        }

        public string ImageUrl
        {
            get;
            set;
        }

        public string SpriteCssClasses
        {
            get;
            set;
        }

        //[ScriptIgnore]
        public Action Content
        {
            get
            {
                return Template.Content;
            }
            set
            {
                Template.Content = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
            set
            {

                text = value;
            }
        }

        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;

                if (selected)
                {
                    enabled = true;
                }
            }
        }

        public bool Enabled
        {
            get
            {
                return enabled;
            }
            set
            {
                enabled = value;

                if (!enabled)
                {
                    selected = false;
                }
            }
        }

        //[ScriptIgnore]
        public string ControllerName
        {
            get
            {
                return controllerName;
            }
            set
            {

                controllerName = value;

                routeName = url = null;
            }
        }

        //[ScriptIgnore]
        public string ActionName
        {
            get
            {
                return actionName;
            }
            set
            {

                actionName = value;

                routeName = url = null;
            }
        }

        //[ScriptIgnore]
        public string RouteName
        {
            get
            {
                return routeName;
            }
            set
            {

                routeName = value;
                controllerName = actionName = url = null;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }
            set
            {

                url = value;

                routeName = controllerName = actionName = null;
                RouteValues.Clear();
            }
        }
    }
}