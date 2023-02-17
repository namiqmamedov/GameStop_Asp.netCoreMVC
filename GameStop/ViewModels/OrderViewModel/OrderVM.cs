using GameStop.Models;
using GameStop.ViewModels.Basket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModels
{
    public class OrderVM
    {
        public Order Order { get; set; }
        //public List<BasketVM> BasketVMs { get; set; }
        //public List<Cart> Carts { get; set; }

        public List<BasketVM> BasketVMs { get; set; }
    }
}
