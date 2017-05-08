using Inman.Infrastructure.Data.Repositories;
using Inman.Platform.Service;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Data.SqlClient;
using static Inman.Platform.ServiceStub.ProductService;
using System.Data;
using Inman.Platform.ServiceStub;
using Inman.Platform.ServiceStub.Data;
using Foundatio.Messaging;
//using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Inman.Platform.ServiceImpl.Test
{

    [TestClass]
    public class ProductServiceImplTest
    {
        static IConfigurationRoot configuration;
        static IServiceProvider serviceProvider;
        public ProductServiceImplTest()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)//env.ContentRootPath
                .AddJsonFile("serversettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{AppContext.BaseDirectory}.json", optional: true)//env.EnvironmentName
                .AddEnvironmentVariables();
            configuration = builder.Build();

            IServiceCollection services = new ServiceCollection();
            services.AddTransient(typeof(IDbConnection), sp => new SqlConnection(configuration.GetSection("dbConn").Value));
            services.AddTransient(typeof(IDapperRepository<,>), typeof(DapperRepository<,>));
            services.AddTransient<ProductServiceBase, ProductServiceImpl>();
            serviceProvider = services.BuildServiceProvider();
        }
       // [Fact]
        [TestMethod]
        public void TestGetProductList()
        {
            var productServiceImpl = serviceProvider.GetService<ProductServiceBase>();
            var productRequest = new ProductRequest()
            {
                Page = 1,
                PageSize = 15,
                DemandDescriptor = new DemandDescriptor { Filter = "" }
            };
           var result =  productServiceImpl.GetProductList(productRequest, null);
            Assert.IsNotNull(result);
        }

        //[Fact]
        [TestMethod]
        public async System.Threading.Tasks.Task TestRabbitMqAsync()
        {
            //var factory =  new RabbitMQ.Client.ConnectionFactory();
            // factory.CreateConnection()
            string connection = "amqp://guest:guest@127.0.0.1:5672";
            var messageBus = new RabbitMQMessageBus(connection, "testQueue", "testExchange");
            
            SimpleMessageA s = null;
            await messageBus.SubscribeAsync<SimpleMessageA>(msg1 =>
            {
                s = msg1;
            });
            var args = new Dictionary<string, object> { { "x-delayed-type", "" } };
            await messageBus.PublishAsync(new SimpleMessageA { Data = "消息" });
            
            var msg = messageBus.SubscribeAsync<SimpleMessageA>(msg2 =>
            {
                s = msg2;
            });
            
        }
        class SimpleMessageA
        {
           public string Data { get; set; }
        }
    }
}
