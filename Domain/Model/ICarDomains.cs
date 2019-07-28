using Domain.Service;
using System.Collections.Generic;

namespace Domain.Model
{
    interface ICarDomains
    {
        IList<CarDomains> GetAllCar();
    }
}
