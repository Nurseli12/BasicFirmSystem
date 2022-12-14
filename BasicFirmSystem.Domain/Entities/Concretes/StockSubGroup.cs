using Core.Domain.Entities;
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
            DateTime updateDate,
            int stockMiddleGroupID,
            string stockSubName
            ) : base(id, creationDate, status, explanation,updateDate)
        {
            StockMiddleGroupID = stockMiddleGroupID;
            StockSubName = stockSubName;
        }

        public int StockMiddleGroupID { get; set; }
        public string StockSubName { get; set; }
    }
}
