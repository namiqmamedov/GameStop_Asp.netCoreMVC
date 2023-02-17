using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int Count { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
