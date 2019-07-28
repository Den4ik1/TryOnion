using Domain.Model;
using Microsoft.Practices.Unity;
using DomainsService.Service;

namespace Inject.Module
{
    public class InjectDomain : IModule
    {
        public void Registre(IUnityContainer container)
        {
            container.RegisterType<IDomains, DomainService> (new ContainerControlledLifetimeManager());
        }
    }
}
