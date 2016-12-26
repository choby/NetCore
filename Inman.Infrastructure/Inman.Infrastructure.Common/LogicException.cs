using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public class LogicException : Exception
    {
        public LogicException()
        {
        }


        public LogicException(string message)
            : base(message)
        {
        }

        public LogicException(string messageFormat, params  object[] args)
            : base(string.Format(messageFormat, args))
        {
        }  
        
        //to core modify
        //protected LogicException(SerializationInfo
        //    info, StreamingContext context)
        //    : base(info, context)
        //{
        //}


        public LogicException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
