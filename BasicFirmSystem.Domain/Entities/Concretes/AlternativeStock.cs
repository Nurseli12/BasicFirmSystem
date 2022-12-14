using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class AlternativeStock : Entity
    {
        public AlternativeStock()
        {
        }

        public AlternativeStock(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            int alternativeStockCardID,
            int stockCardID
            ) : base(id,creationDate,status,explanation,updateDate)
        {
            StockCardID = stockCardID;
            AlternativeStockCardID = alternativeStockCardID;
            Status = status;
        }

        public int StockCardID { get; set; }
        public int AlternativeStockCardID { get; set; }
    }
}
