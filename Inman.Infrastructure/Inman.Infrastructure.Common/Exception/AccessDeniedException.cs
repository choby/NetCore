using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    /// <summary>
    /// 权限认证失败
    /// </summary>
    /// <remarks> 
    /// 修改历史 : 无
    /// </remarks>
    [Serializable]
    public class AccessDeniedException : Exception
    {
        public AccessDeniedException()
            : base("访问被拒绝!")
        {

        }

        public AccessDeniedException(string message)
            : base(message)
        {

        }

        public AccessDeniedException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
