using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class ProductCondition : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Condition Condition { get; set; }
        public int ConditionId { get; set; }
        [Range(0, int.MaxValue)]
        public int Count { get; set; }
    }
}
