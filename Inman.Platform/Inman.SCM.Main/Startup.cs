using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IdentityModel.Tokens.Jwt;
using static Inman.Platform.ServiceStub.StockItemService;
using Grpc.Core;
using static Inman.Platform.ServiceStub.ProductService;
using static Inman.Platform.ServiceStub.GoodsService;
using System.IO;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Threading;

namespace Inman.SCM
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
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
        public void ConfigureServices(IServiceCollection services)
        {
            //使用openssl证书
            //证书保存可以是磁盘文件，也可以是数据库记录
            var cacert = File.ReadAllText("OpenSSL/ca.crt");
            var clientcert = File.ReadAllText("OpenSSL/client.crt");
            var clientkey = File.ReadAllText("OpenSSL/client.key");
            var ssl = new SslCredentials(cacert, new KeyCertificatePair(clientcert, clientkey));
            //创建使用证书的通信管道
            //使用加密证书时，服务器只能使用URI或者机器名，直接使用IP会抛异常提示找不到服务端
            services.AddSingleton(typeof(Channel), sp => new Channel("IOM_SERVER", 50052, ssl)); //生命周期使用单例
            services.AddTransient(typeof(StockItemServiceClient), typeof(StockItemServiceClient));
            services.AddTransient(typeof(ProductServiceClient), typeof(ProductServiceClient));
            services.AddTransient(typeof(GoodsServiceClient), typeof(GoodsServiceClient));

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // Add framework services.
            services.AddMvc();


            //自定义依赖注入容器
            //var containerBuilder = new ContainerBuilder();
            ////containerBuilder.RegisterModule<DefaultModule>();
            //containerBuilder.Populate(services);
            //var container = containerBuilder.Build();

            //return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,
            IServiceProvider svp)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
            
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
                AuthenticationScheme = "oidc",//使用openid认证方式
                SignInScheme = "Cookies",

                Authority = "http://localhost:5000",//身份认证中心地址，通常可以理解为SSO站点
                RequireHttpsMetadata = false,//是否使用加密的http（https）协议
                
                ClientId = "mvc",//应用标识
                ClientSecret = "secret",//应用密钥

                ResponseType = "code id_token",//
                Scope = { "openid", "profile", "role" },//请求的使用范围"api1", "offline_access","openid","profile", "nickname" 默认：openid,profile

                GetClaimsFromUserInfoEndpoint = true, // 从用户信息节点获取信息，如果为false，则需要代码手动获取
                SaveTokens = true
            });

            app.UseStaticFiles();

            //配置路由
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseStatusCodePages();//在默认情况下，应用程序无法为Http状态码返回（例如：500 (服务器内部错误) or 404 (文件无法找到)）提供一个富文本的HTTP状态码页面。
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
    }
}
