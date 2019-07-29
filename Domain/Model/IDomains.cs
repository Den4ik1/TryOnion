﻿using Domain.Service;
using System.Collections.Generic;

namespace Domain.Model
{
    public interface IDomains
    {
        IList<Domains> GetAllD();
        Domains GetId(int Id);
        void AddOwnerDomain(int Id, string Name);
        void DeleteOwnerDomain(int Id);
        void DrpoAllOwnerDomain();

    }
}
