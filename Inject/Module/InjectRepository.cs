using Infro.Model;
using Infra;
using Microsoft.Practices.Unity;

namespace Inject.Module
{
    public class InjectRepository : IModule
    {
        public void Registre(IUnityContainer container)
        {
            container.RegisterType<IOwner, FakeRepository> (new ContainerControlledLifetimeManager());
        }
    }
}
