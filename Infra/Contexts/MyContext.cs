using Infra.Configuration;
using Infro.InfroService;
using Microsoft.EntityFrameworkCore;

namespace Infra.Contexts
{
    public class MyContext  : DbContext
    {
        public virtual DbSet<Owner> Owners { get; set; }

        public virtual DbSet<Logger> Logs { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder
                .ApplyConfiguration(new OwnerConfiguration())
                .ApplyConfiguration(new LogConfigyration())
);
        }
    }
}
