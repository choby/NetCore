using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Inman.Infrastructure.Common
{
    /// <summary>
    /// 框架异常基类
    /// </summary>
    /// <remarks> 
    /// 修改历史 : 无
    /// </remarks>
    public class InfrastructureException : Exception
    {
        public InfrastructureException(string message)
            : base(message)
        {

        }

        public InfrastructureException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        //protected InfrastructureException(SerializationInfo info, StreamingContext context)
        //    : base(info, context)
        //{

        //}
    }
}
