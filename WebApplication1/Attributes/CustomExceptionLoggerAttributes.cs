using Domain.Model;
using System.Net.Http;
using System.Web.Http.Filters;
using Domain.Service;

namespace WebApplication1.Attributes
{
    public class CustomExceptionLoggerAttributes : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var exceptionService = GetService<IExceptionDomains>(actionExecutedContext);

            exceptionService.ExceptionLog(new ExceptionDomains()
            {
                ExceptionCode = 333,
                MasseageException = "Hello"
            });


        }

        private T GetService<T>(HttpActionExecutedContext actioncontext)
        {
            return (T)actioncontext.Request.GetDependencyScope().GetService(typeof(T));
        }
    }
}