using Infro.InfroService;
using Infro.Model;
using System.Collections.Generic;
using System.Linq;

namespace Infra
{/*
    public class FakeRepository : IOwner
    {

        #region //ownerDB 
        public static List<Owner> ownerDB = new List<Owner>()
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
        
        public void AddOwnerInfro(int Id, string NameAdd)
        {
            ownerDB.Add (new Owner {OwnerID = Id, Name = NameAdd, Cars = null});
        }

        public void AddCar(int? ownerId, int AddCarID, string AddModel, string AddAgeMake)
        {
            int index = ownerDB.FindIndex(_ => _.OwnerID == ownerId);
            if (index != 0)
                if (ownerDB[index].Cars != null)
                {
                    ownerDB[index].Cars.Add(new Car()
                    {
                        CarID = AddCarID,
                        Model = AddModel,
                        AgeMake = AddAgeMake
                    });
                }
                else
                {
                    ownerDB[index].Cars = new List<Car>()
                    {
                        new Car(){
                        CarID = AddCarID,
                        Model = AddModel,
                        AgeMake = AddAgeMake
                        }
                    };
                }
        }

        public void DeleteOwner(int Id)
        {
            ownerDB = ownerDB.Where(_ => _.OwnerID != Id).ToList();
        }

        public void DrpoAllOwner()
        {
            ownerDB.Clear();
        }
    }*/

}