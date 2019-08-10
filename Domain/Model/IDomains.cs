using Domain.Service;
using System.Collections.Generic;

namespace Domain.Model
{
    public interface IDomains
    {
        IList<Domains> GetAllD();
        Domains GetId(int Id);
        void UpDateDomain(int IdOwnerDomeain, string nameDomain);
        void AddOwnerDomain(int Id, string Name);
        //void AddCarDomain(int? DomainownerId, int DomainCarId, string DomainAddModel, string DomainAddAgeMake);
        void DeleteOwnerDomain(int Id);
        void DrpoAllOwnerDomain();

    }
}
