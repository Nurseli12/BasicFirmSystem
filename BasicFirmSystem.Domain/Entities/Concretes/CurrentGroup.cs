﻿using BasicFirmSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
   public class CurrentGroup: Entity
    {
        public CurrentGroup()
        {
        }

        public CurrentGroup(
            int id,
            DateTime creationDate,
            bool status,
            string explanation,
            DateTime updateDate,
            string name
            ) : base(id,creationDate,status,explanation,updateDate)
        {
            Name = name;
             
        }

        public string Name { get; set; }
    }
}
