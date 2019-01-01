using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using Whisp.Application.Interfaces;
using Unity.Attributes;

namespace Whisp.Api.Filters
{
    public class ActionFilter : ActionFilterAttribute
    {
        [Dependency]
        public IAppLogger Logger { get; set; }
        
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            LogRequest(actionContext);
            base.OnActionExecuting(actionContext);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
        }

        private void LogRequest(HttpActionContext actionContext)
        {
            try
            {
                Logger.Trace($"Request: ({actionContext.Request.Method.ToString()}) {actionContext.Request.RequestUri.ToString()}");
            }
            catch
            {
            }
        }
    }
}