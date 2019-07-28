using System.Collections.Generic;

namespace Infro.InfroService
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string Name { get; set; }
        public IList<Car> Cars { get; set; }
    }
}