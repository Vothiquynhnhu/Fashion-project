﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Models
{
    public class CheckOutModel
    {
        public string checkout_ProductName { get; set; }
        public int checkout_Quantity { get; set; }
        public int checkout_Price { get; set; }
        public string checkout_Size { get; set; }
        public string checkout_Color { get; set; }
        public int checkout_ProductId { get; set; }


    }
}
