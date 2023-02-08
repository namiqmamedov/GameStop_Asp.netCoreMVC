using GameStop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.Products
{
    public class ProductDetailVM
    {
        public Dictionary<string, string> Settings { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
        public Product Product { get; set; }
        public List<Product> Products { get; set; }
    }
}
