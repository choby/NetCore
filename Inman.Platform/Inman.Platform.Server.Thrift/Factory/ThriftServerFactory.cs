using Inman.Platform.ThriftServer.Factory;
using Inman.Platform.ThriftServer.Options;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Thrift;
using Thrift.Protocols;
using Thrift.Server;
using Thrift.Transports;

namespace Inman.Platform.ThriftServer.Factory
{
    public class ThriftServerFactory
    {
        private TServerTransport serverTransport;
        private TMultiplexedProcessor processor;
        private ITProtocolFactory inputProtocolFactory;
        private ITProtocolFactory outputProtocolFactory;
        private ILoggerFactory loggerFactory;
        private ThriftServerConfiguration config;
        private ILogger logger;
        

        public void RunAsync(CancellationToken cancellationToken)
        {
            try
            {
                this.initializeEnvironment();
                this.logger.LogInformation($"Selected TAsyncServer with {serverTransport} transport, {processor} processor and {inputProtocolFactory} protocol factories");
                
                this.logger.LogInformation("Starting the server...");
                this.buildServer().ServeAsync(cancellationToken).GetAwaiter().GetResult();
            }
            catch (Exception x)
            {
                this.logger.LogInformation(x.ToString());
            }
        }

        public ThriftServerFactory()
        {
            this.config = new ThriftServerConfiguration
            {
                Protocol = ProtocolOption.Binary,
                Transport = TransportOption.Tcp,
                Port = 9090,
                Timeout = 10000
            };
        }

        public ThriftServerFactory(ThriftServerConfiguration config)
        {
            this.config = config;
        }

        void initializeEnvironment()
        {
            if (this.processor == null)
                throw new Exception("运行服务器之前，必须调用RegisterProcessor()方法。");

            ThriftProtocolFactory protocolFactory = null;
            if (this.inputProtocolFactory == null)
            {
                protocolFactory = new ThriftProtocolFactory(this.config);
                this.inputProtocolFactory = protocolFactory.GetInputProtocolFactory();
            }
            if (this.outputProtocolFactory == null)
            {
                if(protocolFactory == null)
                    protocolFactory = new ThriftProtocolFactory(this.config);
                this.outputProtocolFactory = protocolFactory.GetOutputProtocolFactory();
            }
            
            if (this.serverTransport == null)
            {
                var transportFactory = new ThriftTransportFactory(this.config);
                this.serverTransport = transportFactory.GetTransport();
            }

            if(this.loggerFactory == null) this.loggerFactory = new LoggerFactory().AddConsole(LogLevel.Trace).AddDebug(LogLevel.Trace);

            if (this.logger == null) this.logger = loggerFactory.CreateLogger(nameof(Inman.Platform.ThriftServer));
            
        }

        public TBaseServer buildServer()
        {
            return new AsyncBaseServer(processor,
                serverTransport,
                inputProtocolFactory,
                outputProtocolFactory,
                loggerFactory);
             
        }

        public ThriftServerFactory RegisterProcessor(IRegistrationProcessor registrar)
        {
            this.processor = new TMultiplexedProcessor();
            registrar.RegistrationsFor(processor);
            return this;
        }
        
        public ThriftServerFactory SetInputProtocolFactory(ITProtocolFactory protocolFactory)
        {
            this.inputProtocolFactory = protocolFactory;
            return this;
        }


        public ThriftServerFactory SetOutputProtocolFactory(ITProtocolFactory protocolFactory)
        {
            this.outputProtocolFactory = protocolFactory;
            return this;
        }



        public ThriftServerFactory SetTransport(TServerTransport serverTransport)
        {
            this.serverTransport = serverTransport;
            return this;
        }

        

        public ThriftServerFactory AddLogger(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
            return this;
        }

    }
}
