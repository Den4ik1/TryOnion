using Domain.Service;
using System.Collections.Generic;

namespace Domain.Model
{
    public interface IDomains
    {
        IList<Domains> GetAllD();
    }
}
