using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Globalization;
using System.Web;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Formatting;

namespace Inman.Infrastructure.Http
{
    public class HttpHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">返回转换的类型</typeparam>
        /// <param name="strUri">地址</param>
        /// <param name="method">请求方式</param>
        /// <param name="contentType">请求接收类型</param>
        /// <param name="objToSend">发送的数据（只限于Post和Put）</param>
        /// <param name="tick">防止等幂提交（只限于Put和Delete）</param>
        /// <returns></returns>
        public static ResponseResult<T> DoRequest<T>(string strUri, EnumHttpMethod method,
                                                    EnumContentType contentType = EnumContentType.Json,
                                                    Object objToSend = null, long tick = 0)
        {
            var content = new StringContent(JsonConvert.SerializeObject(objToSend), Encoding.UTF8, "application/json");
            return DoRequest<T>(strUri, method, contentType, content, tick);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">返回转换的类型</typeparam>
        /// <param name="strUri">地址</param>
        /// <param name="method">请求方式</param>
        /// <param name="httpContent"></param>
        /// <param name="contentType">请求接收类型</param>
        /// <param name="tick">防止等幂提交（只限于Put和Delete）</param>
        /// <returns></returns>
        public static ResponseResult<T> DoRequest<T>(string strUri,
                                                    EnumHttpMethod method,
                                                    EnumContentType contentType = EnumContentType.Json,
                                                    HttpContent httpContent = null,
                                                    long tick = 0)
        {
            var strToRequest = strUri;
            if (tick != 0
                && (method == EnumHttpMethod.PUT || method == EnumHttpMethod.DELETE))
            {
                //CultureInfo.InvariantCulture的作用是为了固定格式
                strToRequest += "?UpdateTicks=" + tick.ToString(CultureInfo.InvariantCulture);
            }

            //表示一个HTTP请求消息。
            HttpRequestMessage requestMsg = new HttpRequestMessage();

            //设置HTTP接收请求的数据类型
            switch (contentType)
            {
                case EnumContentType.Json:
                    requestMsg.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpContentTypes.ApplicationJson));
                    break;
                case EnumContentType.Xml:
                    requestMsg.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpContentTypes.ApplicationXml));
                    break;
                default:
                    requestMsg.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpContentTypes.TextHtml));
                    break;
            }
            //请求数据的链接(Uri)
            requestMsg.RequestUri = new Uri(strToRequest); ;
            switch (method)
            {
                case EnumHttpMethod.POST:
                    requestMsg.Method = HttpMethod.Post;
                    requestMsg.Content = httpContent;
                    break;
                case EnumHttpMethod.PUT:
                    requestMsg.Method = HttpMethod.Put;
                    requestMsg.Content = httpContent;
                    break;
                case EnumHttpMethod.DELETE:
                    requestMsg.Method = HttpMethod.Delete;
                    break;
                default:
                    requestMsg.Method = HttpMethod.Get;
                    break;
            }
            //client是HttpClient的对象：用于发送HTTP请求和接收HTTP响应
            HttpClient client = new HttpClient();
            //client.SendAsync:发送一个HTTP请求一个异步操作，并返回响应结果。 
            Task<HttpResponseMessage> rtnAll = client.SendAsync(requestMsg);

            HttpResponseMessage resultMessage;
            try
            {
                //这一步是关键提交请求的过程,rtnAll.Result这里其实是一个多线程的处理，是.Net Framework 4.0的新特性之一
                resultMessage = rtnAll.Result;
            }
            finally
            {
                client.Dispose();
            }

            if (resultMessage == null)
            { throw new NullReferenceException("没有响应结果"); }

            if (resultMessage.IsSuccessStatusCode) //判断响应是否成功？
            {
                Task<T> rtnFinal = null;
                try
                {
                    try
                    {
                        switch (contentType)
                        {
                            case EnumContentType.Xml:
                                rtnFinal =
                                    resultMessage.Content.ReadAsAsync<T>(new MediaTypeFormatter[] { new XmlMediaTypeFormatter() });
                                break;
                            default:
                                rtnFinal =
                                    resultMessage.Content.ReadAsAsync<T>(new MediaTypeFormatter[] { new JsonMediaTypeFormatter() });
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(string.Format("服务器返回与请求不匹配,返回的数据:{0}"
                                                , resultMessage.Content.ReadAsStringAsync().Result)
                                            , ex);
                    }
                    return new ResponseResult<T>()
                    {
                        Value = rtnFinal.Result,
                        RawValue = resultMessage.Content.ReadAsStringAsync().Result
                    };
                }
                finally
                {
                    if (rtnFinal != null)
                    {
                        rtnFinal.Dispose();
                    }
                }
            }
            else
            {
                if (resultMessage.Content == null)
                { resultMessage.EnsureSuccessStatusCode(); }

                Task<string> tmpTask = null;
                try
                {
                    tmpTask = resultMessage.Content.ReadAsStringAsync();
                }
                catch
                { resultMessage.EnsureSuccessStatusCode(); }

                if (tmpTask == null)
                { resultMessage.EnsureSuccessStatusCode(); }

                using (tmpTask)
                {
                    throw new HttpException("HttpStatus:" + resultMessage.StatusCode.ToString() + " | Message:" + tmpTask.Result);
                }
            }
        }

        /// <summary>
        /// 不需要返回值
        /// </summary>
        /// <param name="strUri">地址</param>
        /// <param name="method">请求方式</param>
        /// <param name="objToSend">发送的数据（只限于Post和Put）</param>
        /// <param name="tick">防止等幂提交（只限于Put和Delete）</param>
        /// <returns></returns>
        public static void DoRequest(string strUri, EnumHttpMethod method,
                                      Object objToSend = null, long tick = 0)
        {
            string strToRequest = strUri;

            if (tick != 0
                && (method == EnumHttpMethod.PUT || method == EnumHttpMethod.DELETE))
            {
                //CultureInfo.InvariantCulture的作用是为了固定格式
                strToRequest += "?UpdateTicks="
                        + tick.ToString(CultureInfo.InvariantCulture);
            }

            //表示一个HTTP请求消息。
            HttpRequestMessage requestMsg = new HttpRequestMessage();
            //设置HTTP接收请求的数据类型
            requestMsg.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(HttpContentTypes.ApplicationJson));
            //请求数据的链接(Uri)
            requestMsg.RequestUri = new Uri(strToRequest);

            HttpContent content = null;
            //StringContent():转换成基于字符串的HTTP内容。
            //JsonConvert.SerializeObject(objToSend):将实体对象序列化成JSON
            if (objToSend != null)
            {
                content = new StringContent(JsonConvert.SerializeObject(objToSend), Encoding.UTF8, "application/json");
            }

            switch (method)
            {
                case EnumHttpMethod.POST:
                    requestMsg.Method = HttpMethod.Post;
                    requestMsg.Content = content;
                    break;
                case EnumHttpMethod.PUT:
                    requestMsg.Method = HttpMethod.Put;
                    requestMsg.Content = content;
                    break;
                case EnumHttpMethod.DELETE:
                    requestMsg.Method = HttpMethod.Delete;
                    break;
                default:
                    throw new ArgumentException("只支持Post,Put,Delete请求", "method");
            }
            //client是HttpClient的对象：用于发送HTTP请求和接收HTTP响应
            HttpClient client = new HttpClient();
            //client.SendAsync:发送一个HTTP请求一个异步操作，并返回响应结果。 
            Task<HttpResponseMessage> rtnAll = client.SendAsync(requestMsg);

            #region 执行

            HttpResponseMessage resultMessage = null;
            try
            {
                //这一步是关键提交请求的过程,rtnAll.Result这里其实是一个多线程的处理，是.Net Framework 4.0的新特性之一
                resultMessage = rtnAll.Result;
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                {
                    if (ex is HttpRequestException)
                    {
                        throw new Exception("发送网络请求失败", ex);
                    }
                }
            }
            finally
            {
                client.Dispose();
            }

            if (resultMessage == null)
            { throw new NullReferenceException("没有响应结果"); }

            if (resultMessage.IsSuccessStatusCode) //判断响应是否成功？
            { return; }

            if (resultMessage.Content != null)
            {
                Task<string> tmpTask = null;
                try
                {
                    tmpTask = resultMessage.Content.ReadAsStringAsync();
                }
                catch
                {
                    resultMessage.EnsureSuccessStatusCode();
                }

                if (tmpTask != null)
                {
                    using (tmpTask)
                    {
                        throw new HttpException("HttpStatus:" + resultMessage.StatusCode.ToString() + " | Message:" + tmpTask.Result);
                    }
                }
            }
            else
            {
                resultMessage.EnsureSuccessStatusCode();
            }
        }

            #endregion

        
    }

    public enum EnumHttpMethod
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public enum EnumContentType
    {
        Json,
        Xml
    }

    public class ResponseResult<T>
    {
        public T Value { get; set; }

        public string RawValue { get; set; }
    }

    public class ResponseStatus
    {
        public string StatusCode { get; set; }

        public string Message { get; set; }

        public bool EnsureSuccess(bool throwException = false)
        {
            var result = (StatusCode ?? string.Empty).Equals("200");

            if (!result && throwException)
            { throw new HttpRequestException(Message); }

            return true;
        }
    }

    public static class HttpContentTypes
    {
        public const string MultiPartFormData = "multipart/form-data";
        public const string TextPlain = "text/plain";
        public const string TextHtml = "text/html";
        public const string TextCsv = "text/csv";
        public const string ApplicationJson = "application/json";
        public const string ApplicationXml = "application/xml";
        public const string ApplicationXWwwFormUrlEncoded = "application/x-www-form-urlencoded";
        public const string ApplicationOctetStream = "application/octet-stream";
    }

}
