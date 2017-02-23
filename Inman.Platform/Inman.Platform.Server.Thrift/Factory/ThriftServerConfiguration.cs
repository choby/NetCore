﻿using Inman.Platform.ThriftServer.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Platform.ThriftServer
{
    public class ThriftServerConfiguration
    {
        public ProtocolOption Protocol { get; set; }
        public TransportOption Transport { get; set; }
       // public string Host { get; set; }
        public int Port { get; set; }
        public string Cert { get; set; }
        public int Timeout { get; set; }
    }
}
