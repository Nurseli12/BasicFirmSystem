using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    public class Entity
    {
        public int ID { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime UpdateDate { get; set; }
        public bool Status { get; set; } = false;
        public string Explanation { get; set; }
        public Entity()
        {

        }
        public Entity(int id, DateTime creationDate, bool status, string explanation, DateTime updateDate) : this()
        {
            ID = id;
            CreationDate = creationDate;
            Status = status;
            Explanation = explanation;
            UpdateDate=updateDate;
        }
    }
}
