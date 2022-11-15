﻿using BasicFirmSystem.Entities.Concretes;
using BasicFirmSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Application.Services.Repositories
{
    public interface ICurrentCardRepository :IBaseRepository<CurrentCard>
    {
    }
}
