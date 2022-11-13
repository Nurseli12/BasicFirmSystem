
using BasicFirmSystem.Domain.Entities;
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
            string name
            ) : base(id,creationDate,status,explanation)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
