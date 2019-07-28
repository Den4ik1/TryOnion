using WebApplication1.Models;
using Domain.Service;

namespace WebApplication1.Mapper
{
    public static class DomainToApllicationCar
    {
        public static CarModel DomainToAplCar(this CarDomains @this)
        {
            return new CarModel()
            {
                CarID = @this.CarID,
                Model = @this.Model,
                AgeMake = @this.AgeMake
            };
        }
    }
}