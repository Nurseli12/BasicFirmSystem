using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class TechnicalImage : Entity
    {
        public TechnicalImage()
        {
        }

        public TechnicalImage(int id,
            DateTime creationDate,
            bool status,
            DateTime updateDate,
            string explanation,
            int stockCardID,
            string imageURL
            ) : base(id, creationDate, status, explanation,updateDate)
        {
            StockCardID = stockCardID;
            ImageURL = imageURL;
        }

        public int StockCardID { get; set; }
        public string ImageURL { get; set; }
    }
}
