
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using System.Net.Security;
using Thrift;
using Thrift.Transports;
using Thrift.Transports.Server;
using Thrift.Protocols;
using Inman.Platform.Service;
using Inman.Platform.ServiceStub.Thrift;
using Thrift.Server;
using Inman.Platform.ThriftServer.Factory;
using Inman.Platform.ThriftServer;

class Program
{
    public static IServiceProvider serviceProvider;
    private static readonly ILogger Logger = new LoggerFactory().AddConsole(LogLevel.Trace).AddDebug(LogLevel.Trace).CreateLogger(nameof(Inman.Platform.ThriftServer));

    static void Main(string[] args)
    {
        IServiceCollection services = new ServiceCollection();
        Startup.ConfigureServices(services);
        serviceProvider = services.BuildServiceProvider();

        //   RunThrift(args);
        var registar = new RegistrationProcessor();
        using (var source = new CancellationTokenSource())
        {
            new ThriftServerFactory().RegisterProcessor(registar).RunAsync(source.Token);
            Logger.LogInformation("Press any key to stop...");

            Console.ReadLine();
            source.Cancel();
        }
        Logger.LogInformation("Server stopped");
    }

   

    static void RunThrift(string[] args)
    {
        args = args ?? new string[0];

        //if (args.Any(x => x.StartsWith("-h", StringComparison.OrdinalIgnoreCase)))
        //{
        //    DisplayHelp();
        //    return;
        //}

        using (var source = new CancellationTokenSource())
        {
            RunAsync(args, source.Token).GetAwaiter().GetResult();

            Logger.LogInformation("Press any key to stop...");

            Console.ReadLine();
            source.Cancel();
        }

        Logger.LogInformation("Server stopped");

    }
    private static void DisplayHelp()
    {
        Logger.LogInformation(@"
Usage: 
    Server.exe -h
        will diplay help information 

    Server.exe -t:<transport> -p:<protocol>
        will run server with specified arguments (tcp transport and binary protocol by default)

Options:
    -t (transport): 
        tcp - (default) tcp transport will be used (host - ""localhost"", port - 9090)
        tcpbuffered - tcp buffered transport will be used (host - ""localhost"", port - 9090)
        namedpipe - namedpipe transport will be used (pipe address - "".test"")
        http - http transport will be used (http address - ""localhost:9090"")
        tcptls - tcp transport with tls will be used (host - ""localhost"", port - 9090)
        framed - tcp framed transport will be used (host - ""localhost"", port - 9090)

    -p (protocol): 
        binary - (default) binary protocol will be used
        compact - compact protocol will be used
        json - json protocol will be used
        multiplexed - multiplexed protocol will be used

Sample:
    Server.exe -t:tcp 
");
    }
    private static async Task RunAsync(string[] args, CancellationToken cancellationToken)
    {
        var selectedTransport = GetTransport(args);
        var selectedProtocol = GetProtocol(args);

        if (selectedTransport == Transport.Http)
        {
            new HttpServerSample().Run(cancellationToken);
        }
        else
        {
            await RunSelectedConfigurationAsync(selectedTransport, selectedProtocol, cancellationToken);
        }
    }

    private static Protocol GetProtocol(string[] args)
    {
        var transport = "multiplexed"; //args.FirstOrDefault(x => x.StartsWith("-p"))?.Split(':')?[1];
        Protocol selectedProtocol;

        Enum.TryParse(transport, true, out selectedProtocol);

        return selectedProtocol;
    }

    private static Transport GetTransport(string[] args)
    {
        var transport = "TcpBuffered"; //args.FirstOrDefault(x => x.StartsWith("-t"))?.Split(':')?[1];
        Transport selectedTransport;

        Enum.TryParse(transport, true, out selectedTransport);

        return selectedTransport;
    }
    private static async Task RunSelectedConfigurationAsync(Transport transport, Protocol protocol, CancellationToken cancellationToken)
    {
        
        var fabric = new LoggerFactory().AddConsole(LogLevel.Trace).AddDebug(LogLevel.Trace);
        //var handler = new CalculatorAsyncHandler();
        ITAsyncProcessor processor = null;

        TServerTransport serverTransport = null;

        switch (transport)
        {
            case Transport.Tcp:
                serverTransport = new TServerSocketTransport(9090);
                break;
            case Transport.TcpBuffered:
                serverTransport = new TServerSocketTransport(port: 9090, clientTimeout: 10000, useBufferedSockets: true);
                break;
            case Transport.NamedPipe:
                serverTransport = new TNamedPipeServerTransport(".test");
                break;
            case Transport.TcpTls:
                serverTransport = new TTlsServerSocketTransport(9090, false, GetCertificate(), ClientCertValidator, LocalCertificateSelectionCallback);
                break;
            case Transport.Framed:
                serverTransport = new TServerFramedTransport(9090);
                break;
        }

        ITProtocolFactory inputProtocolFactory;
        ITProtocolFactory outputProtocolFactory;

        //switch (protocol)
        //{
        //    case Protocol.Binary:
        //        {
        //            inputProtocolFactory = new TBinaryProtocol.Factory();
        //            outputProtocolFactory = new TBinaryProtocol.Factory();
        //            new ProductService.AsyncProcessor();
        //            processor = new Calculator.AsyncProcessor(handler);
        //        }
        //        break;
        //    case Protocol.Compact:
        //        {
        //            inputProtocolFactory = new TCompactProtocol.Factory();
        //            outputProtocolFactory = new TCompactProtocol.Factory();
        //            processor = new Calculator.AsyncProcessor(handler);
        //        }
        //        break;
        //    case Protocol.Json:
        //        {
        //            inputProtocolFactory = new TJsonProtocol.Factory();
        //            outputProtocolFactory = new TJsonProtocol.Factory();
        //            processor = new Calculator.AsyncProcessor(handler);
        //        }
        //        break;
        //    case Protocol.Multiplexed:
        //        {
        //            inputProtocolFactory = new TBinaryProtocol.Factory();
        //            outputProtocolFactory = new TBinaryProtocol.Factory();

        //            var calcHandler = new CalculatorAsyncHandler();
        //            var calcProcessor = new Calculator.AsyncProcessor(calcHandler);

        //            var sharedServiceHandler = new SharedServiceAsyncHandler();
        //            var sharedServiceProcessor = new SharedService.AsyncProcessor(sharedServiceHandler);

        //            var multiplexedProcessor = new TMultiplexedProcessor();
        //            multiplexedProcessor.RegisterProcessor(nameof(Calculator), calcProcessor);
        //            multiplexedProcessor.RegisterProcessor(nameof(SharedService), sharedServiceProcessor);

        //            processor = multiplexedProcessor;
        //        }
        //        break;
        //    default:
        //        throw new ArgumentOutOfRangeException(nameof(protocol), protocol, null);
        //}

        inputProtocolFactory = new TBinaryProtocol.Factory();
        outputProtocolFactory = new TBinaryProtocol.Factory();
        
        var productHandler = serviceProvider.GetService<ProductAsyncHandler>();
        var goodsHandler = serviceProvider.GetService<GoodsAsyncHandler>(); 
        
        var productProcessor = new ProductService.AsyncProcessor(productHandler);
        var goodsProcessor = new GoodsService.AsyncProcessor(goodsHandler);


        var multiplexedProcessor = new TMultiplexedProcessor();
        multiplexedProcessor.RegisterProcessor(nameof(ProductService), productProcessor);
        multiplexedProcessor.RegisterProcessor(nameof(GoodsService), goodsProcessor);

        processor = multiplexedProcessor;

        try
        {
            Logger.LogInformation(
                $"Selected TAsyncServer with {serverTransport} transport, {processor} processor and {inputProtocolFactory} protocol factories");

            var server = new AsyncBaseServer(processor, serverTransport, inputProtocolFactory, outputProtocolFactory, fabric);
          
            Logger.LogInformation("Starting the server...");
            
              await server.ServeAsync(cancellationToken);
        }
        catch (Exception x)
        {
            Logger.LogInformation(x.ToString());
        }
    }

    private static X509Certificate2 GetCertificate()
    {
        // due to files location in net core better to take certs from top folder
        var certFile = GetCertPath(Directory.GetParent(Directory.GetCurrentDirectory()));
        return new X509Certificate2(certFile, "ThriftTest");
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

    private static bool ClientCertValidator(object sender, X509Certificate certificate,
        X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        return true;
    }

    private enum Transport
    {
        Tcp,
        TcpBuffered,
        NamedPipe,
        Http,
        TcpTls,
        Framed
    }

    private enum Protocol
    {
        Binary,
        Compact,
        Json,
        Multiplexed
    }

    public class HttpServerSample
    {
        public void Run(CancellationToken cancellationToken)
        {
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables(prefix: "ASPNETCORE_")
                .Build();

            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseUrls("http://localhost:9090")
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run(cancellationToken);
        }

        public class Startup
        {
            public Startup(IHostingEnvironment env)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(env.ContentRootPath)
                    .AddEnvironmentVariables();

                Configuration = builder.Build();
            }

            public IConfigurationRoot Configuration { get; }

            // This method gets called by the runtime. Use this method to add services to the container.
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddTransient<ProductService.IAsync, ProductAsyncHandler>();
                services.AddTransient<GoodsService.IAsync, GoodsAsyncHandler>();
                //services.AddTransient<ITAsyncProcessor, Calculator.AsyncProcessor>();
                services.AddTransient<THttpServerTransport, THttpServerTransport>();
            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IHostingEnvironment env,
                ILoggerFactory loggerFactory)
            {
                app.UseMiddleware<THttpServerTransport>();
            }
        }
    }

}