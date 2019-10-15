using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsMetro
{
    class APIHelper
    {
        public static string HttpPost(string Url, string postDataStr, string value)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers["x-auth-token"] = value;
            //request.ContentLength = postDataStr.Length;
            StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.UTF8);
            writer.Write(postDataStr);
            writer.Flush();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码 
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            return retString;

        }
        // [WebMethod]
        /// <summary>
        /// apiget八八八八
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="postDataStr"></param>
        /// <returns></returns>
        public static string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json;charset=UTF-8";
            //request.Headers["x-auth-token"] = postDataStr;
            request.Headers.Add("x-auth-token", postDataStr);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

    }
}
