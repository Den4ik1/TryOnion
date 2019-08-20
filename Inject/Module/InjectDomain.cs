using Domain.Model;
using Microsoft.Practices.Unity;
using DomainsService.Service;
using DomaimsService.Service;

namespace Inject.Module
{
    public class InjectDomain : IModule
    {
        public void Registre(IUnityContainer container)
        {
            container.RegisterType<IDomains, DomainService> (new HierarchicalLifetimeManager());
            container.RegisterType<ILoggerDomains, LoggerServiceDomains>(new HierarchicalLifetimeManager());
            container.RegisterType<IExceptionDomains, ExceptionServiceDomains>(new HierarchicalLifetimeManager());
        }
    }
}
