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
        [Required]
        public string Title { get; set; }

        [Column("Money")]
        public double Price { get; set; }

        [DisplayName("Discounted Price")]
        public double DiscountedPrice { get; set; }

        [DisplayName("Old Price")]
        public double OldPrice { get; set; }

        [StringLength(255)]
        public string Brand { get; set; }

        [StringLength(9255)]
        public string Image { get; set; }

        [Range(0, int.MaxValue)]
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        public List<ProductImage> ProductImages { get; set; }
        public List<ProductFeatures> ProductFeatures { get; set; }
        public List<ProductDescription> ProductDescriptions { get; set; }
        public List<ProductSpecs> ProductSpecs { get; set; }
        public List<ProductLabel> ProductLabels { get; set; }
        public List<ProductCondition> ProductConditions { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }

        [NotMapped]
        //[Required]
        [DisplayName("Image")]
        public IFormFile File { get; set; }
        [DisplayName("Product Images")]
        [NotMapped]
        public IEnumerable<IFormFile> ProductImagesFile { get; set; }

        [DisplayName("Product Features")]
        [NotMapped]
        public List<string> ProductFeaturesMain { get; set; } = new List<string>();

        [DisplayName("Product Description")]
        [NotMapped]
        public List<string> ProductDescriptionMain { get; set; } = new List<string>();

        [DisplayName("Product Specifications")]
        [NotMapped]
        public List<string> ProductSpecsMain { get; set; }

        [NotMapped]
        public List<int> LabelIds { get; set; } = new List<int>();

        [NotMapped]
        public List<int> Counts { get; set; } = new List<int>();
        [NotMapped]
        public List<int> ConditionIds { get; set; } = new List<int>();

        [NotMapped]
        public List<int> CondCounts { get; set; } = new List<int>();


     


    }
}
