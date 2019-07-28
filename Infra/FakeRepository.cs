using Infro.InfroService;
using Infro.Model;
using System.Collections.Generic;
using System.Linq;

namespace Infra
{
    public class FakeRepository : IOwner
    {

        #region //ownerDB 
        public List<Owner> ownerDB = new List<Owner>()
       {
         new Owner {OwnerID = 1,  Name = "Ivan",
                           Cars = new Car[]
                           {
                               new Car { CarID = 1, Model = "Mazda", AgeMake = "1998"},
                               new Car { CarID = 2, Model = "Lada", AgeMake = "2010"}
                           }
         },

         new Owner {OwnerID = 2,  Name = "Alex",
                           Cars = new Car[]
                           {
                               new Car { CarID = 1, Model = "BMW", AgeMake = "1994"},
                               new Car { CarID = 2, Model = "WAZ", AgeMake = "2000"},
                               new Car { CarID = 3, Model = "Ford", AgeMake = "2014"}
                           }
         },

          new Owner {OwnerID = 3,  Name = "Jan",
                           Cars = new Car[]
                           {
                               new Car { CarID = 1, Model = "Mercedes", AgeMake = "2016"},
                           }
         }
       };
        #endregion


        public IList<Owner> GetAll()
        {
            return ownerDB;
        }

        public Owner GetId(int Id)
        {
            return ownerDB.FirstOrDefault(_ => _.OwnerID == Id);
        }
    }

}