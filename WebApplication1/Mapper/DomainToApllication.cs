using Domain.Service;
using System.Collections.Generic;
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
                Name = @this.Name
            };
        }
    }
}