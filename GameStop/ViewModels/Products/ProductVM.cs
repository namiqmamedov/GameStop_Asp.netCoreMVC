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
        public IEnumerable<ProductLabel> ProductLabels { get; set; }
        public IEnumerable<ProductCondition> ProductConditions { get; set; }
    }
}
