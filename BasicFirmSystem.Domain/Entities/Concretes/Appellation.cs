
using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Entities.Concretes
{
    public class Appellation : Entity
    {
        public Appellation()
        {
        }

        public Appellation(
            int id,
            DateTime creationDate,
            bool status,
            string name,
            string explanation,
            DateTime updateDate
            ) : base(id,creationDate,status,explanation,updateDate)
        {
            Name = name;
            Explanation = explanation;
        }

        public string Name { get; set; }
        public string Explanation { get; set; }
    }
}
