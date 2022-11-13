
using BasicFirmSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class StockAuthorization : Entity
    {
        public StockAuthorization()
        {
        }

        public StockAuthorization(
            int id,
            DateTime creationDate,
            bool status,
            int StockCardID,
            int RoleID,
            string name,
            string explanation
            ) : base(id, creationDate, status,explanation)
        {
        }

        public int StockCardID { get; set; }
        public int RoleID { get; set; }
        public string Name { get; set; }
    }
}
