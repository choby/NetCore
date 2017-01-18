using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


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
            HttpContext.Current.Response.AddHeader("Content-Length", fileContents.Length.ToString());
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
