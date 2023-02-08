using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class ProductFeatures : BaseEntity
    {
        [StringLength(255)]
        [DisplayName("Features Title")]
        public string Title { get; set; }

        [DisplayName("Features Description")]
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
