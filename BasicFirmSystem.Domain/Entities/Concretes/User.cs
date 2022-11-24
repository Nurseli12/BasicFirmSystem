using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Domain.Entities.Concretes
{
    public class User:Entity
    {
        public User()
        {
        }


        public User(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            int appellationID,
            int roleID,
            string nameSurname,
            string eMail,
            string password,
            string phoneNumber,
            string gsmNumber,
            string ımageURL,
            bool movementStatusMail):base(id, creationDate, status, explanation, updateDate)
        {
            AppellationID=appellationID;
            RoleID=roleID;
            NameSurname=nameSurname;
            EMail=eMail;
            Password=password;
            PhoneNumber=phoneNumber;
            GsmNumber=gsmNumber;
            ImageURL=ımageURL;
            MovementStatusMail=movementStatusMail;
        }

        public int AppellationID { get; set; }
        public int RoleID { get; set; }
        public string NameSurname { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string GsmNumber { get; set; }
        public string ImageURL { get; set; }
        public bool MovementStatusMail { get; set; }
    }
}
