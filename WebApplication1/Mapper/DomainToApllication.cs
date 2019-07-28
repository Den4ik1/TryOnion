using Domain.Service;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Mapper
{
    public static class DomainToApllication
    {
        public static OwnerModel ToApllication(this Domains @this)
        {

            return new OwnerModel()
            {
                Id = @this.Id,
                Name = @this.Name,
                Car = @this.Cars.Select(_ => _.DomainToAplCar()).ToList()
            };
        }
    }
}