using System;
using System.Runtime.Serialization;

namespace Inman.Infrastructure.IOC
{
    [Serializable]
    public class ComponentRegistrationException : Exception
    {
        public ComponentRegistrationException(string serviceName)
            : base(String.Format("Component {0} could not be found but is registered in the engine/components section", serviceName))
        {
        }

        protected ComponentRegistrationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
