using Microsoft.AspNetCore.Http;
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

        [StringLength(255)]
        public string Title { get; set; }

        [Column("Money")]
        public double Price { get; set; }

        [DisplayName("Discounted Price")]
        public double DiscountedPrice { get; set; }

        [DisplayName("Old Price")]
        public double OldPrice { get; set; }

        [StringLength(255)]
        public string Brand { get; set; }

        [StringLength(255)]
        public string Image { get; set; }

        [Range(0,int.MaxValue)]
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        public IEnumerable<ProductImage> ProductImages { get; set; }
        public IEnumerable<ProductFeatures> ProductFeatures { get; set; }
        public IEnumerable<ProductSpecs> ProductSpecs { get; set; }
        public IEnumerable<ProductLabel> ProductLabels { get; set; }
        public IEnumerable<ProductCondition> ProductConditions { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

    }
}
