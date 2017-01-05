using Grpc.Core;
using Inman.Platform.Data.Repository;
using Inman.Platform.Server;
using Inman.Platform.Service;
using Inman.Platform.ServiceStub;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetaPoco.NetCore;
using System;
using System.Data.SqlClient;
using static Inman.Platform.ServiceStub.UserService;

class Program
{
    static IServiceProvider serviceProvider;
    static void Main(string[] args)
    {
        IServiceCollection services = new ServiceCollection();
        Startup.ConfigureServices(services);
        serviceProvider = services.BuildServiceProvider();

        const int Port = 50052;
        
        Server server = new Server
        {
            Services = { UserService.BindService(serviceProvider.GetService<UserServiceBase>()) },
            Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
        };
        server.Start();

        Console.WriteLine("RouteGuide server listening on port " + Port);
        Console.WriteLine("Press any key to stop the server...");
        Console.ReadKey();

        server.ShutdownAsync().Wait();
    }
}