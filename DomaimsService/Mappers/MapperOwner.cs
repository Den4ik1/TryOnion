using System.Collections.Generic;
using Domain.Service;
using Infro.InfroService;


namespace DomainsService.Mappers
{
    public static class MapperOwner
    {
        public static Domains MappOwnerToDomains(this Owner @this)
        {
            Domains domains = new Domains
            {
                Id = @this.OwnerID,
                Name = @this.Name
            };

            return domains;
        }
    }
}
