using System;
using System.Collections.Generic;
using System.Text;
using Thrift;

namespace Inman.Platform.ThriftServer
{
    public interface IRegistrationProcessor
    {
        void RegistrationsFor(TMultiplexedProcessor processor);
    }
}
