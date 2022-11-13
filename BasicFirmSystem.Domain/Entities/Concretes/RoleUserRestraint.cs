
using BasicFirmSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{

    public class RoleUserRestraint : Entity
    {
        public RoleUserRestraint()
        {
        }

        public RoleUserRestraint(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            int roleID,
            int stockCardID,
            int amount,
            int time
            ) : base(id, creationDate, status,explanation)
        {
            RoleID = roleID;
            StockCardID = stockCardID;
            Amount = amount;
            Time = time;
        }

        public int RoleID { get; set; }
        public int StockCardID { get; set; }
        public int Amount { get; set; }
        public int Time { get; set; }
    }
}
