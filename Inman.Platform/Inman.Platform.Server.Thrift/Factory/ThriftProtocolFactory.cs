using Inman.Platform.ThriftServer.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocols;

namespace Inman.Platform.ThriftServer.Factory
{
    public class ThriftProtocolFactory
    {
        private ThriftServerConfiguration config;
        public ThriftProtocolFactory()
        {

        }

        public ThriftProtocolFactory(ThriftServerConfiguration config)
        {
            this.config = config;
        }
        public ITProtocolFactory GetInputProtocolFactory()
        {
            switch (config.Protocol)
            {
                case ProtocolOption.Binary:
                    return new TBinaryProtocol.Factory();
                case ProtocolOption.Compact:
                    return new TCompactProtocol.Factory();
                case ProtocolOption.Json:
                    return new TJsonProtocol.Factory();
                case ProtocolOption.Multiplexed:
                    return new TBinaryProtocol.Factory(); //Multiplexed or Binary
                default:
                    return new TBinaryProtocol.Factory();
            }
                        
        }

        public ITProtocolFactory GetOutputProtocolFactory()
        {
            switch (config.Protocol)
            {
                case ProtocolOption.Binary:
                    return new TBinaryProtocol.Factory();
                case ProtocolOption.Compact:
                    return new TCompactProtocol.Factory();
                case ProtocolOption.Json:
                    return new TJsonProtocol.Factory();
                case ProtocolOption.Multiplexed:
                    return new TBinaryProtocol.Factory(); //Multiplexed or Binary
                default:
                    return new TBinaryProtocol.Factory();
            }
        }
    }
}
