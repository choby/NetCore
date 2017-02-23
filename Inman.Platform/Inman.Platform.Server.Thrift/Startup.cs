using Inman.Platform.Data.Repository;
using Inman.Platform.Service;
using Inman.Platform.ServiceStub;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Inman.Platform.ThriftServer
{
    class Startup
    {
        static IConfigurationRoot configuration;
        static Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)//env.ContentRootPath
                .AddJsonFile("serversettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{AppContext.BaseDirectory}.json", optional: true)//env.EnvironmentName
                .AddEnvironmentVariables();
            configuration = builder.Build();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            
            //注入
            services.AddTransient(typeof(Database), sp => new Database(new SqlConnection(configuration.GetSection("dbConn").Value)));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
          

            services.AddTransient<ProductAsyncHandler, ProductAsyncHandler>();
            services.AddTransient<GoodsAsyncHandler, GoodsAsyncHandler>();
        }
    }
}
