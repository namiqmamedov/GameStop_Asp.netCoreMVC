using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
