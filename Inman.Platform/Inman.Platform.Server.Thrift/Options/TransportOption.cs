using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Platform.ThriftServer.Options
{
    public enum TransportOption
    {
        Tcp,
        TcpBuffered,
        NamedPipe,
        Http,
        TcpTls,
        Framed
    }
}
