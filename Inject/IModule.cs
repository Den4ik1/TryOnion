using Microsoft.Practices.Unity;

namespace Inject
{
    public interface IModule
    {
        void Registre(IUnityContainer container);
    }
}
