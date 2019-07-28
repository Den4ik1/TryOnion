using Inject.Module;
using Inject;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            Registre<InjectDomain>(container);
            Registre<InjectRepository>(container);

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        private static void Registre<T>(IUnityContainer container)  where T : IModule, new()
        {
            new T().Registre(container);
        }
    }
}