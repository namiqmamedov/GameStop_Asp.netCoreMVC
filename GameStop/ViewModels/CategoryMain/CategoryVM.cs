using GameStop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.CategoryMain
{
    public class CategoryVM
    {
        public IEnumerable<Category> Categories { get; set; }
    }
}
