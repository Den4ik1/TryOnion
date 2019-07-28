using System.Collections.Generic;
using Infro.Model;
using Domain.Service;
using System.Linq;
using DomainsService.Mappers;
using Domain.Model;

namespace DomainsService.Service
{
    public class DomainService : IDomains
    {
        private readonly IOwner _owner;

        public  DomainService(IOwner owner)
        {
            _owner = owner;
        }

        public IList<Domains> GetAllD()
        {
            var res = _owner.GetAll();

            return res.Select(_ => _.MappOwnerToDomains()).ToList();
        }

        public Domains GetId(int Id)
        {
            var res = _owner.GetId(Id);

            return res.MappOwnerToDomains();
            
        }

        public void AddOwnerDomain(int Id, string NameAdd)
        {
            _owner.AddOwnerInfro(Id, NameAdd);
        }
    }
}