
using BasicFirmSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class StockSubGroup : Entity
    {
        public StockSubGroup()
        {
        }

        public StockSubGroup(int id,
            DateTime creationDate,
            bool status,
            string explanation,
            int stockMiddleGroupID,
            string stockSubName
            ) : base(id, creationDate, status, explanation)
        {
            StockMiddleGroupID = stockMiddleGroupID;
            StockSubName = stockSubName;
        }

        public int StockMiddleGroupID { get; set; }
        public string StockSubName { get; set; }
    }
}
