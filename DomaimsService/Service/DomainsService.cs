using System.Collections.Generic;
using Domain.Model;

using Infro.Model;
using Domain.Service;
using System.Linq;
using DomaimsService.Mappers;

namespace DomaimsService.Service
{
    public class DomainsService
    {
        private readonly IOwner _owner;

        public  DomainsService(IOwner owner)
        {
            _owner = owner;
        }

        public IList<Domains> GetD()
        {
            var res = _owner.GetAll();

            return res.Select(_ => _.MappOwnerToDomains()).ToList();
        }


    }
}
