using System;
using System.Net;

namespace WhispWeb.Infra.WebApi
{
    public class WebRequest : IWebRequest
    {
        public string Get(string url)
        {
            string response = null;

            using (var client = new WebClient())
            {
                response = client.DownloadString(url);
            }

            return response;
        }

        public string Post(string url, string postData)
        {
            string response = null;

            using (var client = new WebClient())
            {
                response = client.UploadString(url, postData);
            }

            return response;
        }
    }
}
