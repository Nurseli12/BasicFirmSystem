using BasicFirmSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class StockMiddleGroup : Entity
    {
        public StockMiddleGroup()
        {
        }

        public StockMiddleGroup(int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            int stockMainGroupID,
            string stockMiddleName
            ) : base(id, creationDate, status, explanation,updateDate)
        {
            StockMainGroupID = stockMainGroupID;
            StockMiddleName = stockMiddleName;  
        }

        public int StockMainGroupID { get; set; }
        public string StockMiddleName { get; set; }
    }
}
