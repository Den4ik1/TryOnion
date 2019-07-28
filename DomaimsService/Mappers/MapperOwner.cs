
using System.Linq;
using DomaimsService.Mappers;
using Domain.Service;
using Infro.InfroService;


namespace DomainsService.Mappers
{
    public static class MapperOwner
    {
        public static Domains MappOwnerToDomains(this Owner @this)
        {
            if (@this.Cars != null)
            {
                return new Domains
                {
                    Id = @this.OwnerID,
                    Name = @this.Name,
                    Cars = @this.Cars.Select(_ => _.InfroToDomainsCar()).ToList()
                };
            }
            else
            {
                return new Domains
                {
                    Id = @this.OwnerID,
                    Name = @this.Name,
                    Cars = null
                };
            }
        }
    }
}
