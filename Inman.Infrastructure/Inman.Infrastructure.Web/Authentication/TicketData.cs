using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Inman.Infrastructure.Web
{
    [DataContract]
    public class TicketData
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
