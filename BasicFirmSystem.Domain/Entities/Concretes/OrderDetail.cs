
using BasicFirmSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class OrderDetail : Entity
    {
        public OrderDetail()
        {
        }

        public OrderDetail(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            int orderID,
            int stockCardID,
            int amount
            ) : base(id, creationDate, status,explanation)
        {
        }

        public int OrderID { get; set; }
        public int StockCardID { get; set; }
        public int Amount { get; set; }
    }
}
