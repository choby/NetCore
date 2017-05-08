using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Primitives;

namespace Inman.Infrastructure.Web
{
    /// <summary>
    /// Represents a common helper
    /// </summary>
    public partial class WebHelper : IWebHelper
    {
        private readonly IHostingEnvironment _environment;
        private readonly HttpContext _httpContext;
        private readonly ApplicationEnvironment _appEnvironment;
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="httpContext">HTTP context</param>
        public WebHelper(HttpContext httpContext, IHostingEnvironment environment
            , ApplicationEnvironment appEnvironment)
        {
            this._environment = environment;
            this._httpContext = httpContext;
            this._appEnvironment = appEnvironment;
        }

        /// <summary>
        /// Get URL referrer
        /// </summary>
        /// <returns>URL referrer</returns>
        public virtual string GetUrlReferrer()
        {
            string referrerUrl = string.Empty;

            //URL referrer is null in some case (for example, in IE 8)
            //if (_httpContext != null &&
            //    _httpContext.Request != null &&
            //    _httpContext.Request.UrlReferrer != null)
            //    referrerUrl = _httpContext.Request.UrlReferrer.PathAndQuery;
            //see more:http://stackoverflow.com/questions/38772394/how-can-i-get-url-referrer-in-asp-net-core-mvc
            if (_httpContext != null &&
                _httpContext.Request != null &&
                _httpContext.Request.Headers["Referer"] != StringValues.Empty)
                referrerUrl = _httpContext.Request.Headers["Referer"].ToString();

            return referrerUrl;
        }

        /// <summary>
        /// Get context IP address
        /// </summary>
        /// <returns>URL referrer</returns>
        public virtual string GetCurrentIpAddress()
        {
            if (_httpContext == null || _httpContext.Request == null)
                return string.Empty;

            if (_httpContext.Request.Headers != null)
            {
                //look for the X-Forwarded-For (XFF) HTTP header field
                //it's used for identifying the originating IP address of a client connecting to a web server through an HTTP proxy or load balancer. 
                string xff = _httpContext.Request.Headers.Keys
                    .Where(x => "X-FORWARDED-FOR".Equals(x, StringComparison.CurrentCultureIgnoreCase))
                    .Select(k => _httpContext.Request.Headers[k])
                    .FirstOrDefault();

                //if you want to exclude private IP addresses, then see http://stackoverflow.com/questions/2577496/how-can-i-get-the-clients-ip-address-in-asp-net-mvc

                if (!String.IsNullOrEmpty(xff))
                {
                    string lastIp = xff.Split(new char[] { ',' }).FirstOrDefault();
                    if (!String.IsNullOrEmpty(lastIp))
                    {
                        return lastIp;
                    }
                }
            }

            //if (_httpContext.Request.UserHostAddress != null)
            //{
            //    return _httpContext.Request.UserHostAddress;
            //}
            //see more:http://stackoverflow.com/questions/27132908/userhostaddress-in-asp-net-core
            if (_httpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress != null)
                return _httpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress.ToString();
            return string.Empty;
        }

        ///// <summary>
        ///// Gets this page name
        ///// </summary>
        ///// <param name="includeQueryString">Value indicating whether to include query strings</param>
        ///// <returns>Page name</returns>
        //public virtual string GetThisPageUrl(bool includeQueryString)
        //{
        //    bool useSsl = IsCurrentConnectionSecured();
        //    return GetThisPageUrl(includeQueryString, useSsl);
        //}

        ///// <summary>
        ///// Gets this page name
        ///// </summary>
        ///// <param name="includeQueryString">Value indicating whether to include query strings</param>
        ///// <param name="useSsl">Value indicating whether to get SSL protected page</param>
        ///// <returns>Page name</returns>
        //public virtual string GetThisPageUrl(bool includeQueryString, bool useSsl)
        //{
        //    string url = string.Empty;
        //    if (_httpContext == null || _httpContext.Request == null)
        //        return url;

        //    if (includeQueryString)
        //    {
        //        string storeHost = GetStoreHost(useSsl);
        //        if (storeHost.EndsWith("/"))
        //            storeHost = storeHost.Substring(0, storeHost.Length - 1);
        //        url = storeHost + _httpContext.Request.RawUrl;
        //    }
        //    else
        //    {
        //        if (_httpContext.Request.Url != null)
        //        {
        //            url = _httpContext.Request.Url.GetLeftPart(UriPartial.Path);
        //        }
        //    }
        //    url = url.ToLowerInvariant();
        //    return url;
        //}

        ///// <summary>
        ///// Gets a value indicating whether current connection is secured
        ///// </summary>
        ///// <returns>true - secured, false - not secured</returns>
        //public virtual bool IsCurrentConnectionSecured()
        //{
        //    bool useSsl = false;
        //    if (_httpContext != null && _httpContext.Request != null)
        //    {
        //        useSsl = _httpContext.Request.IsHttps;
        //        //when your hosting uses a load balancer on their server then the Request.IsSecureConnection is never got set to true, use the statement below
        //        //just uncomment it
        //        //useSSL = _httpContext.Request.ServerVariables["HTTP_CLUSTER_HTTPS"] == "on" ? true : false;
        //    }

        //    return useSsl;
        //}

        /////// <summary>
        /////// Gets server variable by name
        /////// </summary>
        /////// <param name="name">Name</param>
        /////// <returns>Server variable</returns>
        ////public virtual string ServerVariables(string name)
        ////{
        ////    string result = string.Empty;

        ////    try
        ////    {
        ////        if (_httpContext == null || _httpContext.Request == null)
        ////            return result;

        ////        //put this method is try-catch 
        ////        //as described here http://www.nopcommerce.com/boards/t/21356/multi-store-roadmap-lets-discuss-update-done.aspx?p=6#90196
        ////        if (_httpContext.Request.ServerVariables[name] != null)
        ////        {
        ////            result = _httpContext.Request.ServerVariables[name];
        ////        }
        ////    }
        ////    catch
        ////    {
        ////        result = string.Empty;
        ////    }
        ////    return result;
        ////}

        ///// <summary>
        ///// Gets store host location
        ///// </summary>
        ///// <param name="useSsl">Use SSL</param>
        ///// <returns>Store host location</returns>
        //public virtual string GetStoreHost(bool useSsl)
        //{
        //    var result = "";
        //    var httpHost = ServerVariables("HTTP_HOST");
        //    if (!String.IsNullOrEmpty(httpHost))
        //    {
        //        result = "http://" + httpHost;
        //        if (!result.EndsWith("/"))
        //            result += "/";
        //    }

        //    //if (DataSettingsHelper.DatabaseIsInstalled())
        //    //{
        //    //    #region Database is installed

        //    //    //let's resolve IWorkContext  here.
        //    //    //Do not inject it via contructor because it'll cause circular references
        //    //    var storeContext = EngineContext.Current.Resolve<IStoreContext>();
        //    //    var currentStore = storeContext.CurrentStore;
        //    //    if (currentStore == null)
        //    //        throw new Exception("Current store cannot be loaded");

        //    //    if (String.IsNullOrWhiteSpace(httpHost))
        //    //    {
        //    //        //HTTP_HOST variable is not available.
        //    //        //This scenario is possible only when HttpContext is not available (for example, running in a schedule task)
        //    //        //in this case use URL of a store entity configured in admin area
        //    //        result = currentStore.Url;
        //    //        if (!result.EndsWith("/"))
        //    //            result += "/";
        //    //    }

        //    //    if (useSsl)
        //    //    {
        //    //        if (!String.IsNullOrWhiteSpace(currentStore.SecureUrl))
        //    //        {
        //    //            //Secure URL specified. 
        //    //            //So a store owner don't want it to be detected automatically.
        //    //            //In this case let's use the specified secure URL
        //    //            result = currentStore.SecureUrl;
        //    //        }
        //    //        else
        //    //        {
        //    //            //Secure URL is not specified.
        //    //            //So a store owner wants it to be detected automatically.
        //    //            result = result.Replace("http:/", "https:/");
        //    //        }
        //    //    }
        //    //    else
        //    //    {
        //    //        if (currentStore.SslEnabled && !String.IsNullOrWhiteSpace(currentStore.SecureUrl))
        //    //        {
        //    //            //SSL is enabled in this store and secure URL is specified.
        //    //            //So a store owner don't want it to be detected automatically.
        //    //            //In this case let's use the specified non-secure URL
        //    //            result = currentStore.Url;
        //    //        }
        //    //    }
        //    //    #endregion
        //    //}
        //    else
        //    {
        //        #region Database is not installed
        //        if (useSsl)
        //        {
        //            //Secure URL is not specified.
        //            //So a store owner wants it to be detected automatically.
        //            result = result.Replace("http:/", "https:/");
        //        }
        //        #endregion
        //    }


        //    if (!result.EndsWith("/"))
        //        result += "/";
        //    return result.ToLowerInvariant();
        //}

        ///// <summary>
        ///// Gets store location
        ///// </summary>
        ///// <returns>Store location</returns>
        //public virtual string GetStoreLocation()
        //{
        //    bool useSsl = IsCurrentConnectionSecured();
        //    return GetStoreLocation(useSsl);
        //}

        ///// <summary>
        ///// Gets store location
        ///// </summary>
        ///// <param name="useSsl">Use SSL</param>
        ///// <returns>Store location</returns>
        //public virtual string GetStoreLocation(bool useSsl)
        //{
        //    //return HostingEnvironment.ApplicationVirtualPath;

        //    string result = GetStoreHost(useSsl);
        //    if (result.EndsWith("/"))
        //        result = result.Substring(0, result.Length - 1);
        //    if (_httpContext != null && _httpContext.Request != null)
        //        result = result + _httpContext.Request.ApplicationPath;
        //    if (!result.EndsWith("/"))
        //        result += "/";

        //    return result.ToLowerInvariant();
        //}

        /// <summary>
        /// Returns true if the requested resource is one of the typical resources that needn't be processed by the cms engine.
        /// </summary>
        /// <param name="request">HTTP Request</param>
        /// <returns>True if the request targets a static resource file.</returns>
        /// <remarks>
        /// These are the file extensions considered to be static resources:
        /// .css
        ///	.gif
        /// .png 
        /// .jpg
        /// .jpeg
        /// .js
        /// .axd
        /// .ashx
        /// </remarks>
        public virtual bool IsStaticResource(HttpRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            string path = request.Path;
            string extension = path.Substring(path.LastIndexOf('.')); //VirtualPathUtility.GetExtension(path);
           
            if (extension == null) return false;

            switch (extension.ToLower())
            {
                case ".axd":
                case ".ashx":
                case ".bmp":
                case ".css":
                case ".gif":
                case ".htm":
                case ".html":
                case ".ico":
                case ".jpeg":
                case ".jpg":
                case ".js":
                case ".png":
                case ".rar":
                case ".zip":
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Maps a virtual path to a physical disk path.
        /// </summary>
        /// <param name="path">The path to map. E.g. "~/bin"</param>
        /// <returns>The physical path. E.g. "c:\inetpub\wwwroot\bin"</returns>
        public virtual string MapPath(string path)
        {
            //if (HostingEnvironment.IsHosted)
            //{
            //    //hosted
            //    return HostingEnvironment.MapPath(path);
            //}
            //else
            //{
            //not hosted. For example, run in unit tests
            //see more:https://blog.mariusschulz.com/2016/05/22/getting-the-web-root-path-and-the-content-root-path-in-asp-net-core
            string baseDirectory = _appEnvironment.ApplicationBasePath; //_environment.WebRootPath;
                path = path.Replace("~/", "").TrimStart('/').Replace('/', '\\');
                return Path.Combine(baseDirectory, path);
           // }
        }

        /// <summary>
        /// Modifies query string
        /// </summary>
        /// <param name="url">Url to modify</param>
        /// <param name="queryStringModification">Query string modification</param>
        /// <param name="anchor">Anchor</param>
        /// <returns>New url</returns>
        public virtual string ModifyQueryString(string url, string queryStringModification, string anchor)
        {
            if (url == null)
                url = string.Empty;
            url = url.ToLowerInvariant();

            if (queryStringModification == null)
                queryStringModification = string.Empty;
            queryStringModification = queryStringModification.ToLowerInvariant();

            if (anchor == null)
                anchor = string.Empty;
            anchor = anchor.ToLowerInvariant();


            string str = string.Empty;
            string str2 = string.Empty;
            if (url.Contains("#"))
            {
                str2 = url.Substring(url.IndexOf("#") + 1);
                url = url.Substring(0, url.IndexOf("#"));
            }
            if (url.Contains("?"))
            {
                str = url.Substring(url.IndexOf("?") + 1);
                url = url.Substring(0, url.IndexOf("?"));
            }
            if (!string.IsNullOrEmpty(queryStringModification))
            {
                if (!string.IsNullOrEmpty(str))
                {
                    var dictionary = new Dictionary<string, string>();
                    foreach (string str3 in str.Split(new char[] { '&' }))
                    {
                        if (!string.IsNullOrEmpty(str3))
                        {
                            string[] strArray = str3.Split(new char[] { '=' });
                            if (strArray.Length == 2)
                            {
                                dictionary[strArray[0]] = strArray[1];
                            }
                            else
                            {
                                dictionary[str3] = null;
                            }
                        }
                    }
                    foreach (string str4 in queryStringModification.Split(new char[] { '&' }))
                    {
                        if (!string.IsNullOrEmpty(str4))
                        {
                            string[] strArray2 = str4.Split(new char[] { '=' });
                            if (strArray2.Length == 2)
                            {
                                dictionary[strArray2[0]] = strArray2[1];
                            }
                            else
                            {
                                dictionary[str4] = null;
                            }
                        }
                    }
                    var builder = new StringBuilder();
                    foreach (string str5 in dictionary.Keys)
                    {
                        if (builder.Length > 0)
                        {
                            builder.Append("&");
                        }
                        builder.Append(str5);
                        if (dictionary[str5] != null)
                        {
                            builder.Append("=");
                            builder.Append(dictionary[str5]);
                        }
                    }
                    str = builder.ToString();
                }
                else
                {
                    str = queryStringModification;
                }
            }
            if (!string.IsNullOrEmpty(anchor))
            {
                str2 = anchor;
            }
            return (url + (string.IsNullOrEmpty(str) ? "" : ("?" + str)) + (string.IsNullOrEmpty(str2) ? "" : ("#" + str2))).ToLowerInvariant();
        }

        /// <summary>
        /// Remove query string from url
        /// </summary>
        /// <param name="url">Url to modify</param>
        /// <param name="queryString">Query string to remove</param>
        /// <returns>New url</returns>
        public virtual string RemoveQueryString(string url, string queryString)
        {
            if (url == null)
                url = string.Empty;
            url = url.ToLowerInvariant();

            if (queryString == null)
                queryString = string.Empty;
            queryString = queryString.ToLowerInvariant();


            string str = string.Empty;
            if (url.Contains("?"))
            {
                str = url.Substring(url.IndexOf("?") + 1);
                url = url.Substring(0, url.IndexOf("?"));
            }
            if (!string.IsNullOrEmpty(queryString))
            {
                if (!string.IsNullOrEmpty(str))
                {
                    var dictionary = new Dictionary<string, string>();
                    foreach (string str3 in str.Split(new char[] { '&' }))
                    {
                        if (!string.IsNullOrEmpty(str3))
                        {
                            string[] strArray = str3.Split(new char[] { '=' });
                            if (strArray.Length == 2)
                            {
                                dictionary[strArray[0]] = strArray[1];
                            }
                            else
                            {
                                dictionary[str3] = null;
                            }
                        }
                    }
                    dictionary.Remove(queryString);

                    var builder = new StringBuilder();
                    foreach (string str5 in dictionary.Keys)
                    {
                        if (builder.Length > 0)
                        {
                            builder.Append("&");
                        }
                        builder.Append(str5);
                        if (dictionary[str5] != null)
                        {
                            builder.Append("=");
                            builder.Append(dictionary[str5]);
                        }
                    }
                    str = builder.ToString();
                }
            }
            return (url + (string.IsNullOrEmpty(str) ? "" : ("?" + str)));
        }
        
        /// <summary>
        /// Gets query string value by name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">Parameter name</param>
        /// <returns>Query string value</returns>
        public virtual T QueryString<T>(string name)
        {
            string queryParam = null;
            if (_httpContext != null && _httpContext.Request.Query[name].Any())
                queryParam = _httpContext.Request.Query[name];

            if (!String.IsNullOrEmpty(queryParam))
                return CommonHelper.To<T>(queryParam);
            
            return default(T);
        }
        
        ///// <summary>
        ///// Restart application domain
        ///// </summary>
        ///// <param name="makeRedirect">A value indicating whether </param>
        ///// <param name="redirectUrl">Redirect URL; empty string if you want to redirect to the current page URL</param>
        //public virtual void RestartAppDomain(bool makeRedirect = false, string redirectUrl = "")
        //{
        //    if (CommonHelper.GetTrustLevel() > AspNetHostingPermissionLevel.Medium)
        //    {
        //        //full trust
        //        HttpRuntime.UnloadAppDomain();

        //        TryWriteGlobalAsax();
        //    }
        //    else
        //    {
        //        //medium trust
        //        bool success = TryWriteWebConfig();
        //        if (!success)
        //        {
        //            throw new CustomException("nopCommerce needs to be restarted due to a configuration change, but was unable to do so." + Environment.NewLine +
        //                "To prevent this issue in the future, a change to the web server configuration is required:" + Environment.NewLine + 
        //                "- run the application in a full trust environment, or" + Environment.NewLine +
        //                "- give the application write access to the 'web.config' file.");
        //        }

        //        success = TryWriteGlobalAsax();
        //        if (!success)
        //        {
        //            throw new CustomException("nopCommerce needs to be restarted due to a configuration change, but was unable to do so." + Environment.NewLine +
        //                "To prevent this issue in the future, a change to the web server configuration is required:" + Environment.NewLine +
        //                "- run the application in a full trust environment, or" + Environment.NewLine +
        //                "- give the application write access to the 'Global.asax' file.");
        //        }
        //    }

        //    // If setting up extensions/modules requires an AppDomain restart, it's very unlikely the
        //    // current request can be processed correctly.  So, we redirect to the same URL, so that the
        //    // new request will come to the newly started AppDomain.
        //    if (_httpContext != null && makeRedirect)
        //    {
        //        if (String.IsNullOrEmpty(redirectUrl))
        //            redirectUrl = GetThisPageUrl(true);
        //        _httpContext.Response.Redirect(redirectUrl, true /*endResponse*/);
        //    }
        //}

        //private bool TryWriteWebConfig()
        //{
        //    try
        //    {
        //        // In medium trust, "UnloadAppDomain" is not supported. Touch web.config
        //        // to force an AppDomain restart.
        //        File.SetLastWriteTimeUtc(MapPath("~/web.config"), DateTime.UtcNow);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

     

        ///// <summary>
        ///// Get a value indicating whether the request is made by search engine (web crawler)
        ///// </summary>
        ///// <param name="context">HTTP context</param>
        ///// <returns>Result</returns>
        //public virtual bool IsSearchEngine(HttpContext context)
        //{
        //    //we accept HttpContext instead of HttpRequest and put required logic in try-catch block
        //    //more info: http://www.nopcommerce.com/boards/t/17711/unhandled-exception-request-is-not-available-in-this-context.aspx
        //    if (context == null)
        //        return false;

        //    bool result = false;
        //    try
        //    {
        //        result = context.Request.Crawler;
        //        if (!result)
        //        {
        //            //put any additional known crawlers in the Regex below for some custom validation
        //            //var regEx = new Regex("Twiceler|twiceler|BaiDuSpider|baduspider|Slurp|slurp|ask|Ask|Teoma|teoma|Yahoo|yahoo");
        //            //result = regEx.Match(request.UserAgent).Success;
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        Debug.WriteLine(exc);
        //    }
        //    return result;
        //}

        ///// <summary>
        ///// Gets a value that indicates whether the client is being redirected to a new location
        ///// </summary>
        //public virtual bool IsRequestBeingRedirected
        //{
        //    get
        //    {
        //        var response = _httpContext.Response;
        //        return response.IsRequestBeingRedirected;   
        //    }
        //}

        /// <summary>
        /// Gets or sets a value that indicates whether the client is being redirected to a new location using POST
        /// </summary>
        public virtual bool IsPostBeingDone
        {
            get
            {
                if (_httpContext.Items["nop.IsPOSTBeingDone"] == null)
                    return false;
                return Convert.ToBoolean(_httpContext.Items["nop.IsPOSTBeingDone"]);
            }
            set
            {
                _httpContext.Items["nop.IsPOSTBeingDone"] = value;
            }
        }
        /// <summary>
        /// 判断当前请求是否是ajax请求
        /// </summary>
        /// <returns></returns>
        public virtual bool IsAjaxRequest()
        {
            return _httpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }
        //public virtual string ServerOSVersion
        //{
        //    get
        //    {
        //        return Environment.OSVersion.ToString();
        //    }
        //}
        //public virtual string ServerSystemDirectory
        //{
        //    get { return Environment.SystemDirectory; }
        //}

        //public virtual int ScriptTimeout
        //{
        //    get { return _httpContext.Server.ScriptTimeout; }
        //}
        //public virtual string InstalledUICulture
        //{
        //    get { return CultureInfo.InstalledUICulture.EnglishName; }
        //}
        //public virtual string DotNetVersion
        //{
        //    get { return $"{Environment.Version.Major}.{Environment.Version.Minor}.{Environment.Version.Build}.{Environment.Version.Revision}"; }
        //}
        public virtual int TickCount
        {
            get { return (Environment.TickCount / 0x3e8) / 60; }
        }
        public virtual string NumberOfProcessors
        {
            get { return Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS"); }
        }
        public virtual string ProcessorIdentifier
        {
            get { return Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER"); }
        }
        //public virtual double WorkingMemory
        //{
        //    get { return ((Double)Process.GetCurrentProcess().WorkingSet64 / 1048576); }
        //}
        //public virtual double ProcessorTime
        //{
        //    get { return ((TimeSpan)Process.GetCurrentProcess().TotalProcessorTime).TotalSeconds; }
        //}
        //public virtual string SystemUserName
        //{
        //    get { return Environment.UserName; }
        //}
    }
}
