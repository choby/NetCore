using Grpc.Core;
using Inman.Platform.Server;
using Inman.Platform.Service;
using Inman.Platform.ServiceStub;
using Microsoft.Extensions.DependencyInjection;
using System;
using static Inman.Platform.ServiceStub.StockItemService;
using static Inman.Platform.ServiceStub.UserService;
using static Inman.Platform.ServiceStub.ProductService;
using static Inman.Platform.ServiceStub.GoodsService;
using System.IO;
using System.Collections.Generic;

class Program
{
    static IServiceProvider serviceProvider;
    static void Main(string[] args)
    {
        IServiceCollection services = new ServiceCollection();
        Startup.ConfigureServices(services);
        serviceProvider = services.BuildServiceProvider();

        const int Port = 50052;
        
        var cacert = File.ReadAllText("OpenSSL/ca.crt");
        var servercert = File.ReadAllText("OpenSSL/server.crt");
        var serverkey = File.ReadAllText("OpenSSL/server.key");
        var keypair = new KeyCertificatePair(servercert, serverkey);
        var sslCredentials = new SslServerCredentials(new List<KeyCertificatePair>() { keypair }, cacert, false);

        Server server = new Server
        {
            Services = {
                UserService.BindService(serviceProvider.GetService<UserServiceBase>()),
                StockItemService.BindService(serviceProvider.GetService<StockItemServiceBase>()),
                 ProductService.BindService(serviceProvider.GetService<ProductServiceBase>()),
                  GoodsService.BindService(serviceProvider.GetService<GoodsServiceBase>())
            },
            Ports = { new ServerPort("IOM_SERVER", Port, sslCredentials) }
        };
        server.Start();

        //Console.WriteLine("RouteGuide server listening on port " + Port);
        Console.WriteLine("Press any key to stop the server...");
        Console.ReadKey();

        server.ShutdownAsync().Wait();
    }
}