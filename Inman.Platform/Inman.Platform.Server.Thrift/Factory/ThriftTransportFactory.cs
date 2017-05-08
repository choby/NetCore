using Inman.Platform.ThriftServer.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Transports;
using Thrift.Transports.Server;

namespace Inman.Platform.ThriftServer.Factory
{
    public class ThriftTransportFactory
    {
        private TransportOption transportOption;
        private ThriftServerConfiguration config;

        public ThriftTransportFactory()
        {
            var transport = "TcpBuffered";
            Enum.TryParse(transport, true, out transportOption);
        }

        public ThriftTransportFactory(ThriftServerConfiguration config) : this()
        {
            this.config = config;
            this.transportOption = config.Transport;
        }


        public TServerTransport GetTransport()
        {
            TServerTransport serverTransport = null;
            switch (transportOption)
            {
                case TransportOption.Tcp:
                    serverTransport = new TServerSocketTransport(config.Port);
                    break;
                case TransportOption.TcpBuffered:
                    serverTransport = new TServerSocketTransport(port: config.Port, clientTimeout: config.Timeout, useBufferedSockets: true);
                    break;
                case TransportOption.NamedPipe:
                    serverTransport = new TNamedPipeServerTransport(".test");
                    break;
                case TransportOption.TcpTls:
                    var certificateFactory = new ThriftCertificateFactory(this.config);
                    var certificate2 = certificateFactory.GetCertificate();
                    serverTransport = new TTlsServerSocketTransport(9090, this.config.UseBufferedSockets, certificate2);
                    break;
                case TransportOption.Framed:
                    serverTransport = new TServerFramedTransport(config.Port);
                    break;
            }
            return serverTransport;
        }
    }
}
