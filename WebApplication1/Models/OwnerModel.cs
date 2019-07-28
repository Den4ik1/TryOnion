using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class OwnerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<CarModel> Car { get; set; }
    }
}