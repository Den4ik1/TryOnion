using Domain.Service;
using System.Collections.Generic;

namespace Domain.Service
{
    public class Domains
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<CarDomains> Cars { get; set; }
    }
}
