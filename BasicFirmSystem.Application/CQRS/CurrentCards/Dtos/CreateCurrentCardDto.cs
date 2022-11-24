using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Application.CQRS.CurrentCards.Dtos
{
    public class CreateCurrentCardDto
    {
        public int ID { get; set; }
        public int CurrentGroupID { get; set; }
        public int CurrentSubGroupID { get; set; }
        public int TaxOfficeID { get; set; }
        public string CurrentAppellation { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Explanation { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string GsmNumber { get; set; }
    }
}
