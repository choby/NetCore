﻿using Inman.Infrastructure.Common.IOC;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Inman.Infrastructure.Web
{
    public partial class PageTitleBuilder : IPageTitleBuilder
    {

        private readonly List<string> _titleParts;
        private readonly List<string> _fileContentParts; 
        //private readonly List<string> _metaDescriptionParts;
        //private readonly List<string> _metaKeywordParts;
        private readonly Dictionary<ResourceLocation, List<string>> _scriptParts;
        private readonly Dictionary<ResourceLocation, List<string>> _cssParts;
        //private readonly List<string> _canonicalUrlParts;
        IHttpContextAccessor _httpContextAccessor;
        public PageTitleBuilder()
        {
            _titleParts = new List<string>();
            _fileContentParts = new List<string>();
            //_metaDescriptionParts = new List<string>();
            //_metaKeywordParts = new List<string>();
            _scriptParts = new Dictionary<ResourceLocation, List<string>>();
            _cssParts = new Dictionary<ResourceLocation, List<string>>();
            //_canonicalUrlParts = new List<string>();
            _httpContextAccessor = EngineContext.Current.GetService<IHttpContextAccessor>();
        }

        public void AddTitleParts(params string[] parts)
        {
            if (parts != null)
                foreach (string part in parts)
                    if (!string.IsNullOrEmpty(part))
                        _titleParts.Add(part);
        }
        public void AppendTitleParts(params string[] parts)
        {
            if (parts != null)
                foreach (string part in parts)
                    if (!string.IsNullOrEmpty(part))
                        _titleParts.Insert(0, part);
        }
        public string GenerateTitle()
        {
            string result = "";
            var specificTitle = string.Join("", _titleParts.AsEnumerable().Reverse().ToArray());
            if (!String.IsNullOrEmpty(specificTitle))
            {
                result = specificTitle;
            }
            return result;
        }


        //public void AddMetaDescriptionParts(params string[] parts)
        //{
        //    if (parts != null)
        //        foreach (string part in parts)
        //            if (!string.IsNullOrEmpty(part))
        //                _metaDescriptionParts.Add(part);
        //}
        //public void AppendMetaDescriptionParts(params string[] parts)
        //{
        //    if (parts != null)
        //        foreach (string part in parts)
        //            if (!string.IsNullOrEmpty(part))
        //                _metaDescriptionParts.Insert(0, part);
        //}
        //public string GenerateMetaDescription()
        //{
        //    var metaDescription = string.Join(", ", _metaDescriptionParts.AsEnumerable().Reverse().ToArray());
        //    var result = !String.IsNullOrEmpty(metaDescription) ? metaDescription : _seoSettings.DefaultMetaDescription;
        //    return result;
        //}


        //public void AddMetaKeywordParts(params string[] parts)
        //{
        //    if (parts != null)
        //        foreach (string part in parts)
        //            if (!string.IsNullOrEmpty(part))
        //                _metaKeywordParts.Add(part);
        //}
        //public void AppendMetaKeywordParts(params string[] parts)
        //{
        //    if (parts != null)
        //        foreach (string part in parts)
        //            if (!string.IsNullOrEmpty(part))
        //                _metaKeywordParts.Insert(0, part);
        //}
        //public string GenerateMetaKeywords()
        //{
        //    var metaKeyword = string.Join(", ", _metaKeywordParts.AsEnumerable().Reverse().ToArray());
        //    var result = !String.IsNullOrEmpty(metaKeyword) ? metaKeyword : _seoSettings.DefaultMetaKeywords;
        //    return result;
        //}


        public void AddScriptParts(ResourceLocation location, params string[] parts)
        {
            if (!_scriptParts.ContainsKey(location))
                _scriptParts.Add(location, new List<string>());

            if (parts != null)
                foreach (string part in parts)
                    if (!string.IsNullOrEmpty(part))
                        _scriptParts[location].Add(part);
        }
        public void AppendScriptParts(ResourceLocation location, params string[] parts)
        {
            if (!_scriptParts.ContainsKey(location))
                _scriptParts.Add(location, new List<string>());

            if (parts != null)
                foreach (string part in parts)
                    if (!string.IsNullOrEmpty(part))
                        _scriptParts[location].Insert(0, part);
        }
        public string GenerateScripts(UrlHelper urlHelper, ResourceLocation location)
        {
            if (!_scriptParts.ContainsKey(location) || _scriptParts[location] == null)
                return "";

            var result = new StringBuilder();
            //use only distinct rows
            foreach (var scriptPath in _scriptParts[location].Distinct())
            {
                result.AppendFormat("<script src=\"{0}\" type=\"text/javascript\"></script>", urlHelper.Content(scriptPath));
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }


        public void AddCssFileParts(ResourceLocation location, params string[] parts)
        {
            if (!_cssParts.ContainsKey(location))
                _cssParts.Add(location, new List<string>());

            if (parts != null)
                foreach (string part in parts)
                    if (!string.IsNullOrEmpty(part))
                        _cssParts[location].Add(part);
        }
        public void AppendCssFileParts(ResourceLocation location, params string[] parts)
        {
            if (!_cssParts.ContainsKey(location))
                _cssParts.Add(location, new List<string>());

            if (parts != null)
                foreach (string part in parts)
                    if (!string.IsNullOrEmpty(part))
                        _cssParts[location].Insert(0, part);
        }
        public string GenerateCssFiles(UrlHelper urlHelper, ResourceLocation location)
        {
            if (!_cssParts.ContainsKey(location) || _cssParts[location] == null)
            { return ""; }

            var result = new StringBuilder();
            //use only distinct rows
            foreach (var cssPath in _cssParts[location].Distinct())
            {
                result.AppendFormat("<link href=\"{0}\" rel=\"stylesheet\" type=\"text/css\" />", urlHelper.Content(cssPath));
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }


        //public void AddCanonicalUrlParts(params string[] parts)
        //{
        //    if (parts != null)
        //        foreach (string part in parts)
        //            if (!string.IsNullOrEmpty(part))
        //                _canonicalUrlParts.Add(part);
        //}
        //public void AppendCanonicalUrlParts(params string[] parts)
        //{
        //    if (parts != null)
        //        foreach (string part in parts)
        //            if (!string.IsNullOrEmpty(part))
        //                _canonicalUrlParts.Insert(0, part);
        //}
        //public string GenerateCanonicalUrls()
        //{
        //    var result = new StringBuilder();
        //    foreach (var canonicalUrl in _canonicalUrlParts)
        //    {
        //        result.AppendFormat("<link rel=\"canonical\" href=\"{0}\" />", canonicalUrl);
        //        result.Append(Environment.NewLine);
        //    }
        //    return result.ToString();
        //} 

        public void AddFileContentParts(params string[] parts)
        {
            if (parts != null)
                foreach (string part in parts)
                    if (!string.IsNullOrEmpty(part) && !_fileContentParts.Contains(part))
                        _fileContentParts.Add(part);
        }
        public string GenerateFileContents(HtmlHelper htmlHelper)
        {
            var result = new StringBuilder();
            foreach (var part in _fileContentParts)
            {
                
                result.Append(File.ReadAllText(AppContext.BaseDirectory+part));
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        } 
    }
}
