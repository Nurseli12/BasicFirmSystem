using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class StockTechnicalFeature : Entity
    {
        public StockTechnicalFeature()
        {
        }

        public StockTechnicalFeature(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            int stockCardID,
            string title,
            string detail,
            string imageURL
            ) : base(id, creationDate, status, explanation,updateDate)
        {
            StockCardID = stockCardID;
            Title = title;
            Detail = detail;
            ImageURL = imageURL;
        }

        public int StockCardID { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ImageURL { get; set; }

    }
}
