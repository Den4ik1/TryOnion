using System.Collections.Generic;
using Infro.InfroService;

namespace Infro.Model
{
    public interface IOwner
    {
        IList<Owner> GetAll();
        Owner GetId(int Id);
        void AddOwnerInfro(int Id, string Name);
    }
}