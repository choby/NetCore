using Grpc.Core;
using Inman.Platform.Server;
using Inman.Platform.Service;
using Inman.Platform.ServiceStub;
using Microsoft.Extensions.DependencyInjection;
using System;
using static Inman.Platform.ServiceStub.StockItemService;
using static Inman.Platform.ServiceStub.UserService;
using static Inman.Platform.ServiceStub.ProductService;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Loader;
using System.Reflection;

class Program
{
    static IServiceProvider serviceProvider;
    static void Main(string[] args)
    {
       // AssemblyLoadContext.Default.Resolving += new Resolver(Directory.GetCurrentDirectory()).Resolving;

        IServiceCollection services = new ServiceCollection();
        Startup.ConfigureServices(services);
        serviceProvider = services.BuildServiceProvider();

        const int Port = 50052;
        
        var cacert = File.ReadAllText("OpenSSL/ca.crt");
        var servercert = File.ReadAllText("OpenSSL/server.crt");
        var serverkey = File.ReadAllText("OpenSSL/server.key");
        var keypair = new KeyCertificatePair(servercert, serverkey);
        var sslCredentials = new SslServerCredentials(new List<KeyCertificatePair>() { keypair }, cacert, false);
        //new MockServiceHelper()

        //ServerServiceDefinition
        Server server = new Server
        {
            Services = {
                UserService.BindService(serviceProvider.GetService<UserServiceBase>()),
                //StockItemService.BindService(serviceProvider.GetService<StockItemServiceBase>()),
                ProductService.BindService(serviceProvider.GetService<ProductServiceBase>())
               
            },
            Ports = { new ServerPort("192.168.7.213", Port, ServerCredentials.Insecure) }
        };
        server.Start();
        
        //Console.WriteLine("RouteGuide server listening on port " + Port);
        Console.WriteLine("Press any key to stop the server...");
        Console.ReadKey();

        server.ShutdownAsync().Wait();
    }

    //class Resolver
    //{
    //    string resolvePath;
    //    AssemblyName resolveName;

    //    public Resolver(string assemblyPath)
    //    {
    //        resolveName = AssemblyLoadContext.GetAssemblyName(assemblyPath);
    //        resolvePath = assemblyPath;
    //    }

    //    public Assembly Resolving(AssemblyLoadContext context, AssemblyName assemblyName)
    //    {
    //        if (assemblyName.FullName == resolveName.FullName)
    //        {
    //            var assembly = context.LoadFromAssemblyPath(resolvePath);
    //            //Console.WriteLine("Resolving: " + Path.GetFileNameWithoutExtension(resolvePath) + " -> " + assembly);
    //            return assembly;
    //        }

    //        return null;
    //    }
    //}
}