using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    [Serializable]
    public class CustomException : Exception
    {
      
        public CustomException()
        {

        }
       
        public CustomException(string message)
            : base(message)
        {

        }

        public CustomException(string messageFormat,params object[] args)
            : base(string.Format(messageFormat, args))
        {

        }
      
        public CustomException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
