using System;
using System.Web.Http;

namespace Whisp.Api.Controllers
{
    public class BaseController : ApiController
    {
        public bool HasValue(params object[] items)
        {
            foreach (var item in items)
            {
                if (item == null || string.IsNullOrEmpty(item.ToString()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}