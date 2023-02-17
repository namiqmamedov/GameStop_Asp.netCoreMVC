using GameStop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.Products
{
    public class ProductVM
    {
        public IEnumerable<Product> Products { get; set; }
        public Product Product { get; set; }
        public IEnumerable<ProductLabel> ProductLabels { get; set; }
        public IEnumerable<ProductCondition> ProductConditions { get; set; }
        public ProductSpecs ProductSpecs { get; set; }
        public ProductDescription ProductDescription { get; set; }
        public ProductFeatures ProductFeatures { get; set; }
        public ProductLabel ProductLabelsMain { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
