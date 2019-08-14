using Infro.Model;
using Microsoft.Practices.Unity;
using Microsoft.EntityFrameworkCore;
using Infra.Contexts;
using System.Configuration;
using Infra.Repository;

namespace Inject.Module
{
    public class InjectRepository : IModule
    {
        public void Registre(IUnityContainer container)
        {
            container.RegisterType<IOwner, OwnerRepository> (new ContainerControlledLifetimeManager());




            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString);
            using (var context = new MyContext(optionsBuilder.Options)) context.Database.EnsureCreated();

            container.RegisterType<MyContext>(new HierarchicalLifetimeManager(), new InjectionConstructor(optionsBuilder.Options));

            container.RegisterType<ILogger, LoggerRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IException, ExceptionRepository>(new ContainerControlledLifetimeManager());
        }
    }
}
