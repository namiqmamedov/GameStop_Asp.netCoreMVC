using GameStop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.CategoryMain
{
    public class CategoryVM
    {
        public IEnumerable<Category> Categories { get; set; }
        public Category Category { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
