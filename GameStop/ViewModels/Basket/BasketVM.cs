using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels.Basket
{
    public class BasketVM
    {
        public int ProductID { get; set; }
        public int Count { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
