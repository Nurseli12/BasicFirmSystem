﻿
using BasicFirmSystem.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class TaxOffice : Entity
    {
        public TaxOffice()
        {
        }

        public TaxOffice(int id,
            DateTime creationDate,
            bool status,
            string explanation,
            string taxOfficeName,
            string taxOfficeAddress,
            string taxOfficeNumber
            ) : base(id, creationDate, status, explanation)
        {
            TaxOfficeName = taxOfficeName;
            TaxOfficeAddress = taxOfficeAddress;
            TaxOfficeNumber = taxOfficeNumber;
        }

        public string TaxOfficeName { get; set; }
        public string TaxOfficeAddress { get; set; }
        public string TaxOfficeNumber { get; set; }
    }
}
