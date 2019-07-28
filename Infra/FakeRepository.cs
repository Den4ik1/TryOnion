using Infro.InfroService;
using Infro.Model;
using System.Collections.Generic;

namespace Infra
{
    public class FakeRepository : IOwner
    {
        public List<Owner> x = new List<Owner>
        {
            new Owner { OwnerID = 1, Name = "1" },
            new Owner { OwnerID = 2, Name = "2"},
            new Owner { OwnerID = 3, Name = "3"}
        };

        public IList<Owner> GetAll()
        {
            return x;
        }
    }

}

