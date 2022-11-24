using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
   public class CurrentSubGroup: Entity
    {
        public CurrentSubGroup()
        {
        }

        public CurrentSubGroup(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            string currentSubGroupName
            ) : base(id,creationDate,status,explanation,updateDate)
        {
            CurrentSubGroupName = currentSubGroupName;
        }

        public string CurrentSubGroupName { get; set; }
    }
}
