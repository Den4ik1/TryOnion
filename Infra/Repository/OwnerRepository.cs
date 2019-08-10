using Infra.Contexts;
using Infro.InfroService;
using Infro.Model;
using System.Collections.Generic;
using System.Linq;

namespace Infra.Repository
{
    public class OwnerRepository : IOwner
    {
        private readonly MyContext _context;

        public OwnerRepository(MyContext context)
        {
            _context = context;
        }


        /*public void AddCar(int? ownerId, int AddCarID, string AddModel, string AddAgeMake)
        {
                ;
        }*/
        public void UpDate(int IdOwner, string name)
        {
            var owner = _context.Owners.FirstOrDefault(_ => _.OwnerID == IdOwner);
            owner.Name = name;
            _context.SaveChanges();
        }


        public void AddOwnerInfro(int Id, string Name)
        {
            
            _context.Owners.Add(new Owner() { Name = Name, Cars = null} );
            _context.SaveChanges();
        }

        public void DeleteOwner(int Id)
        {
            _context.Owners.Remove(_context.Owners.FirstOrDefault(_ => _.OwnerID == Id));
            _context.SaveChanges();
        }

        public void DrpoAllOwner()
        {
            var dataowner = _context.Owners.First();
            while (dataowner != null)
            {
                _context.Owners.Remove(dataowner);
                dataowner = _context.Owners.First();
            }
                _context.SaveChanges();
            
        }

        public IList<Owner> GetAll()
        {
            return _context.Owners.ToList();
        }

        public Owner GetId(int Id)
        {
            var owners = _context.Owners;

            foreach (var owner in owners)
            {
                if (owner != null && owner.OwnerID == Id)
                {
                    return owner;
                }
               
            }
            return default(Owner);
        }

      


    }
}
