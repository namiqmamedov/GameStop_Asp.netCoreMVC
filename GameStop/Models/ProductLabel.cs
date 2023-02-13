using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class ProductLabel : BaseEntity
    {
        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public Label Label { get; set; }
        public int? LabelId { get; set; }
        [Range(0, int.MaxValue)] 
        public int Count { get; set; }
    }
}
