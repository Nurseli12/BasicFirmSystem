using BasicFirmSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class StockCard : Entity
    {
        public StockCard()
        {
        }

        public StockCard(
            int id,
            DateTime creationDate,
            bool status,
            DateTime updateDate,
            int stockMainGroupID,
            int stockMiddleGroupID,
            int stockSubGroupID,
            int currentCardID,
            int moneyUnitID,
            string name,
            string code,
            string barcode,
            string firmStockCode,
            string explanation,
            double purchasePrice,
            double salePrice,
            int vat,
            string imageURL,
            bool orderMail,
            int discount,
            int deadline
            ) : base(id, creationDate, status,explanation,updateDate)
        {
            StockMainGroupID = stockMainGroupID;
            StockMiddleGroupID = stockMiddleGroupID;    
            StockSubGroupID = stockSubGroupID;
            CurrentCardID = currentCardID;
            MoneyUnitID = moneyUnitID;
            Name = name;
            Code = code;
            Barcode = barcode;
            FirmStockCode = firmStockCode;
            Explanation = explanation;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            VAT = vat;
            ImageURL = imageURL;
            OrderMail = orderMail;
            Discount = discount;
            Deadline = deadline;

        }

        public int StockMainGroupID { get; set; }
        public int StockMiddleGroupID { get; set; }
        public int StockSubGroupID { get; set; }
        public int CurrentCardID { get; set; }
        public int MoneyUnitID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public string FirmStockCode { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public int VAT { get; set; }
        public string ImageURL { get; set; }
        public bool OrderMail { get; set; }
        public int Discount { get; set; }
        public int Deadline { get; set; }


    }
}
