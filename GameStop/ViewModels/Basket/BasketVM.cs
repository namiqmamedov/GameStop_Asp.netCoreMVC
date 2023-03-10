using GameStop.Models;
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
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public double DiscountedPrice { get; set; }
        public string Label { get; set; }
        public int LabelId { get; set; }
        public string Condition { get; set; }
        public int ConditionId { get; set; }

    }
}
