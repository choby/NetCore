using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Inman.Infrastructure.Common
{
    [DataContract]
    public class RequestData
    {
        [DataMember]
        public string AppKey { get; set; }

        [DataMember]
        public string SessionKey { get; set; }
    }
}
