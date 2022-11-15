using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Domain.Entities.Concretes
{
    public class Claim :Entity
    {
        public Claim() 
        {
        }

        public Claim(
            int id, DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            int roleID,
            bool currentCardAdd,
            bool currentCardExcelAdd,
            bool stockCardAdd,
            bool stockCardExcelImport,
            bool stockCardList) :base(id, creationDate, status, explanation, updateDate)
        {
            RoleID=roleID;
            CurrentCardAdd=currentCardAdd;
            CurrentCardExcelAdd=currentCardExcelAdd;
            StockCardAdd=stockCardAdd;
            StockCardExcelImport=stockCardExcelImport;
            StockCardList=stockCardList;
        }

        public int RoleID { get; set; }
        public bool CurrentCardAdd { get; set; }
        public bool CurrentCardExcelAdd { get; set; }
        public bool StockCardAdd { get; set; }
        public bool StockCardExcelImport { get; set; }
        public bool StockCardList { get; set; }
      
    }
}
