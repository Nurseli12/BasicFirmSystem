
using BasicFirmSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
   public class Order: Entity
    {
        public Order()
        {
        }

        public Order(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            int userID,
            string name,
            string code
            ) : base(id,creationDate,status,explanation,updateDate)
        {
        }

        public int UserID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        
    }
}
