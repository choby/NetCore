using Grpc.Core;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using Inman.IdentityServer.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PetaPoco.NetCore;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using static Inman.Platform.ServiceStub.UserService;

namespace Inman.IdentityServer
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
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            //Configuration.GetSection("connectionStringName")
            // Add framework services.
            services.AddMvc();
            //services.AddIdentity<>();
            //services.add
            services.AddTransient(typeof(Database), sp => new Database(new SqlConnection(Configuration.GetSection("dbConn").Value)));

            //使用openssl证书
            //证书保存可以是磁盘文件，也可以是数据库记录
            var cacert = File.ReadAllText("OpenSSL/ca.crt");
            var clientcert = File.ReadAllText("OpenSSL/client.crt");
            var clientkey = File.ReadAllText("OpenSSL/client.key");
            var ssl = new SslCredentials(cacert, new KeyCertificatePair(clientcert, clientkey));
           // 创建使用证书的通信管道
            //使用加密证书时，服务器只能使用URI或者机器名，直接使用IP会抛异常提示找不到服务端
            services.AddSingleton(typeof(Channel), sp => new Channel("IOM_SERVER", 50052, ssl)); //生命周期使用单例

            services.AddTransient(typeof(UserServiceClient), typeof(UserServiceClient));

            services.AddTransient(typeof(IRepository<>),typeof(Repository<>));
            services.AddTransient<IClientStore, ClientStore>();
            services.AddTransient<IResourceStore, ResourceStore>();
            
            //配置identityserver4注入
            services.AddIdentityServer().AddTemporarySigningCredential();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            //identityserver4
            app.UseIdentityServer();

            app.UseStaticFiles();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseMvcWithDefaultRoute();
        }
    }
}
