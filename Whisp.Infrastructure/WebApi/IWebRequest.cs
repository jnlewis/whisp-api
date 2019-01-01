using System;
using System.Collections.Generic;
using System.Text;

namespace WhispWeb.Infra.WebApi
{
    public interface IWebRequest
    {
        string Get(string url);
        string Post(string url, string postData);
    }
}
