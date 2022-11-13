﻿using BasicFirmSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class StockMiddleGroup : Entity
    {
        public StockMiddleGroup()
        {
        }

        public StockMiddleGroup(int id,
            DateTime creationDate,
            bool status,
            string explanation,
            int stockMainGroupID,
            string stockMiddleName
            ) : base(id, creationDate, status, explanation)
        {
            StockMainGroupID = stockMainGroupID;
            StockMiddleName = stockMiddleName;  
        }

        public int StockMainGroupID { get; set; }
        public string StockMiddleName { get; set; }
    }
}