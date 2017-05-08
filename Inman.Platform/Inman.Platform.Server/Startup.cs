using Inman.Infrastructure.Data.Repositories;
using Inman.Platform.Service;
using Inman.Platform.ServiceStub;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetaPoco.NetCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using static Inman.Platform.ServiceStub.UserService;
using static Inman.Platform.ServiceStub.StockItemService;
using static Inman.Platform.ServiceStub.ProductService;
using System.Data;

namespace Inman.Platform.Server
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
            //services.AddTransient(typeof(Database), sp => new Database(new SqlConnection(configuration.GetSection("dbConn").Value)));
            services.AddTransient(typeof(IDbConnection), sp => new SqlConnection(configuration.GetSection("dbConn").Value));
            services.AddTransient(typeof(IDapperRepository<,>), typeof(DapperRepository<,>));
            services.AddTransient<UserServiceBase, UserServiceImpl>();
            services.AddTransient<ProductServiceBase, ProductServiceImpl>();
           
        }
    }
}
