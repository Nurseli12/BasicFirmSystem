using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class StockMainGroup : Entity
    {
        public StockMainGroup()
        {
        }

        public StockMainGroup(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            string stockMainName
            ) : base(id, creationDate, status,explanation,updateDate)
        {
            StockMainName = stockMainName;
        }

        public string StockMainName { get; set; }
    }
}
