using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Shoes.Entity
{
    public class Coupons
    {
        public string couponId { set; get; }
        public string couponCode { set; get; }
        public int couponPrice { set; get; }
        public int couponAmount { set; get; }
        public int couponAmountUsed { set; get; }


    }
}
