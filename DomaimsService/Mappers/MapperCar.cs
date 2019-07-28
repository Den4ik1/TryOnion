using Domain.Service;
using Infro.InfroService;


namespace DomaimsService.Mappers
{
    public static class MapperCar
    {
        public static CarDomains InfroToDomainsCar(this Car @this)
        {
            return new CarDomains()
            {
                CarID = @this.CarID,
                Model = @this.Model,
                AgeMake = @this.AgeMake
            };
        }
    }
}
