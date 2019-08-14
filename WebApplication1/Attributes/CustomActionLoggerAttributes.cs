using Domain.Model;
using Domain.Service;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApplication1.Attributes
{
    public class CustomActionLoggerAttributes : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actioncontext)
        {
            var logService = GetService<ILoggerDomains>(actioncontext);

            logService.Log(new LoggerDomain()
            {
                AddressIP = "8.8.8.8",
                Controller = "Controller123",
                Request = "Request321"
            });
        }

        private T GetService<T>(HttpActionContext actioncontext)
        {
            return (T)actioncontext.Request.GetDependencyScope().GetService(typeof(T));
        }
    }
}
