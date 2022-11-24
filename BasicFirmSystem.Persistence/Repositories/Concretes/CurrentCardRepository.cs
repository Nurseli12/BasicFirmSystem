using BasicFirmSystem.Entities.Concretes;
using BasicFirmSystem.Persistence.Contexts;
using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Persistence.Repositories.EntityRepositories
{
    public class CurrentCardRepository : BaseRepository<CurrentCard, BaseDbContext>, ICurrentCardRepository
    {
        public CurrentCardRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
