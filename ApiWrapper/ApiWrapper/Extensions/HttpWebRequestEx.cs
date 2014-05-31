using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Harvest.Extensions
{
    public static class HttpWebRequestEx
    {
        public static Task<Stream> GetRequestStreamAsync(this HttpWebRequest request)
        {
            return Task<Stream>.Factory.FromAsync(request.BeginGetRequestStream, request.EndGetRequestStream, request);
        }

        public static Task<WebResponse> GetResponseAsync(this HttpWebRequest request)
        {
            return Task<WebResponse>.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, request);
        }
    }
}
