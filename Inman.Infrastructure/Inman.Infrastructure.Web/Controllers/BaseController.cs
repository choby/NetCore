using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Inman.Infrastructure.Web
{
    public class BaseController : Controller
    {
        protected PersonalCache Personal
        {
            get { return PersonalCache.Instance; }
        }

        /// <summary>
        /// 判断页面提交方式是否为POST请求
        /// </summary>
        public bool IsPostRequest
        {
            get { return Request.HttpMethod.Equals("POST", StringComparison.OrdinalIgnoreCase); }
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            LogException(filterContext.Exception);
        }

        protected virtual void LogException(Exception exception)
        {

        }

        /// <summary>
        /// Display success notification
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="persistForTheNextRequest">A value indicating whether a message should be persisted for the next request</param>
        /// 
        protected virtual void SuccessNotification(string message, bool persistForTheNextRequest = true)
        {
            AddNotification(NotifyType.Success, message, persistForTheNextRequest);
        }

        /// <summary>
        /// Display error notification
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="persistForTheNextRequest">A value indicating whether a message should be persisted for the next request</param>
        protected virtual void ErrorNotification(string message, bool persistForTheNextRequest = true)
        {
            AddNotification(NotifyType.Error, message, persistForTheNextRequest);
        }

        /// <summary>
        /// Display error notification
        /// </summary>
        /// <param name="exception">Exception</param>
        /// <param name="persistForTheNextRequest">A value indicating whether a message should be persisted for the next request</param>
        /// <param name="logException">A value indicating whether exception should be logged</param>
        protected virtual void ErrorNotification(Exception exception, bool persistForTheNextRequest = true, bool logException = true)
        {
            if (logException)
                LogException(exception);
            AddNotification(NotifyType.Error, exception.Message, persistForTheNextRequest);
        }

        /// <summary>
        /// Display notification
        /// </summary>
        /// <param name="type">Notification type</param>
        /// <param name="message">Message</param>
        /// <param name="persistForTheNextRequest">A value indicating whether a message should be persisted for the next request</param>
        protected virtual void AddNotification(NotifyType type, string message, bool persistForTheNextRequest)
        {
            string dataKey = string.Format("sys.notifications.{0}", type);
            if (persistForTheNextRequest)
            {
                if (TempData[dataKey] == null)
                    TempData[dataKey] = new List<string>();
                ((List<string>)TempData[dataKey]).Add(message);
            }
            else
            {
                if (ViewData[dataKey] == null)
                    ViewData[dataKey] = new List<string>();
                ((List<string>)ViewData[dataKey]).Add(message);
            }
        }

        protected FileResult FileExcel(byte[] fileContents, string fileNameWithoutExtionsion)
        {
            //return new ExcelXlsFileResult(fileContents, fileNameWithoutExtionsion);
            return File(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileNameWithoutExtionsion + ".xlsx");
        }
    }
}
