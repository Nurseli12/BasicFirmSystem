using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Persistence.Dynamic
{
    public class Filter
    {
        public string Field { get; set; }
        public string Operator { get; set; }
        public string? Value { get; set; }
        public IEnumerable<Filter>? Filters { get; set; }
        public Filter()
        {
        }

        public Filter(string field, string @operator, string? value, IEnumerable<Filter>? filters)
        {
            Field=field;
            Operator=@operator;
            Value=value;
            Filters=filters;
        }

        
    }
}
