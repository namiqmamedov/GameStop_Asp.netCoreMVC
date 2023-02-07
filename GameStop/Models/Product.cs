using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Models
{
    public class Product : BaseEntity
    {

        public string MyProperty { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        [Column("Money")]
        public double Price { get; set; }
        public double Pric1e { get; set; }

        [Column("Money")]
        [DisplayName("Discounted Price")]
        public double DiscountedPrice { get; set; }

        [StringLength(255)]
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }
        public IEnumerable<ProductImage> ProductImages{ get; set; }

    }
}
