﻿using GameStop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewModel
{
    public class ProductVM
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
