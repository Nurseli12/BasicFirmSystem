using BasicFirmSystem.Entities.Concretes;
using BasicFirmSystem.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Persistence.Repositories.EntityRepositories
{
    public class StockCardRepository : BaseRepository<StockCard, BaseDbContext>, IStockCardRepository
    {
        public StockCardRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
