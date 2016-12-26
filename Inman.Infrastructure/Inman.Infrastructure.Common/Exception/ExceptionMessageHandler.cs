using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public class ExceptionMessageHandler
    {

        public static string GetExceptionMessage(Exception ex)
        {
            string message = null;
            if (ex is NotificationException)
            {
                message = ex.Message;
            }
            else if (ex.InnerException != null)
            {
                var sqlException = ex.InnerException as SqlException;
                if (sqlException != null)
                    message = GetSqlExceptionMessage(sqlException);
            }

            if (string.IsNullOrEmpty(message))
                message = ex.ToString();
            return message;

        }

        private static string GetSqlExceptionMessage(SqlException sqlException)
        {
           
            switch (sqlException.Number)
            {
                case 8152:
                    return  "提交的字符长度超出系统接收范围,请尝试减少字符长度再提交。";
                default:
                    return sqlException.Message;
            }
         
            
        }
    }
}
