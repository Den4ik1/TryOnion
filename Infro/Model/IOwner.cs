using System.Collections.Generic;
using Infro.InfroService;

namespace Infro.Model
{
    public interface IOwner
    {
        IList<Owner> GetAll();
        Owner GetId(int Id);
        void UpDate(int IdOwner, string name);
        void AddOwnerInfro(int Id, string Name);
        //void AddCar(int? ownerId, int AddCarID, string AddModel, string AddAgeMake);
        void DeleteOwner(int Id);
        void DrpoAllOwner();
    }
}