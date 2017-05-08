using System;
using System.IO;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Text.Encodings.Web;

namespace Kendo.Mvc.Extensions
{
    public static class TextWriterExtensions
    {
        public static void WriteContent<T>(this TextWriter writer, Func<T, object> action, HtmlEncoder htmlEncoder, T dataItem = null, bool htmlEncode = false) where T : class
		{
			var result = action(dataItem);

			var helperResult = result as HelperResult;

			if (helperResult != null)
			{
				helperResult.WriteTo(writer, htmlEncoder);
				return;
			}

			if (result != null)
			{
                if (htmlEncode)
                {
                    writer.Write(htmlEncoder.Encode(result.ToString()));
                }
                else
                {
                    writer.Write(result.ToString());
                }
			}
		} 
    }
}