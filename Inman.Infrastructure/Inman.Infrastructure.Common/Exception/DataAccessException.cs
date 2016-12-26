using Inman.Infrastructure.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    /// <summary>
    /// 数据访问过程中发生的异常
    /// </summary>
    /// <remarks> 
    /// 修改历史 : 无
    /// </remarks>
    [Serializable]
    public class DataAccessException : InfrastructureException
    {
        /// <summary>
        /// 创建数据访问异常实例
        /// </summary>
        public DataAccessException()
            : base("数据访问异常!")
        {

        }

        /// <summary>
        /// 创建数据访问异常实例
        /// </summary>
        /// <param name="message">异常信息</param>
        public DataAccessException(string message)
            : base($"数据访问异常 : {message}")
        {

        }

        /// <summary>
        /// 创建数据访问异常实例
        /// </summary>
        /// <param name="message">异常信息</param>
        /// <param name="innerException">内部异常</param>
        public DataAccessException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
