using Inman.Infrastructure.Common.IOC;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;


namespace Inman.Infrastructure.Web
{
    public class ExcelXlsFileResult : FileContentResult
    {
        protected virtual string Extension
        {
            get { return ".xlsx"; }
        }

        protected ExcelXlsFileResult(byte[] fileContents, string contentType, string fileNameWithoutExtionsion)
            : base(fileContents, contentType)
        {
            FileDownloadName = getFileName(fileNameWithoutExtionsion);
            var httpcontext= EngineContext.Current.GetService<HttpContext>();
            httpcontext.Response.Headers.Add("Content-Length", fileContents.Length.ToString());
        }

        public ExcelXlsFileResult(byte[] fileContents, string fileNameWithoutExtionsion)
            : this(fileContents, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileNameWithoutExtionsion)
        {
            
        }

        protected string getFileName(string fileNameWithoutExtionsion)
        {
            return string.Concat(fileNameWithoutExtionsion, Extension);
        }
    }
}
