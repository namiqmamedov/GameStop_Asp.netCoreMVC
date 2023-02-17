using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class ProductDescription : BaseEntity
    {
        [StringLength(2255)]
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
