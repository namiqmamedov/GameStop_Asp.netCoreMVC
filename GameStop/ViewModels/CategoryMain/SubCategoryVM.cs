using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.CategoryMain
{
    public class SubCategoryVM
    {
        public CategoryVM Category { get; set; }
        public List<CategoryVM> Categories { get; set; }

        public SubCategoryVM SubCategory { get; set; }
        public List<SubCategoryVM> SubCategoryVMs  { get; set; }
    }
}
