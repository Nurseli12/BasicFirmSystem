﻿using BasicFirmSystem.Persistence.Repositories;
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
            string name
            ) : base(id,creationDate,status,explanation)
        {
            Name = name;
             
        }

        public string Name { get; set; }
    }
}