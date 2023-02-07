using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class SubCategory : BaseEntity
    {
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }

    }
}
