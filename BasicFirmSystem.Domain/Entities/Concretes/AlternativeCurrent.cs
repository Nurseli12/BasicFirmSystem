
using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class AlternativeCurrent : Entity
    {
        public AlternativeCurrent()
        {
        }

        public AlternativeCurrent(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            int stockCardID,
            int currentCardID,
            int moneyUnitID,
            double purchasePrice,
            int deadline

            ) : base(id,creationDate,status,explanation,updateDate)
        {
            StockCardID = stockCardID;
            CurrentCardID = currentCardID;
            MoneyUnitID = moneyUnitID;
            PurchasePrice = purchasePrice;
            Deadline = deadline;
        }

        public int StockCardID { get; set; }
        public int CurrentCardID { get; set; }
        public int MoneyUnitID { get; set; }
        public double PurchasePrice { get; set; }
        public int Deadline { get; set; }
    }
}
