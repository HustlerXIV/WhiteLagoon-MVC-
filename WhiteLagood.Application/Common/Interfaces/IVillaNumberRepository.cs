﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagood.Application.Common.Interfaces
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        void Update(VillaNumber entity);
    }
}
