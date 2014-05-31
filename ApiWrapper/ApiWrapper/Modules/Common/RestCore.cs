using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Harvest.Extensions;
using Newtonsoft.Json;

namespace Harvest.Modules.Common
{
    public class RestCore
    {
        protected AuthType _authenticationType = AuthType.NotSet;
        protected string _authenticationToken;

        private async Task<RequestResult> ExecuteRequestAsync(string requestResource, HttpMethodType requestMethod, object body = null)
        {
            try
            {
                HttpWebRequest request = HttpWebRequest.CreateHttp(Config.BaseUrlAddress + requestResource);
                request.Headers["Authorization"] = GetAuthorizationToken();
                request.Method = requestMethod.ToString().ToUpper();
                request.Accept = "application/json";
                request.ContentType = "application/json";

                if (body != null)
                {
                    var json = JsonConvert.SerializeObject(body, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                    byte[] formData = UTF8Encoding.UTF8.GetBytes(json);

                    var dataStream = await request.GetRequestStreamAsync();
                    dataStream.Write(formData, 0, formData.Length);
                    dataStream.Dispose();
                }

                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                var responseStream = response.GetResponseStream();
                var reader = new StreamReader(responseStream);
                string responseFromServer = reader.ReadToEnd();

                return new RequestResult()
                {
                    Content = responseFromServer,
                    StatusCode = response.StatusCode
                };
            }
            catch (WebException)
            {
                
                throw;
            }
           
        }

        private async Task<T> ExecuteRequestAsync<T>(string requestResource, HttpMethodType requestMethod,
            object body = null)
        {
            var response = await ExecuteRequestAsync(requestResource, requestMethod, body);
            var result = JsonConvert.DeserializeObject<T>(response.Content, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            return result;
        }

        protected Task<T> GetAsync<T>(string resource)
        {
            return ExecuteRequestAsync<T>(resource, HttpMethodType.Get);
        }

        protected Task<T> PostAsync<T>(string resource, object data = null)
        {
            return ExecuteRequestAsync<T>(resource, HttpMethodType.Post, data);
        }

        private string GetAuthorizationToken()
        {
            string result = string.Empty;
            switch (_authenticationType)
            {
                case AuthType.Baisc:
                    {
                        result = "Basic ";
                    }
                    break;
                case AuthType.OAuth2:
                    {
                        result = "Bearer ";
                    }
                    break;
                    case AuthType.NotSet:
                {
                    throw new UnauthorizedAccessException("Authorization token or login-password must be set up with SetCredentials methods");
                }
            }

            return result + _authenticationToken;
        }

        public void SetCredentials(string login, string password)
        {
            _authenticationType = AuthType.Baisc;
            _authenticationToken = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", login, password)));
        }

        public void SetCredentials(string token)
        {
            _authenticationType = AuthType.OAuth2;
            _authenticationToken = token;
        }
    }
}
