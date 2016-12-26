using System.IO;
using System.Net;
using System.Text;

namespace Inman.Infrastructure.Common.Extensions
{
    /// <summary>
    /// Summary for the Files class
    /// </summary>
    public static class IO
    {
        /// <summary>
        /// Read a text file and obtain it's contents.
        /// </summary>
        /// <param name="absolutePath">The complete file path to write to.</param>
        /// <returns>String containing the content of the file.</returns>
        public static string GetFileText(this string absolutePath)
        {
            using(StreamReader sr = new StreamReader(File.OpenRead(absolutePath)))//to core modify:absolutePath
                return sr.ReadToEnd();
        }

        /// <summary>
        /// Creates or opens a file for writing and writes text to it.
        /// </summary>
        /// <param name="absolutePath">The complete file path to write to.</param>
        /// <param name="fileText">A String containing text to be written to the file.</param>
        public static void CreateToFile(this string fileText, string absolutePath)
        {
            using(StreamWriter sw = File.CreateText(absolutePath))
                sw.Write(fileText);
        }

        /// <summary>
        /// Update text within a file by replacing a substring within the file.
        /// </summary>
        /// <param name="absolutePath">The complete file path to write to.</param>
        /// <param name="lookFor">A String to be replaced.</param>
        /// <param name="replaceWith">A String to replace all occurrences of lookFor.</param>
        public static void UpdateFileText(this string absolutePath, string lookFor, string replaceWith)
        {
            string newText = GetFileText(absolutePath).Replace(lookFor, replaceWith);
            WriteToFile(absolutePath, newText);
        }

        /// <summary>
        /// Writes out a string to a file.
        /// </summary>
        /// <param name="absolutePath">The complete file path to write to.</param>
        /// <param name="fileText">A String containing text to be written to the file.</param>
        public static void WriteToFile(this string absolutePath, string fileText)
        {
            //to core modify:
            //using (StreamWriter sw = new StreamWriter(absolutePath, false))
            //    sw.Write(fileText);
            Stream stream = File.OpenWrite(absolutePath);
            using (StreamWriter sw = new StreamWriter(stream,Encoding.UTF8,fileText.Length, false))
                sw.Write(fileText);
        }

        ///// <summary>
        ///// Fetches a web page
        ///// </summary>
        ///// <param name="url">The URL.</param>
        ///// <returns></returns>
        //public static string ReadWebPage(string url)
        //{
        //    string webPage;
        //    WebRequest request = WebRequest.Create(url);
        //    using (Stream stream = request.GetResponse().GetResponseStream())
        //    {
        //        StreamReader sr = new StreamReader(stream);
        //        webPage = sr.ReadToEnd();
        //        sr.Close();
        //    }
        //    return webPage;
        //}
        /// <summary>
        /// 文件流转为字节
        /// </summary>
        /// <param name="steam"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this Stream steam)
        {
            byte[] infbytes = new byte[steam.Length];
            steam.Read(infbytes, 0, infbytes.Length);
            steam.Seek(0, SeekOrigin.Begin);
            return infbytes;
        }
    }
}