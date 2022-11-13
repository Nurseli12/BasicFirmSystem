using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool Status { get; set; } = false;
        public string Explanation { get; set; }
        public Entity()
        {

        }
        public Entity(int id, DateTime creationDate, bool status, string explanation) : this()
        {
            Id = id;
            CreationDate = creationDate;
            Status = status;
            Explanation = explanation;
        }
    }
}
