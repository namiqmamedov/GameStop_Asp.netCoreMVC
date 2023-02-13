using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class Label : BaseEntity
    {
        public string Name { get; set; }
        public List<ProductLabel> ProductLabels { get; set; }
    }
}
