using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Domain.Entities.Concretes
{
    public class Role:Entity
    {
        public Role()
        {
        }

        public Role(
             int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            string roleName) : base(id, creationDate, status, explanation, updateDate)
        {
            RoleName=roleName;
        }

        public string RoleName { get; set; }
       
    }
}
