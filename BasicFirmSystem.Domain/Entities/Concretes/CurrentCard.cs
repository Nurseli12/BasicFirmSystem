using BasicFirmSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class CurrentCard : Entity
    {
        public CurrentCard()
        {
        }
        public CurrentCard(

            int id,
            DateTime creationDate,
            bool status,
            int currentGroupID,
            int currentSubGroupID,
            int taxOfficeID,
            string currentAppellation,
            string name,
            string code,
            string address,
            string explanation,
            string email,
            string phoneNumber,
            string gsmNumber,
            string deliveryAddress
        ) : base(id,creationDate,status,explanation)
        {
            CurrentGroupID = currentGroupID;
            CurrentSubGroupID=currentSubGroupID;
            TaxOfficeID = taxOfficeID;
            CurrentAppellation = currentAppellation;
            Name = name;
            Code = code;
            Address = address;
            Explanation = explanation;
            EMail = email;
            PhoneNumber = phoneNumber;
            GsmNumber = gsmNumber;
            DeliveryAddress = deliveryAddress;


        }
        public int CurrentGroupID { get; set; }
        public int CurrentSubGroupID { get; set; }
        public int TaxOfficeID { get; set; }
        public string CurrentAppellation { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string GsmNumber { get; set; }
        public string DeliveryAddress { get; set; }
    }
}
