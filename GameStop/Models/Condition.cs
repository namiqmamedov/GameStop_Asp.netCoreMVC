using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class Condition : BaseEntity
    {
        public string Name { get; set; }
        public List<ProductCondition> ProductCondition { get; set; }
    }
}
