using Inman.Infrastructure.Common.IOC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Inman.Infrastructure.Web.Middleware;

namespace Inman.SCM
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddJsonFile("hosting.json", optional: true)
                .AddEnvironmentVariables();

            //if (env.IsDevelopment())
            //{
            //    // For more details on using the user secret store see http://go.microsoft.com/fwlink/?LinkID=532709
            //    builder.AddUserSecrets();
            //}

            Configuration = builder.Build();

        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)//IServiceProvider
        {

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region thrift
            //var transport = new TTlsSocketClientTransport(IPAddress.Parse("192.168.7.213"), 9090, GetCertificate(), CertValidator, LocalCertificateSelectionCallback);
            //var transport = new TSocketClientTransport(IPAddress.Parse("192.168.7.213"), 9090);

            //var protocols = new Tuple<Protocol, TProtocol>[1];
            //protocols[0] = new Tuple<Protocol, TProtocol>(Protocol.Multiplexed, new TBinaryProtocol(transport));
            //var protocol = protocols[0];
            //services.AddSingleton(typeof(ProductService.Client), sp =>
            //{
            //    var multiplex = new TMultiplexedProtocol(protocol.Item2, nameof(ProductService));
            //    return new ProductService.Client(multiplex);
            //});

            //services.AddSingleton(typeof(GoodsService.Client), sp =>
            //{
            //    var multiplex = new TMultiplexedProtocol(protocol.Item2, nameof(GoodsService));
            //    return new GoodsService.Client(multiplex);
            //});


            //services.AddTransient(typeof(ServiceStub.ProductRequest), sp =>
            //{

            //});

            #endregion

            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();

            // Add framework services.
            services.AddMvc()
                .AddControllersAsServices()
                .AddJsonOptions(option =>
                {
                    
                    option.SerializerSettings.DateFormatString = "yyyy-MM-dd";
                    option.SerializerSettings.ContractResolver = new DefaultContractResolver();// new CamelCasePropertyNamesContractResolver();
                });

            //add kendo ui
            services.AddKendo();
            // Adds a default in-memory implementation of IDistributedCache.
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.CookieHttpOnly = true;
                options.CookieName = "inman.scm.sessionid";
            });

            //services.AddAuthorization();

            return services.AddAutofac();
        }
       

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,
            IServiceProvider svp)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            //loggerFactory.
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
           

            if (env.IsDevelopment()) //环境变量中包含“ASPNETCORE_ENVIRONMENT”并且值为Development
            {
                app.UseDeveloperExceptionPage();//开发环境中，显示详细的异常信息。
                //app.UseDatabaseErrorPage();
                //app.UseBrowserLink();
               
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");//生产环境中，显示友好的错误提示页面，并记录日志。
            }

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationScheme = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectOptions
            {
                AuthenticationScheme = "oidc",//使用简化模式(OpenID Connect)认证方式 客户端确定 URL（用户认证服务），登录在用户认证服务，验证成功，返回客户端想要的用户数据，并使此用户为登录状态，可以在客户端进行注销用户。
                SignInScheme = "Cookies",
                
                Authority = "http://localhost:5000",//身份认证中心地址，通常可以理解为SSO站点
                RequireHttpsMetadata = false,//是否使用加密的http（https）协议
                
                ClientId = "mvc",//应用标识
                ClientSecret = "secret",//应用密钥

                ResponseType = "code id_token",//
                Scope = { "api1", "openid", "profile", "role" },//请求的使用范围"api1", "offline_access","openid","profile", "nickname" 默认：openid,profile
                
                GetClaimsFromUserInfoEndpoint = true, // 从用户信息节点获取信息，如果为false，则需要代码手动获取
                SaveTokens = true,//使用简单模式时，必须设置SaveTokens=true
                UseTokenLifetime = true
            });

            app.UseStaticFiles();
            app.UseSession();
            //配置路由
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            
            app.UseStatusCodePages();//在默认情况下，应用程序无法为Http状态码返回（例如：500 (服务器内部错误) or 404 (文件无法找到)）提供一个富文本的HTTP状态码页面。
            app.UseCustomErrorPages();//定义在Inman.Infrastructure.Web中
            //app.UseStatusCodePages(handler:options=>
            //                        options.HttpContext.Response.SendAsync("Handler, status code: " +
            //                        options.HttpContext.Response.StatusCode, "text/plain")); //中间件提供不同的扩展方法，也可以使用自定义lambda表达式来配置参数
            //app.UseStatusCodePages("text/plain", "Response, status code: {0}"); //也可以简单的传递一个内容类型和格式化字符串:
            //app.UseStatusCodePagesWithRedirects("~/errors/{0}");//中间件也能处理重定向请求 (无论是绝对路径还是相对路径), 把状态码作为URL的一部分进行传递, 客户端浏览器遇到 302 / Found状态码返回时，会重定向到指定的页面.
            //app.UseStatusCodePagesWithReExecute("/errors/{0}");//中间件也提供设置一个新的路径字符串的方式来重新执行请求,方法 UseStatusCodePagesWithReExecute 会返回原始的浏览器状态码页面，但是也会执行路径中指定的处理程序。
            //如果需要对某些请求禁止状态码页面, 可以使用以下代码
            //var statusCodePagesFeature = svp.GetService<IStatusCodePagesFeature>();
            //if (statusCodePagesFeature != null)
            //{
            //    statusCodePagesFeature.Enabled = false;
            //}
        }

        #region thrift
        private static X509Certificate2 GetCertificate()
        {
            // due to files location in net core better to take certs from top folder
            var certFile = GetCertPath(Directory.GetParent(Directory.GetCurrentDirectory()));
            return new X509Certificate2(certFile, "ThriftTest");
        }
        private static bool CertValidator(object sender, X509Certificate certificate,
            X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        private static string GetCertPath(DirectoryInfo di, int maxCount = 6)
        {
            var topDir = di;
            var certFile =
                topDir.EnumerateFiles("ThriftTest.pfx", SearchOption.AllDirectories)
                    .FirstOrDefault();
            if (certFile == null)
            {
                if (maxCount == 0)
                    throw new FileNotFoundException("Cannot find file in directories");
                return GetCertPath(di.Parent, maxCount - 1);
            }

            return certFile.FullName;
        }
        private static X509Certificate LocalCertificateSelectionCallback(object sender,
           string targetHost, X509CertificateCollection localCertificates,
           X509Certificate remoteCertificate, string[] acceptableIssuers)
        {
            return GetCertificate();
        }
        private enum Protocol
        {
            Binary,
            Compact,
            Json,
            Multiplexed
        }
        private enum Transport
        {
            Tcp,
            NamedPipe,
            Http,
            TcpBuffered,
            Framed,
            TcpTls
        }
        #endregion
    }
    
}
