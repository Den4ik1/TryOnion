using Infra.Contexts;
using Infro.InfroService;
using Infro.Model;


namespace Infra.Repository
{
    public class ExceptionRepository : IException
    {
        private readonly MyContext _context;

        public ExceptionRepository(MyContext context)
        {
            _context = context;
        }

        public void ExceptionInformation(ExceptionLog exception)
        {
            _context.Add(exception);
            _context.SaveChanges();
        }
    }
}
